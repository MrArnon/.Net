namespace Explorer
{
    partial class MainForm
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
			this.components = new System.ComponentModel.Container();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.Rename1 = new System.Windows.Forms.ToolStripMenuItem();
			this.Move1 = new System.Windows.Forms.ToolStripMenuItem();
			this.Copy1 = new System.Windows.Forms.ToolStripMenuItem();
			this.Delete1 = new System.Windows.Forms.ToolStripMenuItem();
			this.Insert1 = new System.Windows.Forms.ToolStripMenuItem();
			this.DrivesList1 = new System.Windows.Forms.ComboBox();
			this.PathBox1 = new System.Windows.Forms.TextBox();
			this.FilesViewer1 = new System.Windows.Forms.ListView();
			this.columnName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			this.fontDialog1 = new System.Windows.Forms.FontDialog();
			this.colorDialog1 = new System.Windows.Forms.ColorDialog();
			this.DrivesList2 = new System.Windows.Forms.ComboBox();
			this.PathBox2 = new System.Windows.Forms.TextBox();
			this.FilesViewer2 = new System.Windows.Forms.ListView();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.Rename2 = new System.Windows.Forms.ToolStripMenuItem();
			this.Move2 = new System.Windows.Forms.ToolStripMenuItem();
			this.Copy2 = new System.Windows.Forms.ToolStripMenuItem();
			this.Delete2 = new System.Windows.Forms.ToolStripMenuItem();
			this.Insert2 = new System.Windows.Forms.ToolStripMenuItem();
			this.imageList2 = new System.Windows.Forms.ImageList(this.components);
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.менюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.выбратьШрифтИЦветToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.информацияОСборкеToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
			this.переименоватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.contextMenuStrip1.SuspendLayout();
			this.contextMenuStrip2.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Rename1,
            this.Move1,
            this.Copy1,
            this.Delete1,
            this.Insert1});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(162, 114);
			this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
			// 
			// Rename1
			// 
			this.Rename1.Name = "Rename1";
			this.Rename1.Size = new System.Drawing.Size(161, 22);
			this.Rename1.Text = "Переименовать";
			this.Rename1.Click += new System.EventHandler(this.Rename_Click);
			// 
			// Move1
			// 
			this.Move1.Name = "Move1";
			this.Move1.Size = new System.Drawing.Size(161, 22);
			this.Move1.Text = "Переместить";
			this.Move1.Click += new System.EventHandler(this.Move_Click);
			// 
			// Copy1
			// 
			this.Copy1.Name = "Copy1";
			this.Copy1.Size = new System.Drawing.Size(161, 22);
			this.Copy1.Text = "Копировать";
			this.Copy1.Click += new System.EventHandler(this.Copy_Click);
			// 
			// Delete1
			// 
			this.Delete1.Name = "Delete1";
			this.Delete1.Size = new System.Drawing.Size(161, 22);
			this.Delete1.Text = "Удалить";
			this.Delete1.Click += new System.EventHandler(this.Delete_Click);
			// 
			// Insert1
			// 
			this.Insert1.Enabled = false;
			this.Insert1.Name = "Insert1";
			this.Insert1.Size = new System.Drawing.Size(161, 22);
			this.Insert1.Text = "Вставить";
			this.Insert1.Click += new System.EventHandler(this.Insert_Click);
			// 
			// DrivesList1
			// 
			this.DrivesList1.FormattingEnabled = true;
			this.DrivesList1.Location = new System.Drawing.Point(0, 29);
			this.DrivesList1.Name = "DrivesList1";
			this.DrivesList1.Size = new System.Drawing.Size(55, 21);
			this.DrivesList1.TabIndex = 4;
			this.DrivesList1.TabStop = false;
			this.DrivesList1.SelectedIndexChanged += new System.EventHandler(this.DrivesList1_SelectedIndexChanged);
			// 
			// PathBox1
			// 
			this.PathBox1.Location = new System.Drawing.Point(55, 29);
			this.PathBox1.Name = "PathBox1";
			this.PathBox1.Size = new System.Drawing.Size(354, 20);
			this.PathBox1.TabIndex = 5;
			this.PathBox1.TabStop = false;
			this.PathBox1.Enter += new System.EventHandler(this.PathBox1_Enter);
			this.PathBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PathBox1_KeyPress);
			this.PathBox1.Leave += new System.EventHandler(this.PathBox1_Leave);
			// 
			// FilesViewer1
			// 
			this.FilesViewer1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnName,
            this.columnSize});
			this.FilesViewer1.ContextMenuStrip = this.contextMenuStrip1;
			this.FilesViewer1.ForeColor = System.Drawing.SystemColors.WindowText;
			this.FilesViewer1.LargeImageList = this.imageList1;
			this.FilesViewer1.Location = new System.Drawing.Point(0, 55);
			this.FilesViewer1.Name = "FilesViewer1";
			this.FilesViewer1.Size = new System.Drawing.Size(409, 505);
			this.FilesViewer1.SmallImageList = this.imageList1;
			this.FilesViewer1.TabIndex = 6;
			this.FilesViewer1.UseCompatibleStateImageBehavior = false;
			this.FilesViewer1.View = System.Windows.Forms.View.Details;
			this.FilesViewer1.DoubleClick += new System.EventHandler(this.FilesViewer1_DoubleClick);
			// 
			// columnName
			// 
			this.columnName.Text = "Имя";
			this.columnName.Width = 200;
			// 
			// columnSize
			// 
			this.columnSize.Text = "Размер";
			this.columnSize.Width = 200;
			// 
			// imageList1
			// 
			this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
			this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
			this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// DrivesList2
			// 
			this.DrivesList2.FormattingEnabled = true;
			this.DrivesList2.Location = new System.Drawing.Point(409, 29);
			this.DrivesList2.Name = "DrivesList2";
			this.DrivesList2.Size = new System.Drawing.Size(55, 21);
			this.DrivesList2.TabIndex = 10;
			this.DrivesList2.TabStop = false;
			this.DrivesList2.SelectedIndexChanged += new System.EventHandler(this.DrivesList1_SelectedIndexChanged);
			// 
			// PathBox2
			// 
			this.PathBox2.Location = new System.Drawing.Point(464, 29);
			this.PathBox2.Name = "PathBox2";
			this.PathBox2.Size = new System.Drawing.Size(354, 20);
			this.PathBox2.TabIndex = 11;
			this.PathBox2.TabStop = false;
			this.PathBox2.Enter += new System.EventHandler(this.PathBox1_Enter);
			this.PathBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PathBox1_KeyPress);
			this.PathBox2.Leave += new System.EventHandler(this.PathBox1_Leave);
			// 
			// FilesViewer2
			// 
			this.FilesViewer2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
			this.FilesViewer2.ContextMenuStrip = this.contextMenuStrip2;
			this.FilesViewer2.ForeColor = System.Drawing.SystemColors.WindowText;
			this.FilesViewer2.LargeImageList = this.imageList1;
			this.FilesViewer2.Location = new System.Drawing.Point(409, 54);
			this.FilesViewer2.Name = "FilesViewer2";
			this.FilesViewer2.Size = new System.Drawing.Size(409, 506);
			this.FilesViewer2.SmallImageList = this.imageList1;
			this.FilesViewer2.TabIndex = 12;
			this.FilesViewer2.UseCompatibleStateImageBehavior = false;
			this.FilesViewer2.View = System.Windows.Forms.View.Details;
			this.FilesViewer2.DoubleClick += new System.EventHandler(this.FilesViewer1_DoubleClick);
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Имя";
			this.columnHeader1.Width = 200;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Размер";
			this.columnHeader2.Width = 200;
			// 
			// contextMenuStrip2
			// 
			this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Rename2,
            this.Move2,
            this.Copy2,
            this.Delete2,
            this.Insert2});
			this.contextMenuStrip2.Name = "contextMenuStrip1";
			this.contextMenuStrip2.Size = new System.Drawing.Size(162, 114);
			this.contextMenuStrip2.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
			this.contextMenuStrip2.Click += new System.EventHandler(this.Copy_Click);
			// 
			// Rename2
			// 
			this.Rename2.Name = "Rename2";
			this.Rename2.Size = new System.Drawing.Size(161, 22);
			this.Rename2.Text = "Переименовать";
			this.Rename2.Click += new System.EventHandler(this.Rename_Click);
			// 
			// Move2
			// 
			this.Move2.Name = "Move2";
			this.Move2.Size = new System.Drawing.Size(161, 22);
			this.Move2.Text = "Переместить";
			this.Move2.Click += new System.EventHandler(this.Move_Click);
			// 
			// Copy2
			// 
			this.Copy2.Name = "Copy2";
			this.Copy2.Size = new System.Drawing.Size(161, 22);
			this.Copy2.Text = "Копировать";
			this.Copy2.Click += new System.EventHandler(this.Copy_Click);
			// 
			// Delete2
			// 
			this.Delete2.Name = "Delete2";
			this.Delete2.Size = new System.Drawing.Size(161, 22);
			this.Delete2.Text = "Удалить";
			this.Delete2.Click += new System.EventHandler(this.Delete_Click);
			// 
			// Insert2
			// 
			this.Insert2.Enabled = false;
			this.Insert2.Name = "Insert2";
			this.Insert2.Size = new System.Drawing.Size(161, 22);
			this.Insert2.Text = "Вставить";
			this.Insert2.Click += new System.EventHandler(this.Insert_Click);
			// 
			// imageList2
			// 
			this.imageList2.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
			this.imageList2.ImageSize = new System.Drawing.Size(16, 16);
			this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.менюToolStripMenuItem,
            this.toolStripTextBox1,
            this.переименоватьToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(818, 27);
			this.menuStrip1.TabIndex = 13;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// менюToolStripMenuItem
			// 
			this.менюToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выбратьШрифтИЦветToolStripMenuItem,
            this.информацияОСборкеToolStripMenuItem1});
			this.менюToolStripMenuItem.Name = "менюToolStripMenuItem";
			this.менюToolStripMenuItem.Size = new System.Drawing.Size(53, 23);
			this.менюToolStripMenuItem.Text = "Меню";
			// 
			// выбратьШрифтИЦветToolStripMenuItem
			// 
			this.выбратьШрифтИЦветToolStripMenuItem.Name = "выбратьШрифтИЦветToolStripMenuItem";
			this.выбратьШрифтИЦветToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
			this.выбратьШрифтИЦветToolStripMenuItem.Text = "Выбрать шрифт и цвет";
			this.выбратьШрифтИЦветToolStripMenuItem.Click += new System.EventHandler(this.выбратьШрифтИЦветToolStripMenuItem_Click);
			// 
			// информацияОСборкеToolStripMenuItem1
			// 
			this.информацияОСборкеToolStripMenuItem1.Name = "информацияОСборкеToolStripMenuItem1";
			this.информацияОСборкеToolStripMenuItem1.Size = new System.Drawing.Size(200, 22);
			this.информацияОСборкеToolStripMenuItem1.Text = "Информация о сборке";
			this.информацияОСборкеToolStripMenuItem1.Click += new System.EventHandler(this.информацияОСборкеToolStripMenuItem1_Click);
			// 
			// toolStripTextBox1
			// 
			this.toolStripTextBox1.Name = "toolStripTextBox1";
			this.toolStripTextBox1.Size = new System.Drawing.Size(120, 23);
			// 
			// переименоватьToolStripMenuItem
			// 
			this.переименоватьToolStripMenuItem.Enabled = false;
			this.переименоватьToolStripMenuItem.Name = "переименоватьToolStripMenuItem";
			this.переименоватьToolStripMenuItem.Size = new System.Drawing.Size(106, 23);
			this.переименоватьToolStripMenuItem.Text = "Переименовать";
			this.переименоватьToolStripMenuItem.Click += new System.EventHandler(this.переименоватьToolStripMenuItem_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(818, 561);
			this.Controls.Add(this.menuStrip1);
			this.Controls.Add(this.FilesViewer2);
			this.Controls.Add(this.PathBox2);
			this.Controls.Add(this.DrivesList2);
			this.Controls.Add(this.FilesViewer1);
			this.Controls.Add(this.PathBox1);
			this.Controls.Add(this.DrivesList1);
			this.MainMenuStrip = this.menuStrip1;
			this.MaximumSize = new System.Drawing.Size(834, 600);
			this.MinimumSize = new System.Drawing.Size(834, 600);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Explorer";
			this.contextMenuStrip1.ResumeLayout(false);
			this.contextMenuStrip2.ResumeLayout(false);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Rename1;
        private System.Windows.Forms.ToolStripMenuItem Move1;
        private System.Windows.Forms.ToolStripMenuItem Copy1;
        private System.Windows.Forms.ComboBox DrivesList1;
        private System.Windows.Forms.TextBox PathBox1;
        private System.Windows.Forms.ListView FilesViewer1;
        private System.Windows.Forms.ColumnHeader columnName;
        private System.Windows.Forms.ColumnHeader columnSize;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ToolStripMenuItem Delete1;
        private System.Windows.Forms.ToolStripMenuItem Insert1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ComboBox DrivesList2;
        private System.Windows.Forms.TextBox PathBox2;
        private System.Windows.Forms.ListView FilesViewer2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem Rename2;
        private System.Windows.Forms.ToolStripMenuItem Move2;
        private System.Windows.Forms.ToolStripMenuItem Copy2;
        private System.Windows.Forms.ToolStripMenuItem Delete2;
        private System.Windows.Forms.ToolStripMenuItem Insert2;
        private System.Windows.Forms.ImageList imageList2;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem менюToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem выбратьШрифтИЦветToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem информацияОСборкеToolStripMenuItem1;
		private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
		private System.Windows.Forms.ToolStripMenuItem переименоватьToolStripMenuItem;
	}
}

