using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Explorer
{
    class Window
    {
        public ListView FilesViewer;
        public TextBox PathBox;
        public ComboBox DrivesList;
        public ContextMenuStrip ContextMenu;
        Image dirIcon;
        ImageList iconList;

        public string DirName { get; set; }

        DirectoryInfo directory;

        public string DirPath
        {
            get
            {
                return directory.FullName;
            }
        }

        public Window(ref ListView listView, ref TextBox textBox, ref ComboBox comboBox, ref ContextMenuStrip contextMenuStrip, ref ImageList imageList, Image icon)
        {
            FilesViewer = listView;
            PathBox = textBox;
            DrivesList = comboBox;
            ContextMenu = contextMenuStrip;
            dirIcon = icon;
            iconList = imageList;
        }

        public void AddDrives(List<DriveInfo> drives)//добавление списка доступных логических дисков
        {
            drives.ForEach(e => DrivesList.Items.Add(e.Name));
            DrivesList.SelectedIndex = 0;
            directory = new DirectoryInfo(drives[0].Name);
            DisplayContent();
        }

        public void ChangeColor(Font font, Color color)//изменение шрифта и цвета текста на панели
        {
            FilesViewer.Font = font;
            FilesViewer.ForeColor = color;
            PathBox.Font = font;
            PathBox.ForeColor = color;
            DrivesList.Font = font;
            DrivesList.ForeColor = color;
            ContextMenu.Font = font;
            ContextMenu.ForeColor = color;
        }

        public void DisplayContent()//обновление содержимого выбранной папки
        {
            FilesViewer.Items.Clear();
            iconList.Images.Clear();
            iconList.Images.Add(dirIcon);
			try
			{
				foreach (DirectoryInfo d in directory.GetDirectories())
				{
					ListViewItem lvi = new ListViewItem(d.Name);
					lvi.SubItems.Add("");
					lvi.ImageIndex = 0;
					FilesViewer.Items.Add(lvi);
				}
			
			foreach (FileInfo f in directory.GetFiles())
            {
                iconList.Images.Add(Icon.ExtractAssociatedIcon(f.FullName));
                ListViewItem lvi = new ListViewItem(f.Name);
                lvi.SubItems.Add(f.Length.ToString());
                lvi.ImageIndex = iconList.Images.Count - 1;
                FilesViewer.Items.Add(lvi);
            }
			}
			catch (System.IO.IOException) { MessageBox.Show( "Нет доступа", "Ошибка"); }
		}

        public void ChangeSize(Size clientSize, int underHeight, double l)//изменение размера контролов в зависимости от размера формы
        {
            FilesViewer.Width = clientSize.Width / 2;
            FilesViewer.Height = clientSize.Height - DrivesList.Height - underHeight;
            PathBox.Width = FilesViewer.Width - DrivesList.Width;
            DrivesList.Left = (int)(clientSize.Width * l);
            PathBox.Left = DrivesList.Left + DrivesList.Width;
            FilesViewer.Left = (int)(clientSize.Width * l);
        }

        public void ChangeDirectory(DirectoryInfo directoryInfo)//смена текущей папки
        {
            directory = directoryInfo;
            PathBox.Text = directory.FullName.Substring(3);
            DisplayContent();
        }

        public bool PathBox_Leave()//переход по введенному пути
        {
            if (string.IsNullOrWhiteSpace(PathBox.Text))
            {
                PathBox.Text = default(string);
                return true;
            }
            DirectoryInfo dir = new DirectoryInfo(PathBox.Text);
            try
            {
                dir.GetDirectories();
            }
            catch
            {
                return false;
            }
            if (dir.Exists)
            {
                DrivesList.SelectedItem = PathBox.Text.Substring(0, 3);
                directory = dir;
                PathBox.Text = directory.FullName.Substring(3);
                DisplayContent();
            }
            else
            {
                PathBox.Text = directory.FullName.Substring(3);
            }
            return true;
        }

        public void PathEntered()//смещение фокуса от контрола при вводе
        {
            FilesViewer.Focus();
        }

        public void PathStartChanging()//отображение текущего пути
        {
            PathBox.Text = directory.FullName;
        }

        public bool FileChose()//открытие папки или файла
        {
            if (FilesViewer.FocusedItem.SubItems[1].Text == "")
            {
                DirectoryInfo dir = new DirectoryInfo(directory.FullName + @"\" + FilesViewer.FocusedItem.Text);
                try
                {
                    dir.GetDirectories();
                }
                catch
                {
                    MessageBox.Show("Отказано в доступе!");
                    return false;
                }
                directory = dir;
                PathBox.Text = directory.FullName.Substring(3);
                DisplayContent();
            }
            else
            {
                Process.Start(directory.FullName + @"\" + FilesViewer.FocusedItem.Text);
            }
            return true;
        }

        public bool ItemsChose()//проверяет выбраны ли объекты в папке 
        {
            return FilesViewer.SelectedItems.Count > 0;
        }

        public Tuple<List<string>, List<string>> GetMovingFiles()//возвращает списки имен выбранных файлов и папок
        {
            List<string> movingDir = new List<string>();
            List<string> movingFile = new List<string>();
            for (int i = 0; i < FilesViewer.SelectedItems.Count; i++)
            {
                if (FilesViewer.SelectedItems[i].SubItems[1].Text == "")
                {
                    movingDir.Add(FilesViewer.SelectedItems[i].Text);
                }
                else
                {
                    movingFile.Add(FilesViewer.SelectedItems[i].Text);
                }
            }
            return new Tuple<List<string>, List<string>>(movingDir, movingFile);
        }

        public void DeleteFilesInDir(string dirName)//удаление файлов и папок в папке
        {
            for (int i = 0; i < FilesViewer.SelectedItems.Count; i++)
            {
                try
                {
                    FileInfo f = new FileInfo(dirName + FilesViewer.SelectedItems[i].Text);
                    f.Delete();
                }
                catch
                {
                    DirectoryInfo f = new DirectoryInfo(dirName + FilesViewer.SelectedItems[i].Text);
                    DeleteDir(f);
                }
            }
            DisplayContent();
        }

        private void DeleteDir(DirectoryInfo dir)//удаление файлов и папок в папке
        {
            foreach (var f in dir.GetFiles())
            {
                f.Delete();
            }
            foreach (var d in dir.GetDirectories())
            {
                DeleteDir(d);
            }
            dir.Delete();
        }

        public string SelectedItem()//возврат имени первого выбранного объекта
        {
            return FilesViewer.SelectedItems[0].Text;
        }
    }
}
