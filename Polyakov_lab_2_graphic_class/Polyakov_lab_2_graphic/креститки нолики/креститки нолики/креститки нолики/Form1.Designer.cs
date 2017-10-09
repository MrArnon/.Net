namespace креститки_нолики
{
    partial class Cross_zero
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
            this.Start_but = new System.Windows.Forms.Button();
            this.Game_field = new System.Windows.Forms.Panel();
            this.First_comp_but = new System.Windows.Forms.RadioButton();
            this.First_player_but = new System.Windows.Forms.RadioButton();
            this.Clear_but = new System.Windows.Forms.Button();
            this.Label_mes = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Start_but
            // 
            this.Start_but.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Start_but.Location = new System.Drawing.Point(377, 12);
            this.Start_but.Name = "Start_but";
            this.Start_but.Size = new System.Drawing.Size(114, 54);
            this.Start_but.TabIndex = 1;
            this.Start_but.Text = "Начать ";
            this.Start_but.UseVisualStyleBackColor = true;
            this.Start_but.Click += new System.EventHandler(this.Start_but_Click);
            // 
            // Game_field
            // 
            this.Game_field.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Game_field.Location = new System.Drawing.Point(12, 12);
            this.Game_field.Name = "Game_field";
            this.Game_field.Size = new System.Drawing.Size(302, 302);
            this.Game_field.TabIndex = 2;
            this.Game_field.Paint += new System.Windows.Forms.PaintEventHandler(this.Game_field_Paint);
            this.Game_field.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Game_field_MouseClick);
            // 
            // First_comp_but
            // 
            this.First_comp_but.AutoSize = true;
            this.First_comp_but.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.First_comp_but.Location = new System.Drawing.Point(332, 208);
            this.First_comp_but.Name = "First_comp_but";
            this.First_comp_but.Size = new System.Drawing.Size(277, 29);
            this.First_comp_but.TabIndex = 3;
            this.First_comp_but.Text = "Первый ход компьютера";
            this.First_comp_but.UseVisualStyleBackColor = true;
            this.First_comp_but.CheckedChanged += new System.EventHandler(this.First_comp_but_CheckedChanged);
            // 
            // First_player_but
            // 
            this.First_player_but.AutoSize = true;
            this.First_player_but.Checked = true;
            this.First_player_but.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.First_player_but.Location = new System.Drawing.Point(332, 108);
            this.First_player_but.Name = "First_player_but";
            this.First_player_but.Size = new System.Drawing.Size(221, 29);
            this.First_player_but.TabIndex = 4;
            this.First_player_but.TabStop = true;
            this.First_player_but.Text = "Первый ход игрока";
            this.First_player_but.UseVisualStyleBackColor = true;
            this.First_player_but.CheckedChanged += new System.EventHandler(this.First_player_but_CheckedChanged);
            // 
            // Clear_but
            // 
            this.Clear_but.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Clear_but.Location = new System.Drawing.Point(377, 264);
            this.Clear_but.Name = "Clear_but";
            this.Clear_but.Size = new System.Drawing.Size(114, 50);
            this.Clear_but.TabIndex = 6;
            this.Clear_but.Text = "Очистить";
            this.Clear_but.UseVisualStyleBackColor = true;
            this.Clear_but.Click += new System.EventHandler(this.Clear_but_Click);
            // 
            // Label_mes
            // 
            this.Label_mes.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label_mes.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.Label_mes.Location = new System.Drawing.Point(326, 140);
            this.Label_mes.Name = "Label_mes";
            this.Label_mes.Size = new System.Drawing.Size(203, 65);
            this.Label_mes.TabIndex = 7;
            this.Label_mes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Cross_zero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(634, 342);
            this.Controls.Add(this.Label_mes);
            this.Controls.Add(this.Clear_but);
            this.Controls.Add(this.First_player_but);
            this.Controls.Add(this.First_comp_but);
            this.Controls.Add(this.Game_field);
            this.Controls.Add(this.Start_but);
            this.MaximumSize = new System.Drawing.Size(650, 400);
            this.MinimumSize = new System.Drawing.Size(575, 380);
            this.Name = "Cross_zero";
            this.Text = "Cross_zero";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Start_but;
        private System.Windows.Forms.Panel Game_field;
        private System.Windows.Forms.RadioButton First_comp_but;
        private System.Windows.Forms.RadioButton First_player_but;
        private System.Windows.Forms.Button Clear_but;
        private System.Windows.Forms.Label Label_mes;
    }
}

