using System;
using System.Windows.Forms;

namespace Paint
{
    public partial class FormClose : Form
    {
        Drawing main; //объект главной формы
        int projectNum;

        public FormClose(int i)
        {
            projectNum = i;
            InitializeComponent();
        }

        private void CloseSaving_Load(object sender, EventArgs e)
        {
            main = this.Owner as Drawing;
            string filename = main.projects[projectNum].Filename;
            if (filename == default(string))
            {
                filename = (projectNum + 1).ToString();
            }
            QuestionText.Text = String.Format("Вы хотите сохранить изменения в файле {0}?", filename);

            ///////////////////////////////////вычисление размеров формы для вмещения имени файла
            int minSize = 270 + 40 + 16;
            int textWidth = 8 + 20 + QuestionText.Width + 20 + 8;
            if (minSize > textWidth)
            {
                Width = minSize;
                QuestionText.Left = 20 + (270 - QuestionText.Width) / 2;
            }
            else
            {
                Width = textWidth;
                QuestionText.Left = 20;
            }
            int size = Width / 31;
            SaveButton.Width = DoNotSaveButton.Width = CancelButton.Width = size * 9;
            SaveButton.Left = size;
            DoNotSaveButton.Left = size * 11;
            CancelButton.Left = size * 21;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            main.projects[projectNum].NeedSave = false;
            main.SaveAs(projectNum); //сохраниение файла с выбором имени
            Close();
        }

        private void DoNotSaveButton_Click(object sender, EventArgs e)
        {
            main.projects[projectNum].NeedSave = false;
            Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
