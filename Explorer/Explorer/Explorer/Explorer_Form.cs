using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.Reflection;

namespace Explorer
{
    public partial class MainForm : Form
    {
        List<Window> panels;//список панелей, отображающих файлы и папки
        const string DirIcon = "1.ico";//имя файла с иконкой папки
        List<string> movingFile;//список файлов для перемещения
        List<string> movingDir;//список папок для перемещения
        string renamingFile;//полное имя переименовываемого
        enum Operation
        {
            Move, Copy
        }
        Operation operation;//выбранная операция

        [Serializable]
        public class SFont//для сериализации шрифта и цвета
        {
            public string Name { get; set; }
            public float Size { get; set; }
            public int FontStyle { get; set; }
            public string Color { get; set; }
        }

        public MainForm()
        {
            InitializeComponent();
            panels = new List<Window>();
            panels.Add(new Window(ref FilesViewer1, ref PathBox1, ref DrivesList1, ref contextMenuStrip1, ref imageList1, Image.FromFile(DirIcon)));
            panels.Add(new Window(ref FilesViewer2, ref PathBox2, ref DrivesList2, ref contextMenuStrip2, ref imageList2, Image.FromFile(DirIcon)));
            List<DriveInfo> drives = DriveInfo.GetDrives().ToList();//получение списка доступных логических дисков
            if (drives.Count == 0)
            {
                MessageBox.Show("Нет доступных дисков!");
            }
            panels.ForEach(p => p.AddDrives(drives));
            if (new FileInfo("Settings.xml").Exists)//восстановление сохраненного шрифта
            {
                using (FileStream fs = new FileStream("Settings.xml", FileMode.Open))
                {
                    XmlSerializer s = new XmlSerializer(typeof(SFont));
                    SFont font = (SFont)s.Deserialize(fs);
                    panels.ForEach(p => p.ChangeColor(new Font(font.Name, font.Size, (FontStyle)font.FontStyle, (GraphicsUnit)3), Color.FromName(font.Color)));
                }
            }
            movingFile = new List<string>();
            movingDir = new List<string>();
        }

  
        private void DrivesList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            panels.Where(p => p.DrivesList == sender as ComboBox).ToList().ForEach(p => p.ChangeDirectory(new DirectoryInfo(p.DrivesList.SelectedItem.ToString())));//отображение содержимого выбранного диска
        }

        private void PathBox1_Leave(object sender, EventArgs e)
        {
            panels.Where(p => p.PathBox == sender as TextBox).ToList().ForEach(p =>
            {
                if (!p.PathBox_Leave())
                {
                    MessageBox.Show("Введено некорректное имя","Ошибка ввода");
                }
            });//переход по введенному пути
        }

        private void PathBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)//при нажатии клавиши Enter
            {
                panels.Where(p => p.PathBox == sender as TextBox).ToList().ForEach(p => p.PathEntered());
            }
        }

        private void PathBox1_Enter(object sender, EventArgs e)
        {
            panels.Where(p => p.PathBox == sender as TextBox).ToList().ForEach(p => p.PathStartChanging());//отображение буквы диска при редактировании поля
        }

        private void FilesViewer1_DoubleClick(object sender, EventArgs e)//открытие файла или папки
        {
            string s = ((ListView)sender).Name;
            int i = Convert.ToInt32(s.Substring(s.Length - 1)) - 1;
            if (!panels[i].FileChose())
            {
                MessageBox.Show("Отказано в доступе!");
            }
        }
		    private void Rename_Click(object sender, EventArgs e)//переименование файла или папки
        {
            panels.Where(p => p.ContextMenu.Items.Contains(sender as ToolStripMenuItem)).ToList().ForEach(p =>
            {
                if (p.ItemsChose())
                {
					toolStripTextBox1.Text= p.SelectedItem();
					переименоватьToolStripMenuItem.Enabled = true;
					movingFile.Clear();
                    renamingFile = p.DirPath + @"\" + p.SelectedItem();
                }
            });
        }

			private void Move_Click(object sender, EventArgs e)//запись выбранных ждя перемещения объектов
        {
            panels.Where(p => p.ContextMenu.Items.Contains(sender as ToolStripMenuItem)).ToList().ForEach(p =>
            {
                if (p.ItemsChose())
                {
                    Tuple<List<string>, List<string>> m = p.GetMovingFiles();
                    movingFile = m.Item2;
                    movingDir = m.Item1;
                    p.DirName = p.DirPath + @"\";
                    operation = Operation.Move;
                    p.ContextMenu.Items[4].Enabled = true;
                }
            });
        }

        private void Copy_Click(object sender, EventArgs e)//запись выбранных для копирования объектов
        {
            panels.Where(p => p.ContextMenu.Items.Contains(sender as ToolStripMenuItem)).ToList().ForEach(p =>
            {
                if (p.ItemsChose())
                {
                    Tuple<List<string>, List<string>> m = p.GetMovingFiles();
                    movingFile = m.Item2;
                    movingDir = m.Item1;
                    p.DirName = p.DirPath + @"\";
                    operation = Operation.Copy;
                    p.ContextMenu.Items[4].Enabled = true;
                }
            });
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            panels.Where(p => p.ContextMenu == sender as ContextMenuStrip).ToList().ForEach(p =>
            {
                if (p.ItemsChose())//включение контекстного меню для файлов и папок
                {
                    for (int i = 0; i < 4; i++)
                    {
                        p.ContextMenu.Items[i].Enabled = true;
                    }
                }
                else//выключение при клике на пустую область
                {
                    for (int i = 0; i < 4; i++)
                    {
                        p.ContextMenu.Items[i].Enabled = false;
                    }
                }
            });
        }

        private void Insert_Click(object sender, EventArgs e)//перемещение или копирование выбранных объектов
        {
            panels.Where(p => p.ContextMenu.Items.Contains(sender as ToolStripMenuItem)).ToList().ForEach(p =>
            {
                p.ContextMenu.Items[4].Enabled = false;
                InsertAsync(p);
            });
        }

        private async void InsertAsync(Window p)
        {
            if (operation == Operation.Move)//перемещение
            {
                await Task.Run(() => movingFile.ForEach(f => { try { new FileInfo(p.DirName + f).MoveTo(p.DirPath + @"\" + f); } catch (Exception ) { } }));
                await Task.Run(() => movingDir.ForEach(f => { try { new DirectoryInfo(p.DirName + f).MoveTo(p.DirPath + @"\" + f); } catch (Exception) { } }));
            }
            else if (operation == Operation.Copy)//копирование
            {
                await Task.Run(() => movingFile.ForEach(f => { try { new FileInfo(p.DirName + f).CopyTo(p.DirPath + @"\" + f); } catch (Exception) { } }));
                await Task.Run(() => movingDir.ForEach(async f => { try { await CopyDir(f, p); } catch (Exception) { } }));
            }
            panels.ForEach(ps => ps.DisplayContent());
        }

        private async Task CopyDir(string f, Window p)//копирование папки - создание вложенных папок и копирование вложенных файлов
        {
            DirectoryInfo dir = new DirectoryInfo(p.DirName + f);
            await Task.Run(() => Directory.CreateDirectory(p.DirPath + @"\" + f));
            foreach (FileInfo fi in dir.GetFiles())
            {
                await Task.Run(() => fi.CopyTo(p.DirPath + @"\" + f + @"\" + fi.Name));
            }
            foreach (DirectoryInfo di in dir.GetDirectories())
            {
                await CopyDir(f + @"\" + di.Name, p);
            }
        }

        private void Delete_Click(object sender, EventArgs e)//удаление выбранных объектов
        {
            panels.Where(p => p.ContextMenu.Items.Contains(sender as ToolStripMenuItem)).ToList().ForEach(p =>
            {
                p.DirName = p.DirPath + @"\";
                if (p.ItemsChose())
                {
                    p.DeleteFilesInDir(p.DirName);
                }
            });
            panels.ForEach(p => p.DisplayContent());
        }

		private void выбратьШрифтИЦветToolStripMenuItem_Click(object sender, EventArgs e) // изменение шрифта и цвета + запись в файл
		{
			if (fontDialog1.ShowDialog() == DialogResult.OK)
			{
				Font font = fontDialog1.Font;
				Color color = FilesViewer1.ForeColor;
				if (colorDialog1.ShowDialog() == DialogResult.OK)
				{
					color = colorDialog1.Color;
				}
				panels.ForEach(p => p.ChangeColor(font, color));
				using (FileStream fs = new FileStream("Settings.xml", FileMode.Create))
				{
					XmlSerializer s = new XmlSerializer(typeof(SFont));
					s.Serialize(fs, new SFont() { Name = font.Name, Size = font.Size, FontStyle = (int)font.Style, Color = color.Name });
				}
			}
			
		}

		private void информацияОСборкеToolStripMenuItem1_Click(object sender, EventArgs e) //небольшая информация о сборке
		{
			string types = default(string);
			foreach (Type type in Assembly.GetExecutingAssembly().GetTypes())
			{
				types += type.Name + "\n";
			}
			MessageBox.Show(types);
			types = default(string);
			foreach (Type type in Assembly.GetExecutingAssembly().GetExportedTypes())
			{
				types += type.Name + "\n";
			}
			MessageBox.Show(types);
		}

		private void переименоватьToolStripMenuItem_Click(object sender, EventArgs e) //окончательное переименование файла/папки
		{
			if (!string.IsNullOrWhiteSpace(toolStripTextBox1.Text))
			{
				try
				{
					FileInfo fi = new FileInfo(renamingFile);
					fi.MoveTo(fi.DirectoryName + @"\" + toolStripTextBox1.Text);
					panels.ForEach(p => p.DisplayContent());
					toolStripTextBox1.Text = default(string);
					переименоватьToolStripMenuItem.Enabled = false;
					panels.ForEach(p => p.DisplayContent());
				}
				catch(System.UnauthorizedAccessException) { MessageBox.Show("Отказано в доступе !"); }
				finally {
					toolStripTextBox1.Text = default(string);
					переименоватьToolStripMenuItem.Enabled = false;
				}
			}
		
			}
	}
}
