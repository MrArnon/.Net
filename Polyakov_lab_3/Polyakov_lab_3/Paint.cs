using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Polyakov_lab_3
{
	public partial class Drawing : Form
	{
		private BitmapForma m_bitmap;
		private StringDictionary m_filenames;
		private String Filter = @"All files (*.*)|*.*| File kpg (*.kpg)|*.kpg| File bmp (*.bmp)|*.bmp| File png (*.png)|*.png";
		Draw draw = new Draw();
		public Drawing()
		{
			InitializeComponent();
			
		}
		
		

		private void But_Pen_Click(object sender, EventArgs e)
		{
			draw.g= Draw_panel.CreateGraphics();
			DialogResult D = ColorDialog.ShowDialog();
			if (D == System.Windows.Forms.DialogResult.OK)
				draw.CurrentColor = ColorDialog.Color;
			try
			{
				draw.Width = Convert.ToInt32(Width_Text.Text);
			}
		catch(FormatException) { MessageBox.Show("Ширина линии должна быть целым числом"); draw.Width = 2; Width_Text.Text = "2"; }
			}

		private void But_Clear_Click(object sender, EventArgs e)
		{
			Draw_panel.Refresh();
			Width_Text.Text = "2";
		}

		private void Draw_panel_MouseMove(object sender, MouseEventArgs e)
		{
			if (draw.isPressed)
			{
				draw.PrevPoint = draw.CurrentPoint;
				draw.CurrentPoint = e.Location;
				draw.paint_simple();
			}
		}

		private void Draw_panel_MouseDown(object sender, MouseEventArgs e)
		{
			draw.isPressed = true;
			draw.CurrentPoint = e.Location;
		}

		private void Draw_panel_MouseUp(object sender, MouseEventArgs e)
		{
			draw.isPressed = false;
		}

		/*private void NewItem_Click(object sender, EventArgs e)
		{
			BitmapForma forma = new BitmapForma();
			forma.MdiParent = this;
			forma.Show();
			forma.Name = MdiChildren.Length + "New";
			for (int i = 0; i < WindowsItem.DropDownItems.Count; i++)
			{
				(WindowsItem.DropDownItems[i] as ToolStripMenuItem).Checked = false;
			}

			WindowsItem.DropDownItems.Add(MdiChildren.Length + " Новый").Name = MdiChildren.Length + "New";
			(WindowsItem.DropDownItems[WindowsItem.DropDownItems.Count - 1] as ToolStripMenuItem).Checked = true;
			m_filenames.Add(forma.Name, "New");
			m_ComboBox.SelectedItem = 0;
		}*/

		private void OpenItem_Click(object sender, EventArgs e)
		{
			var m_OpenFileDialog = new OpenFileDialog();

			m_OpenFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
			m_OpenFileDialog.Filter = Filter;

			if (m_OpenFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
			{

				var filename = m_OpenFileDialog.FileName;
				var bitmap = new Bitmap(filename);

				if ((ActiveMdiChild as BitmapForma).m_Image != null)
				{
					(ActiveMdiChild as BitmapForma).m_Image.Dispose();
				}

				(ActiveMdiChild as BitmapForma).m_Image = bitmap;
				m_filenames[ActiveMdiChild.Name] = filename;

			}
		}

		private void SaveItem_Click(object sender, EventArgs e)
		{
			if (m_filenames[ActiveMdiChild.Name] == "New")
			{
				var m_SaveFileDialog = new SaveFileDialog();
				m_SaveFileDialog.Filter = @"*.bmp|*.bmp|*.kpg|*.kpg|*.png|*.png";
				m_SaveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
				if (m_SaveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
				{

					string filename = m_SaveFileDialog.FileName;

					if ((ActiveMdiChild as BitmapForma).m_Image != null)
					{
						(ActiveMdiChild as BitmapForma).m_Image.Save(filename);
					}

					m_filenames[ActiveMdiChild.Name] = filename;
				}
				else
				{

					(ActiveMdiChild as BitmapForma).m_Image.Save(m_filenames[ActiveMdiChild.Name]);
				}
			}
		}

		private void SaveAsItem_Click(object sender, EventArgs e)
		{
			var m_SaveFileDialog = new SaveFileDialog();
			m_SaveFileDialog.Filter = @"*.bmp|*.bmp|*.kpg|*.kpg|*.png|*.png";
			m_SaveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
			if (m_SaveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
			{

				string filename = m_SaveFileDialog.FileName;

				if ((ActiveMdiChild as BitmapForma).m_Image != null)
				{
					(ActiveMdiChild as BitmapForma).m_Image.Save(filename);
				}

				m_filenames[ActiveMdiChild.Name] = filename;
			}
		}
	}
}
