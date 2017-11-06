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

namespace Paint
{
    public partial class Paint : Form
    {
       private Draw_form m_bitmap;
       private PictureBox m_pictureboxup;
       private PictureBox m_pictureboxdown;
       private ComboBox m_ComboBox = new ComboBox();
       private StringDictionary m_filenames; 
       private String Filter = @"All files (*.*)|*.*| File jpg (*.kpg)|*.kpg| File bmp (*.bmp)|*.bmp| File png (*.png)|*.png";
       private ToolsClass tool;
       private object[] arraylines;
       private Timer m_timer;
       private Button chsizebt;
        public Paint()
        {
            InitializeComponent();
        }
 
        private void Paint_Load(object sender, EventArgs e)
        {

            m_filenames = new StringDictionary();
            arraylines = new object[]{0, 1, 2, 3, 4};

            m_pictureboxup = new PictureBox();
            m_pictureboxup.Size = new System.Drawing.Size(20, 20);
            m_pictureboxup.Click += OnClickPictureBoxUp;

            m_pictureboxdown = new PictureBox();
            m_pictureboxdown.Click += OnClickPictureBoxDown;
            m_pictureboxdown.Size = new System.Drawing.Size(20, 20);
            
            m_ComboBox.Size = new System.Drawing.Size(55, 25);
            m_ComboBox.DrawMode = DrawMode.OwnerDrawFixed;
            m_ComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            m_ComboBox.FormattingEnabled = true;
            m_ComboBox.DrawItem += OnDrawItem;
            m_ComboBox.SelectedIndexChanged += OnSelectChange;
            m_ComboBox.Items.AddRange(arraylines);
            m_ComboBox.SelectedIndex = 0;
           
            NumericUpDown m_numeric = new NumericUpDown();
            m_numeric.ValueChanged += OnValueChanged;
            m_numeric.Minimum = 1;
            ToolStripControlHost m_toolhost = new ToolStripControlHost(m_numeric);
            toolBar.Items.Add(m_toolhost);
            toolBar.Items[4].Name = "Numeric";
            toolBar.Items[4].Margin = new Padding(1, 10, 1, 0);
            toolBar.Items[4].AutoSize = false;
            toolBar.Items[4].Size = new Size(55, 21);
            m_bitmap = new Draw_form();
            m_bitmap.MdiParent = this;
            m_bitmap.Show();
            m_bitmap.Name = "1New";
            m_bitmap.Location = new Point(toolBar.Width, 0);
            WindowsItem.DropDownItems.Add("1 Новый").Name = "1New";
            (WindowsItem.DropDownItems[0] as ToolStripMenuItem).Checked = true;
            m_filenames.Add(m_bitmap.Name, "New");
            WindowsItem.DropDownItemClicked += WinDropDownItemClick;
            
            var imageup = new Bitmap(m_pictureboxup.Width, m_pictureboxup.Height);
            var imagedown = new Bitmap(m_pictureboxdown.Width, m_pictureboxdown.Height);
            m_pictureboxup.Image = imageup;
            m_pictureboxdown.Image = imagedown;
            using(var graphics = Graphics.FromImage(imageup)){
                graphics.Clear(Color.Black);
            }
            using (var graphics = Graphics.FromImage(imagedown))
            {
                graphics.Clear(Color.White);
            }
            ToolsClass.MainPict = Color.Black;
            ToolsClass.AnotherPict = Color.White;
            ToolStripControlHost pictureup = new ToolStripControlHost(m_pictureboxup);
            toolBar.Items.Add(pictureup);
            toolBar.Items[5].Margin = new Padding(15, 10, 0, 0);
            toolBar.Items[5].Name = "Pictureup";
       
            chsizebt = new Button();
            chsizebt.Size = new System.Drawing.Size(55, 21);
            chsizebt.Text = "Размер";
            chsizebt.Click += OnClickButtonChangeSize;
            ToolStripControlHost butsize = new ToolStripControlHost(chsizebt);
            toolBar.Items.Add(butsize);
            toolBar.Items[6].Margin = new System.Windows.Forms.Padding(10, 5, 1, 0);
			
            tool = new Brush(m_bitmap.Controls[0] as PictureBox);
            m_bitmap.tool = tool;
            m_timer = new Timer();
            m_timer.Interval = 1000;
            m_timer.Tick += OnTimer;

            LayoutMdi(MdiLayout.Cascade);
           }
       
        private void ExitItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        protected void OnDrawItem(object sender, DrawItemEventArgs e)
        {

            e.DrawBackground();
            
            using (var pen = new Pen(e.ForeColor, 2.0f))
            {

                pen.DashStyle = (DashStyle) e.Index;
                int y = (e.Bounds.Top + e.Bounds.Bottom) / 2;
                e.Graphics.DrawLine(pen, e.Bounds.Left, y, e.Bounds.Right, y);
            }
            
            e.DrawFocusRectangle();
        }

        protected void OnSelectChange(object sender, EventArgs e) {

            var item = (sender as ComboBox).SelectedItem;
            ToolsClass.SelectedItem = item;
            
        }
        protected void OnValueChanged(object sender, EventArgs e) {
            var item = (sender as NumericUpDown).Value;
            ToolsClass.SelectedValue = (int)item;
           
        }
        protected void WinDropDownItemClick(object sender, ToolStripItemClickedEventArgs e) {

            var item = (e.ClickedItem as ToolStripMenuItem).Checked;
            for (int i = 0; i < WindowsItem.DropDownItems.Count; i++)
            {
                (WindowsItem.DropDownItems[i] as ToolStripMenuItem).Checked = false;
            }
            if (item != true)
                (e.ClickedItem as ToolStripMenuItem).Checked = true;

            for (int j = 0; j < MdiChildren.Length; j++) {

                if (MdiChildren[j].Name == e.ClickedItem.Name)
                    MdiChildren[j].Activate();
            }
            
           }
         
        private void NewItem_Click(object sender, EventArgs e)
        {
            Draw_form forma = new Draw_form();
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
         }

        private void CloseItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < WindowsItem.DropDownItems.Count; i++) { 
              
                  if(WindowsItem.DropDownItems[i].Name == ActiveMdiChild.Name)
                      WindowsItem.DropDownItems[i].Dispose();
            }
            if (m_filenames.ContainsKey(ActiveMdiChild.Name))
                m_filenames.Remove(ActiveMdiChild.Name);
                ActiveMdiChild.Close();
        }

        private void OpenItem_Click(object sender, EventArgs e)
        {
            var m_OpenFileDialog = new OpenFileDialog();

            m_OpenFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            m_OpenFileDialog.Filter = Filter;

            if (m_OpenFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK) {

                var filename = m_OpenFileDialog.FileName;
                var bitmap = new Bitmap(filename);
                
                if ((ActiveMdiChild as Draw_form).m_Image != null)
                {
                    (ActiveMdiChild as Draw_form).m_Image.Dispose();
                }

                (ActiveMdiChild as Draw_form).m_Image = bitmap;
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

                    if ((ActiveMdiChild as Draw_form).m_Image != null)
                    {
                        (ActiveMdiChild as Draw_form).m_Image.Save(filename); 
                    }

                    m_filenames[ActiveMdiChild.Name] = filename;
            }
            else {

                (ActiveMdiChild as Draw_form).m_Image.Save(m_filenames[ActiveMdiChild.Name]);
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

                    if ((ActiveMdiChild as Draw_form).m_Image != null)
                    {
                        (ActiveMdiChild as Draw_form).m_Image.Save(filename);
                    }

                    m_filenames[ActiveMdiChild.Name] = filename;
                }
        }

        private void ClearItem_Click(object sender, EventArgs e)
        {
            
            
                tool = new Clear((ActiveMdiChild as Draw_form).Controls[0] as PictureBox);
                (ActiveMdiChild as Draw_form).tool = tool;
            
          
        }

    

        private void Pencil_Click(object sender, EventArgs e)
        {
           
                tool = new Brush((ActiveMdiChild as Draw_form).Controls[0] as PictureBox);
                (ActiveMdiChild as Draw_form).tool = tool;
           
        }

    

        private void Eraser_Click(object sender, EventArgs e)
        {
            
                tool = new Eraser((ActiveMdiChild as Draw_form).Controls[0] as PictureBox);
                (ActiveMdiChild as Draw_form).tool = tool;
           
        }
  
        private void RectangleTool_Click(object sender, EventArgs e)
        {
            
                tool = new Rectangle((ActiveMdiChild as Draw_form).Controls[0] as PictureBox);
                (ActiveMdiChild as Draw_form).tool = tool;
          
        }

        private void EllepseTool_Click(object sender, EventArgs e)
        {
            
                tool = new Ellipse((ActiveMdiChild as Draw_form).Controls[0] as PictureBox);
                (ActiveMdiChild as Draw_form).tool = tool;
          
        }

  
        private void OnTimer(Object sender, EventArgs e)
        {

            if (ToolsClass.mouseDown == System.Windows.Forms.MouseButtons.Left)
            {
                using (var graphics = Graphics.FromImage(m_pictureboxup.Image))
                {

                    graphics.Clear(ToolsClass.mainColor);
                    m_pictureboxup.Invalidate();
                    ToolsClass.MainPict = ToolsClass.mainColor;
                }
            }
            else if (ToolsClass.mouseDown == System.Windows.Forms.MouseButtons.Right)
            {
                using (var graphics = Graphics.FromImage(m_pictureboxdown.Image))
                {
                    graphics.Clear(ToolsClass.backColor);
                    m_pictureboxdown.Invalidate();
                    ToolsClass.AnotherPict = ToolsClass.backColor;
                }
            }
        }
		private void OnClickPictureBoxUp(Object sender, EventArgs e) {

            if (colorDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                using (var graphics = Graphics.FromImage(m_pictureboxup.Image))
                {

                    graphics.Clear(colorDialog.Color);
                    m_pictureboxup.Invalidate();
                    ToolsClass.MainPict = colorDialog.Color;
                    ToolsClass.mainColor = colorDialog.Color;

                }
        }
        private void OnClickPictureBoxDown(Object sender, EventArgs e) {

            if (colorDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                using (var graphics = Graphics.FromImage(m_pictureboxdown.Image))
                {

                    graphics.Clear(colorDialog.Color);
                    m_pictureboxdown.Invalidate();
                    ToolsClass.AnotherPict = colorDialog.Color;
                    ToolsClass.backColor = colorDialog.Color;

                }

        }
        private void OnClickButtonChangeSize(Object sender, EventArgs e) {
            Change_size_form m_forma = new Change_size_form(ActiveMdiChild.Size.Width, ActiveMdiChild.Size.Height);
             if(m_forma.ShowDialog() == System.Windows.Forms.DialogResult.OK){

                 ActiveMdiChild.Size = new Size(m_forma.SizeWidth, m_forma.SizeHeight);
                 (ActiveMdiChild.Controls[0] as PictureBox).Size = new Size(m_forma.SizeWidth, m_forma.SizeHeight);
                 Bitmap image = new Bitmap(m_forma.SizeWidth, m_forma.SizeHeight);
                 using (var graphics = Graphics.FromImage(image))
                 {
                     graphics.Clear(Color.White);
                     graphics.DrawImage((ActiveMdiChild.Controls[0] as PictureBox).Image, new System.Drawing.Rectangle(new Point(0, 0), new Size((ActiveMdiChild.Controls[0] as PictureBox).Image.Width, (ActiveMdiChild.Controls[0] as PictureBox).Image.Height)));
                 }
                 (ActiveMdiChild.Controls[0] as PictureBox).Image = image;
             }
        }

        private void Fill_Click(object sender, EventArgs e)
        {
            
                tool = new Eraser((ActiveMdiChild as Draw_form).Controls[0] as PictureBox);
                (ActiveMdiChild as Draw_form).tool = tool;
            
          
        }
     
    }
}
