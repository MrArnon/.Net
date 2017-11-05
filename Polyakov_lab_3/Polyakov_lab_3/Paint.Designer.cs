namespace Polyakov_lab_3
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
			this.But_Clear = new System.Windows.Forms.Button();
			this.But_Pen = new System.Windows.Forms.Button();
			this.Draw_panel = new System.Windows.Forms.Panel();
			this.ColorDialog = new System.Windows.Forms.ColorDialog();
			this.Width_Text = new System.Windows.Forms.TextBox();
			this.Width_Label = new System.Windows.Forms.Label();
			this.MainMenu = new System.Windows.Forms.MenuStrip();
			this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.NewItem = new System.Windows.Forms.ToolStripMenuItem();
			this.OpenItem = new System.Windows.Forms.ToolStripMenuItem();
			this.SaveItem = new System.Windows.Forms.ToolStripMenuItem();
			this.SaveAsItem = new System.Windows.Forms.ToolStripMenuItem();
			this.MainMenu.SuspendLayout();
			this.SuspendLayout();
			// 
			// But_Clear
			// 
			this.But_Clear.Location = new System.Drawing.Point(1157, 487);
			this.But_Clear.Name = "But_Clear";
			this.But_Clear.Size = new System.Drawing.Size(89, 29);
			this.But_Clear.TabIndex = 1;
			this.But_Clear.Text = "Очистить";
			this.But_Clear.UseVisualStyleBackColor = true;
			this.But_Clear.Click += new System.EventHandler(this.But_Clear_Click);
			// 
			// But_Pen
			// 
			this.But_Pen.Location = new System.Drawing.Point(1157, 69);
			this.But_Pen.Name = "But_Pen";
			this.But_Pen.Size = new System.Drawing.Size(89, 29);
			this.But_Pen.TabIndex = 2;
			this.But_Pen.Text = "Кисть";
			this.But_Pen.UseVisualStyleBackColor = true;
			this.But_Pen.Click += new System.EventHandler(this.But_Pen_Click);
			// 
			// Draw_panel
			// 
			this.Draw_panel.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.Draw_panel.Location = new System.Drawing.Point(0, 24);
			this.Draw_panel.Name = "Draw_panel";
			this.Draw_panel.Size = new System.Drawing.Size(1119, 491);
			this.Draw_panel.TabIndex = 3;
			this.Draw_panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Draw_panel_MouseDown);
			this.Draw_panel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Draw_panel_MouseMove);
			this.Draw_panel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Draw_panel_MouseUp);
			// 
			// Width_Text
			// 
			this.Width_Text.Location = new System.Drawing.Point(1185, 40);
			this.Width_Text.Multiline = true;
			this.Width_Text.Name = "Width_Text";
			this.Width_Text.Size = new System.Drawing.Size(33, 23);
			this.Width_Text.TabIndex = 4;
			this.Width_Text.Text = "2";
			this.Width_Text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// Width_Label
			// 
			this.Width_Label.AutoSize = true;
			this.Width_Label.Location = new System.Drawing.Point(1140, 24);
			this.Width_Label.Name = "Width_Label";
			this.Width_Label.Size = new System.Drawing.Size(122, 13);
			this.Width_Label.TabIndex = 5;
			this.Width_Label.Text = "Введите ширину линий";
			// 
			// MainMenu
			// 
			this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
			this.MainMenu.Location = new System.Drawing.Point(0, 0);
			this.MainMenu.Name = "MainMenu";
			this.MainMenu.Size = new System.Drawing.Size(1285, 24);
			this.MainMenu.TabIndex = 6;
			this.MainMenu.Text = "MainMenu";
			// 
			// файлToolStripMenuItem
			// 
			this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewItem,
            this.OpenItem,
            this.SaveItem,
            this.SaveAsItem});
			this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
			this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
			this.файлToolStripMenuItem.Text = "Файл";
			// 
			// NewItem
			// 
			this.NewItem.Name = "NewItem";
			this.NewItem.Size = new System.Drawing.Size(153, 22);
			this.NewItem.Text = "Новый";
			
			// 
			// OpenItem
			// 
			this.OpenItem.Name = "OpenItem";
			this.OpenItem.Size = new System.Drawing.Size(153, 22);
			this.OpenItem.Text = "Открыть";
			this.OpenItem.Click += new System.EventHandler(this.OpenItem_Click);
			// 
			// SaveItem
			// 
			this.SaveItem.Name = "SaveItem";
			this.SaveItem.Size = new System.Drawing.Size(153, 22);
			this.SaveItem.Text = "Сохранить";
			this.SaveItem.Click += new System.EventHandler(this.SaveItem_Click);
			// 
			// SaveAsItem
			// 
			this.SaveAsItem.Name = "SaveAsItem";
			this.SaveAsItem.Size = new System.Drawing.Size(153, 22);
			this.SaveAsItem.Text = "Сохранить как";
			this.SaveAsItem.Click += new System.EventHandler(this.SaveAsItem_Click);
			// 
			// Drawing
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1285, 528);
			this.Controls.Add(this.Width_Label);
			this.Controls.Add(this.Width_Text);
			this.Controls.Add(this.Draw_panel);
			this.Controls.Add(this.But_Pen);
			this.Controls.Add(this.But_Clear);
			this.Controls.Add(this.MainMenu);
			this.MainMenuStrip = this.MainMenu;
			this.MaximumSize = new System.Drawing.Size(1301, 567);
			this.MinimumSize = new System.Drawing.Size(1301, 567);
			this.Name = "Drawing";
			this.Text = "Drawing";
			this.MainMenu.ResumeLayout(false);
			this.MainMenu.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button But_Clear;
		private System.Windows.Forms.Button But_Pen;
		private System.Windows.Forms.Panel Draw_panel;
		private System.Windows.Forms.ColorDialog ColorDialog;
		private System.Windows.Forms.TextBox Width_Text;
		private System.Windows.Forms.Label Width_Label;
		private System.Windows.Forms.MenuStrip MainMenu;
		private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem NewItem;
		private System.Windows.Forms.ToolStripMenuItem OpenItem;
		private System.Windows.Forms.ToolStripMenuItem SaveItem;
		private System.Windows.Forms.ToolStripMenuItem SaveAsItem;
	}
}

