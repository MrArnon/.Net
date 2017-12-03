namespace Paint
{
    partial class FormClose
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
			this.QuestionText = new System.Windows.Forms.Label();
			this.SaveButton = new System.Windows.Forms.Button();
			this.DoNotSaveButton = new System.Windows.Forms.Button();
			this.CancelButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// QuestionText
			// 
			this.QuestionText.AutoSize = true;
			this.QuestionText.Location = new System.Drawing.Point(44, 9);
			this.QuestionText.Name = "QuestionText";
			this.QuestionText.Size = new System.Drawing.Size(211, 13);
			this.QuestionText.TabIndex = 0;
			this.QuestionText.Text = "Cохранить изменения в файле filename?";
			// 
			// SaveButton
			// 
			this.SaveButton.Location = new System.Drawing.Point(4, 35);
			this.SaveButton.Name = "SaveButton";
			this.SaveButton.Size = new System.Drawing.Size(90, 23);
			this.SaveButton.TabIndex = 1;
			this.SaveButton.Text = "Сохранить";
			this.SaveButton.UseVisualStyleBackColor = true;
			this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
			// 
			// DoNotSaveButton
			// 
			this.DoNotSaveButton.Location = new System.Drawing.Point(100, 35);
			this.DoNotSaveButton.Name = "DoNotSaveButton";
			this.DoNotSaveButton.Size = new System.Drawing.Size(90, 23);
			this.DoNotSaveButton.TabIndex = 2;
			this.DoNotSaveButton.Text = "Не сохранять";
			this.DoNotSaveButton.UseVisualStyleBackColor = true;
			this.DoNotSaveButton.Click += new System.EventHandler(this.DoNotSaveButton_Click);
			// 
			// CancelButton
			// 
			this.CancelButton.Location = new System.Drawing.Point(196, 35);
			this.CancelButton.Name = "CancelButton";
			this.CancelButton.Size = new System.Drawing.Size(90, 23);
			this.CancelButton.TabIndex = 3;
			this.CancelButton.Text = "Отмена";
			this.CancelButton.UseVisualStyleBackColor = true;
			this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
			// 
			// FormClose
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(288, 79);
			this.Controls.Add(this.CancelButton);
			this.Controls.Add(this.DoNotSaveButton);
			this.Controls.Add(this.SaveButton);
			this.Controls.Add(this.QuestionText);
			this.MinimumSize = new System.Drawing.Size(304, 118);
			this.Name = "FormClose";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Drawing";
			this.Load += new System.EventHandler(this.CloseSaving_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label QuestionText;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button DoNotSaveButton;
        private System.Windows.Forms.Button CancelButton;
    }
}