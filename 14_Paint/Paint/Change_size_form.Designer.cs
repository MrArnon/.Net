namespace Paint
{
    partial class Change_size_form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.label1 = new System.Windows.Forms.Label();
			this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
			this.label2 = new System.Windows.Forms.Label();
			this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
			this.OkButton = new System.Windows.Forms.Button();
			this.CancelBut = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.ForeColor = System.Drawing.Color.Black;
			this.label1.Location = new System.Drawing.Point(12, 38);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(180, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Изменение в ширину";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.Location = new System.Drawing.Point(219, 38);
			this.numericUpDown1.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new System.Drawing.Size(75, 20);
			this.numericUpDown1.TabIndex = 1;
			this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.numericUpDown1.Value = new decimal(new int[] {
            444,
            0,
            0,
            0});
			// 
			// label2
			// 
			this.label2.ForeColor = System.Drawing.Color.Black;
			this.label2.Location = new System.Drawing.Point(12, 95);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(180, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "Изменение в высоту";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// numericUpDown2
			// 
			this.numericUpDown2.Location = new System.Drawing.Point(219, 95);
			this.numericUpDown2.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.numericUpDown2.Name = "numericUpDown2";
			this.numericUpDown2.Size = new System.Drawing.Size(75, 20);
			this.numericUpDown2.TabIndex = 3;
			this.numericUpDown2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.numericUpDown2.Value = new decimal(new int[] {
            442,
            0,
            0,
            0});
			// 
			// OkButton
			// 
			this.OkButton.Location = new System.Drawing.Point(50, 157);
			this.OkButton.Name = "OkButton";
			this.OkButton.Size = new System.Drawing.Size(75, 23);
			this.OkButton.TabIndex = 4;
			this.OkButton.Text = "Ок";
			this.OkButton.UseVisualStyleBackColor = true;
			this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
			// 
			// CancelBut
			// 
			this.CancelBut.Location = new System.Drawing.Point(219, 157);
			this.CancelBut.Name = "CancelBut";
			this.CancelBut.Size = new System.Drawing.Size(75, 23);
			this.CancelBut.TabIndex = 5;
			this.CancelBut.Text = "Отмена";
			this.CancelBut.UseVisualStyleBackColor = true;
			this.CancelBut.Click += new System.EventHandler(this.CancelButton_Click);
			// 
			// ChangeSizeForma
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(348, 204);
			this.Controls.Add(this.CancelBut);
			this.Controls.Add(this.OkButton);
			this.Controls.Add(this.numericUpDown2);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.numericUpDown1);
			this.Controls.Add(this.label1);
			this.MaximizeBox = false;
			this.MinimumSize = new System.Drawing.Size(295, 232);
			this.Name = "ChangeSizeForma";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Размеры рабочего окна";
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.Button CancelBut;
    }
}