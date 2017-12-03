namespace Paint
{
	partial class Drawing
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Drawing));
			this.Menu = new System.Windows.Forms.MenuStrip();
			this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.OpenButton = new System.Windows.Forms.ToolStripMenuItem();
			this.SaveButton = new System.Windows.Forms.ToolStripMenuItem();
			this.SaveAsButton = new System.Windows.Forms.ToolStripMenuItem();
			this.SaveProjButton = new System.Windows.Forms.ToolStripMenuItem();
			this.OpenProjButton = new System.Windows.Forms.ToolStripMenuItem();
			this.программаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.NewFileButton = new System.Windows.Forms.ToolStripMenuItem();
			this.CloseFileButton = new System.Windows.Forms.ToolStripMenuItem();
			this.PictureBox = new System.Windows.Forms.PictureBox();
			this.LineWidth = new System.Windows.Forms.NumericUpDown();
			this.ProjectNumBox = new System.Windows.Forms.ComboBox();
			this.ChooseColorButton = new System.Windows.Forms.ToolStripButton();
			this.ChooseFigureButton = new System.Windows.Forms.ToolStripDropDownButton();
			this.SelectBrushButton = new System.Windows.Forms.ToolStripMenuItem();
			this.SelectEllipseButton = new System.Windows.Forms.ToolStripMenuItem();
			this.SelectRectangleButton = new System.Windows.Forms.ToolStripMenuItem();
			this.SelectEraserButton = new System.Windows.Forms.ToolStripMenuItem();
			this.RemoveChagesButton = new System.Windows.Forms.ToolStripButton();
			this.ReverseRemoveButton = new System.Windows.Forms.ToolStripButton();
			this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.Tools = new System.Windows.Forms.ToolStrip();
			this.Menu.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.LineWidth)).BeginInit();
			this.Tools.SuspendLayout();
			this.SuspendLayout();
			// 
			// Menu
			// 
			this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.программаToolStripMenuItem});
			this.Menu.Location = new System.Drawing.Point(0, 0);
			this.Menu.Name = "Menu";
			this.Menu.Size = new System.Drawing.Size(1074, 24);
			this.Menu.TabIndex = 0;
			this.Menu.Text = "Menu";
			// 
			// файлToolStripMenuItem
			// 
			this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenButton,
            this.SaveButton,
            this.SaveAsButton,
            this.SaveProjButton,
            this.OpenProjButton});
			this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
			this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
			this.файлToolStripMenuItem.Text = "Файл";
			// 
			// OpenButton
			// 
			this.OpenButton.Name = "OpenButton";
			this.OpenButton.Size = new System.Drawing.Size(173, 22);
			this.OpenButton.Text = "Открыть";
			this.OpenButton.Click += new System.EventHandler(this.OpenButton_Click);
			// 
			// SaveButton
			// 
			this.SaveButton.Enabled = false;
			this.SaveButton.Name = "SaveButton";
			this.SaveButton.Size = new System.Drawing.Size(173, 22);
			this.SaveButton.Text = "Сохранить";
			this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
			// 
			// SaveAsButton
			// 
			this.SaveAsButton.Enabled = false;
			this.SaveAsButton.Name = "SaveAsButton";
			this.SaveAsButton.Size = new System.Drawing.Size(173, 22);
			this.SaveAsButton.Text = "Сохранить как";
			this.SaveAsButton.Click += new System.EventHandler(this.SaveAsButton_Click);
			// 
			// SaveProjButton
			// 
			this.SaveProjButton.Enabled = false;
			this.SaveProjButton.Name = "SaveProjButton";
			this.SaveProjButton.Size = new System.Drawing.Size(173, 22);
			this.SaveProjButton.Text = "Сохранить проект";
			this.SaveProjButton.Click += new System.EventHandler(this.SaveProjButton_Click);
			// 
			// OpenProjButton
			// 
			this.OpenProjButton.Name = "OpenProjButton";
			this.OpenProjButton.Size = new System.Drawing.Size(173, 22);
			this.OpenProjButton.Text = "Открыть проект";
			this.OpenProjButton.Click += new System.EventHandler(this.OpenProjButton_Click);
			// 
			// программаToolStripMenuItem
			// 
			this.программаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewFileButton,
            this.CloseFileButton});
			this.программаToolStripMenuItem.Name = "программаToolStripMenuItem";
			this.программаToolStripMenuItem.Size = new System.Drawing.Size(110, 20);
			this.программаToolStripMenuItem.Text = "Окно рисования";
			// 
			// NewFileButton
			// 
			this.NewFileButton.Name = "NewFileButton";
			this.NewFileButton.Size = new System.Drawing.Size(152, 22);
			this.NewFileButton.Text = "Новое окно";
			this.NewFileButton.Click += new System.EventHandler(this.NewFileButton_Click);
			// 
			// CloseFileButton
			// 
			this.CloseFileButton.Name = "CloseFileButton";
			this.CloseFileButton.Size = new System.Drawing.Size(152, 22);
			this.CloseFileButton.Text = "Закрыть окно";
			this.CloseFileButton.Click += new System.EventHandler(this.CloseFileButton_Click);
			// 
			// PictureBox
			// 
			this.PictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PictureBox.BackgroundImage")));
			this.PictureBox.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox.Image")));
			this.PictureBox.Location = new System.Drawing.Point(0, 24);
			this.PictureBox.Name = "PictureBox";
			this.PictureBox.Size = new System.Drawing.Size(1003, 481);
			this.PictureBox.TabIndex = 1;
			this.PictureBox.TabStop = false;
			this.PictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PictureBox_MouseDown);
			this.PictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PictureBox_MouseMove);
			this.PictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PictureBox_MouseUp);
			// 
			// LineWidth
			// 
			this.LineWidth.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
			this.LineWidth.Location = new System.Drawing.Point(1020, 156);
			this.LineWidth.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
			this.LineWidth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.LineWidth.Name = "LineWidth";
			this.LineWidth.Size = new System.Drawing.Size(42, 20);
			this.LineWidth.TabIndex = 3;
			this.LineWidth.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
			this.LineWidth.ValueChanged += new System.EventHandler(this.LineWidth_ValueChanged);
			// 
			// ProjectNumBox
			// 
			this.ProjectNumBox.FormattingEnabled = true;
			this.ProjectNumBox.Items.AddRange(new object[] {
            "1"});
			this.ProjectNumBox.Location = new System.Drawing.Point(157, 3);
			this.ProjectNumBox.Name = "ProjectNumBox";
			this.ProjectNumBox.Size = new System.Drawing.Size(37, 21);
			this.ProjectNumBox.TabIndex = 4;
			this.ProjectNumBox.TabStop = false;
			this.ProjectNumBox.Text = "1";
			this.ProjectNumBox.SelectedIndexChanged += new System.EventHandler(this.ProjectNumBox_SelectedIndexChanged);
			// 
			// ChooseColorButton
			// 
			this.ChooseColorButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.ChooseColorButton.Image = ((System.Drawing.Image)(resources.GetObject("ChooseColorButton.Image")));
			this.ChooseColorButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.ChooseColorButton.Name = "ChooseColorButton";
			this.ChooseColorButton.Size = new System.Drawing.Size(65, 20);
			this.ChooseColorButton.Text = "Цвет";
			this.ChooseColorButton.Click += new System.EventHandler(this.ChooseColorButton_Click);
			// 
			// ChooseFigureButton
			// 
			this.ChooseFigureButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.ChooseFigureButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SelectBrushButton,
            this.SelectEllipseButton,
            this.SelectRectangleButton,
            this.SelectEraserButton});
			this.ChooseFigureButton.Image = ((System.Drawing.Image)(resources.GetObject("ChooseFigureButton.Image")));
			this.ChooseFigureButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.ChooseFigureButton.Name = "ChooseFigureButton";
			this.ChooseFigureButton.Size = new System.Drawing.Size(65, 20);
			this.ChooseFigureButton.Text = "Фигура";
			// 
			// SelectBrushButton
			// 
			this.SelectBrushButton.Image = ((System.Drawing.Image)(resources.GetObject("SelectBrushButton.Image")));
			this.SelectBrushButton.Name = "SelectBrushButton";
			this.SelectBrushButton.Size = new System.Drawing.Size(163, 22);
			this.SelectBrushButton.Text = "Кисть";
			this.SelectBrushButton.Click += new System.EventHandler(this.SelectBrushButton_Click);
			// 
			// SelectEllipseButton
			// 
			this.SelectEllipseButton.Image = ((System.Drawing.Image)(resources.GetObject("SelectEllipseButton.Image")));
			this.SelectEllipseButton.Name = "SelectEllipseButton";
			this.SelectEllipseButton.Size = new System.Drawing.Size(163, 22);
			this.SelectEllipseButton.Text = "Эллипс";
			this.SelectEllipseButton.Click += new System.EventHandler(this.SelectEllipseButton_Click);
			// 
			// SelectRectangleButton
			// 
			this.SelectRectangleButton.Image = ((System.Drawing.Image)(resources.GetObject("SelectRectangleButton.Image")));
			this.SelectRectangleButton.Name = "SelectRectangleButton";
			this.SelectRectangleButton.Size = new System.Drawing.Size(163, 22);
			this.SelectRectangleButton.Text = "Прямоугольник";
			this.SelectRectangleButton.Click += new System.EventHandler(this.SelectRectangleButton_Click);
			// 
			// SelectEraserButton
			// 
			this.SelectEraserButton.Image = ((System.Drawing.Image)(resources.GetObject("SelectEraserButton.Image")));
			this.SelectEraserButton.Name = "SelectEraserButton";
			this.SelectEraserButton.Size = new System.Drawing.Size(163, 22);
			this.SelectEraserButton.Text = "Ластик";
			this.SelectEraserButton.Click += new System.EventHandler(this.SelectEraserButton_Click);
			// 
			// RemoveChagesButton
			// 
			this.RemoveChagesButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.RemoveChagesButton.Enabled = false;
			this.RemoveChagesButton.Image = ((System.Drawing.Image)(resources.GetObject("RemoveChagesButton.Image")));
			this.RemoveChagesButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.RemoveChagesButton.Name = "RemoveChagesButton";
			this.RemoveChagesButton.Size = new System.Drawing.Size(65, 20);
			this.RemoveChagesButton.Text = "Отмена изменений";
			this.RemoveChagesButton.Click += new System.EventHandler(this.RemoveChagesButton_Click);
			// 
			// ReverseRemoveButton
			// 
			this.ReverseRemoveButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.ReverseRemoveButton.Enabled = false;
			this.ReverseRemoveButton.Image = ((System.Drawing.Image)(resources.GetObject("ReverseRemoveButton.Image")));
			this.ReverseRemoveButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.ReverseRemoveButton.Name = "ReverseRemoveButton";
			this.ReverseRemoveButton.Size = new System.Drawing.Size(65, 20);
			this.ReverseRemoveButton.Text = "Возврат изменений";
			this.ReverseRemoveButton.Click += new System.EventHandler(this.ReverseRemoveButton_Click);
			// 
			// toolStripLabel1
			// 
			this.toolStripLabel1.Name = "toolStripLabel1";
			this.toolStripLabel1.Size = new System.Drawing.Size(65, 15);
			this.toolStripLabel1.Text = "                    ";
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(65, 6);
			// 
			// Tools
			// 
			this.Tools.Dock = System.Windows.Forms.DockStyle.Right;
			this.Tools.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ChooseColorButton,
            this.ChooseFigureButton,
            this.RemoveChagesButton,
            this.ReverseRemoveButton,
            this.toolStripLabel1,
            this.toolStripSeparator1});
			this.Tools.Location = new System.Drawing.Point(1006, 24);
			this.Tools.Name = "Tools";
			this.Tools.Size = new System.Drawing.Size(68, 483);
			this.Tools.TabIndex = 2;
			this.Tools.Text = "toolStrip1";
			// 
			// Drawing
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1074, 507);
			this.Controls.Add(this.ProjectNumBox);
			this.Controls.Add(this.LineWidth);
			this.Controls.Add(this.Tools);
			this.Controls.Add(this.PictureBox);
			this.Controls.Add(this.Menu);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.Menu;
			this.MaximumSize = new System.Drawing.Size(1090, 546);
			this.MinimumSize = new System.Drawing.Size(1090, 546);
			this.Name = "Drawing";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Drawing";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PaintWindow_FormClosing);
			this.Menu.ResumeLayout(false);
			this.Menu.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.LineWidth)).EndInit();
			this.Tools.ResumeLayout(false);
			this.Tools.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip Menu;
		private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem OpenButton;
		private System.Windows.Forms.PictureBox PictureBox;
		private System.Windows.Forms.NumericUpDown LineWidth;
		private System.Windows.Forms.ToolStripMenuItem SaveButton;
		private System.Windows.Forms.ToolStripMenuItem SaveAsButton;
		private System.Windows.Forms.ComboBox ProjectNumBox;
		private System.Windows.Forms.ToolStripButton ChooseColorButton;
		private System.Windows.Forms.ToolStripDropDownButton ChooseFigureButton;
		private System.Windows.Forms.ToolStripMenuItem SelectBrushButton;
		private System.Windows.Forms.ToolStripMenuItem SelectEllipseButton;
		private System.Windows.Forms.ToolStripMenuItem SelectRectangleButton;
		private System.Windows.Forms.ToolStripMenuItem SelectEraserButton;
		private System.Windows.Forms.ToolStripButton RemoveChagesButton;
		private System.Windows.Forms.ToolStripButton ReverseRemoveButton;
		private System.Windows.Forms.ToolStripLabel toolStripLabel1;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStrip Tools;
		private System.Windows.Forms.ToolStripMenuItem программаToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem NewFileButton;
		private System.Windows.Forms.ToolStripMenuItem CloseFileButton;
		private System.Windows.Forms.ToolStripMenuItem SaveProjButton;
		private System.Windows.Forms.ToolStripMenuItem OpenProjButton;
	}
}

