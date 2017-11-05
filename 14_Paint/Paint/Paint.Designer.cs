namespace Paint
{
    partial class Paint
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Paint));
			this.MainMenu = new System.Windows.Forms.MenuStrip();
			this.FileItem = new System.Windows.Forms.ToolStripMenuItem();
			this.NewItem = new System.Windows.Forms.ToolStripMenuItem();
			this.OpenItem = new System.Windows.Forms.ToolStripMenuItem();
			this.SaveItem = new System.Windows.Forms.ToolStripMenuItem();
			this.SaveAsItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
			this.Tools = new System.Windows.Forms.ToolStripMenuItem();
			this.ClearItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
			this.WindowsItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolBar = new System.Windows.Forms.ToolStrip();
			this.Pencil = new System.Windows.Forms.ToolStripButton();
			this.Eraser = new System.Windows.Forms.ToolStripButton();
			this.RectangleTool = new System.Windows.Forms.ToolStripButton();
			this.EllepseTool = new System.Windows.Forms.ToolStripButton();
			this.colorDialog = new System.Windows.Forms.ColorDialog();
			this.MainMenu.SuspendLayout();
			this.toolBar.SuspendLayout();
			this.SuspendLayout();
			// 
			// MainMenu
			// 
			this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileItem,
            this.Tools,
            this.WindowsItem});
			this.MainMenu.Location = new System.Drawing.Point(0, 0);
			this.MainMenu.Name = "MainMenu";
			this.MainMenu.Size = new System.Drawing.Size(834, 24);
			this.MainMenu.TabIndex = 1;
			this.MainMenu.Text = "MainMenu";
			// 
			// FileItem
			// 
			this.FileItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewItem,
            this.OpenItem,
            this.SaveItem,
            this.SaveAsItem,
            this.toolStripMenuItem1,
            this.toolStripMenuItem2});
			this.FileItem.Name = "FileItem";
			this.FileItem.Size = new System.Drawing.Size(48, 20);
			this.FileItem.Text = "&Файл";
			// 
			// NewItem
			// 
			this.NewItem.Name = "NewItem";
			this.NewItem.Size = new System.Drawing.Size(153, 22);
			this.NewItem.Text = "&Новый";
			this.NewItem.Click += new System.EventHandler(this.NewItem_Click);
			// 
			// OpenItem
			// 
			this.OpenItem.Name = "OpenItem";
			this.OpenItem.Size = new System.Drawing.Size(153, 22);
			this.OpenItem.Text = "&Открыть";
			this.OpenItem.Click += new System.EventHandler(this.OpenItem_Click);
			// 
			// SaveItem
			// 
			this.SaveItem.Name = "SaveItem";
			this.SaveItem.Size = new System.Drawing.Size(153, 22);
			this.SaveItem.Text = "&Сохранить";
			this.SaveItem.Click += new System.EventHandler(this.SaveItem_Click);
			// 
			// SaveAsItem
			// 
			this.SaveAsItem.Name = "SaveAsItem";
			this.SaveAsItem.Size = new System.Drawing.Size(153, 22);
			this.SaveAsItem.Text = "Сохранить &как";
			this.SaveAsItem.Click += new System.EventHandler(this.SaveAsItem_Click);
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(150, 6);
			// 
			// toolStripMenuItem2
			// 
			this.toolStripMenuItem2.Name = "toolStripMenuItem2";
			this.toolStripMenuItem2.Size = new System.Drawing.Size(150, 6);
			// 
			// Tools
			// 
			this.Tools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ClearItem,
            this.toolStripMenuItem3});
			this.Tools.Name = "Tools";
			this.Tools.Size = new System.Drawing.Size(71, 20);
			this.Tools.Text = "&Очистить";
			// 
			// ClearItem
			// 
			this.ClearItem.Name = "ClearItem";
			this.ClearItem.Size = new System.Drawing.Size(242, 22);
			this.ClearItem.Text = "&Очистить по нажатию на поле";
			this.ClearItem.Click += new System.EventHandler(this.ClearItem_Click);
			// 
			// toolStripMenuItem3
			// 
			this.toolStripMenuItem3.Name = "toolStripMenuItem3";
			this.toolStripMenuItem3.Size = new System.Drawing.Size(239, 6);
			// 
			// WindowsItem
			// 
			this.WindowsItem.Name = "WindowsItem";
			this.WindowsItem.Size = new System.Drawing.Size(48, 20);
			this.WindowsItem.Text = "&Окно";
			// 
			// toolBar
			// 
			this.toolBar.Dock = System.Windows.Forms.DockStyle.Left;
			this.toolBar.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.toolBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Pencil,
            this.Eraser,
            this.RectangleTool,
            this.EllepseTool});
			this.toolBar.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
			this.toolBar.Location = new System.Drawing.Point(0, 24);
			this.toolBar.MaximumSize = new System.Drawing.Size(60, 565);
			this.toolBar.MinimumSize = new System.Drawing.Size(60, 565);
			this.toolBar.Name = "toolBar";
			this.toolBar.Size = new System.Drawing.Size(60, 565);
			this.toolBar.TabIndex = 4;
			this.toolBar.Text = "toolBar";
			// 
			// Pencil
			// 
			this.Pencil.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.Pencil.Image = ((System.Drawing.Image)(resources.GetObject("Pencil.Image")));
			this.Pencil.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.Pencil.Name = "Pencil";
			this.Pencil.Size = new System.Drawing.Size(24, 24);
			this.Pencil.ToolTipText = "Карандаш";
			this.Pencil.Click += new System.EventHandler(this.Pencil_Click);
			// 
			// Eraser
			// 
			this.Eraser.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.Eraser.Image = ((System.Drawing.Image)(resources.GetObject("Eraser.Image")));
			this.Eraser.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.Eraser.Name = "Eraser";
			this.Eraser.Size = new System.Drawing.Size(24, 24);
			this.Eraser.ToolTipText = "Ластик";
			this.Eraser.Click += new System.EventHandler(this.Eraser_Click);
			// 
			// RectangleTool
			// 
			this.RectangleTool.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.RectangleTool.Image = ((System.Drawing.Image)(resources.GetObject("RectangleTool.Image")));
			this.RectangleTool.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.RectangleTool.Name = "RectangleTool";
			this.RectangleTool.Size = new System.Drawing.Size(24, 24);
			this.RectangleTool.ToolTipText = "Прямоугольник";
			this.RectangleTool.Click += new System.EventHandler(this.RectangleTool_Click);
			// 
			// EllepseTool
			// 
			this.EllepseTool.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.EllepseTool.Image = ((System.Drawing.Image)(resources.GetObject("EllepseTool.Image")));
			this.EllepseTool.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.EllepseTool.Name = "EllepseTool";
			this.EllepseTool.Size = new System.Drawing.Size(24, 24);
			this.EllepseTool.ToolTipText = "Эллипс";
			this.EllepseTool.Click += new System.EventHandler(this.EllepseTool_Click);
			// 
			// Paint
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(834, 581);
			this.Controls.Add(this.toolBar);
			this.Controls.Add(this.MainMenu);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.IsMdiContainer = true;
			this.MainMenuStrip = this.MainMenu;
			this.MaximumSize = new System.Drawing.Size(850, 620);
			this.MinimumSize = new System.Drawing.Size(850, 620);
			this.Name = "Paint";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Drawing";
			this.Load += new System.EventHandler(this.Paint_Load);
			this.MainMenu.ResumeLayout(false);
			this.MainMenu.PerformLayout();
			this.toolBar.ResumeLayout(false);
			this.toolBar.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem FileItem;
        private System.Windows.Forms.ToolStripMenuItem NewItem;
        private System.Windows.Forms.ToolStripMenuItem OpenItem;
        private System.Windows.Forms.ToolStripMenuItem SaveItem;
        private System.Windows.Forms.ToolStripMenuItem SaveAsItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem Tools;
        private System.Windows.Forms.ToolStripMenuItem WindowsItem;
        private System.Windows.Forms.ToolStripMenuItem ClearItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStrip toolBar;
        private System.Windows.Forms.ToolStripButton Pencil;
        private System.Windows.Forms.ToolStripButton Eraser;
        private System.Windows.Forms.ToolStripButton RectangleTool;
        private System.Windows.Forms.ToolStripButton EllepseTool;
        private System.Windows.Forms.ColorDialog colorDialog;
    }
}

