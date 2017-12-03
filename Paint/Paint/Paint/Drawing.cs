using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Runtime.Serialization;
using System.Xml;

namespace Paint
{
    public partial class Drawing : Form
    {
        Ellipse ellipse = new Ellipse();
        Rectangle rectangle = new Rectangle();

        Bitmap image; //текущее изображение
        Graphics g; //для рисования на image

        int penWidth; //размеры карандаша
        Color penColor; //цвет
						
		Pen pen;// карандаш
		SolidBrush erase; //объект ластика
        enum Figure { Brush, Ellipse, Rectangle, Eraser } //для выбора инструмента
        Figure figure = Figure.Brush; //выбранный инструмент

        bool painting = false; //флаг рисования
        Point prevPoint;
        Point startPoint;

        DataContractSerializer serializer; //объект для сериализации файла проекта
        [DataContract]
        [KnownType(typeof(Bitmap))]
        public class Project
        {
            [DataMember]
            public List<Bitmap> Changes { get; set; } //список изменений изображения
            [DataMember]
            public int CurrentChange { get; set; } //текущее изменение
            public string Filename { get; set; }
            public bool NeedSave { get; set; } //флаг наличия несохраненных изменений
        }
        public List<Project> projects; //список открытых проектов
        public int currentProject; //номер текущего проекта

        public Drawing()
        {
            InitializeComponent();
            penWidth = 2;
            penColor = Color.Black;
			pen = new Pen(penColor);
			erase = new SolidBrush(Color.White);

            /////////////////////////////////////////////////////////установка изображения для кнопки выбора цвета
            Bitmap buttonImage = new Bitmap(ChooseColorButton.Width, ChooseColorButton.Height);
			Graphics.FromImage(buttonImage).DrawRectangle(pen, 0, 0, ChooseColorButton.Width, ChooseColorButton.Height);
			ChooseColorButton.Image = buttonImage;

			 image = new Bitmap("WhiteBackground.png");
			 g = Graphics.FromImage(image);

            projects = new List<Project>();
            Project p = new Project()
            {
                Changes = new List<Bitmap>() { image.Clone() as Bitmap },
                CurrentChange = 0,
                Filename = default(string),
                NeedSave = false
            };
            projects.Add(p);
            currentProject = 0;
            serializer = new DataContractSerializer(typeof(Project));

            prevPoint = new Point(-1, -1);
        }

        private void OpenButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "File png(*.png)|*.png|File bmp(*.bmp)|*.bmp|File jpg(*.jpg)|*.jpg";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                projects[currentProject].Filename = fileDialog.FileName;
                image = new Bitmap(projects[currentProject].Filename); //открытие изображения
                PictureBox.Size = image.Size;
                projects[currentProject].Changes.Clear();
                projects[currentProject].Changes.Add(image.Clone() as Bitmap);
                projects[currentProject].CurrentChange = 0;
                projects[currentProject].NeedSave = false;
                PictureBox.Image = image;
                SaveButton.Enabled = false;
                SaveAsButton.Enabled = true;
                SaveProjButton.Enabled = true;
                OpenProjButton.Enabled = true;
                g = Graphics.FromImage(image);
                RemoveChagesButton.Enabled = false;
                ReverseRemoveButton.Enabled = false;
            }
        }

        public void SaveButton_Click(object sender, EventArgs e)
        {
            if (projects[currentProject].Filename == default(string))
            {
                SaveAsButton_Click(sender, e); //сохранение с выбором имени файла
            }
            else
            {
                image.Save(projects[currentProject].Filename + "1"); //сохраниение файла
                image.Dispose();
                foreach (var ch in projects[currentProject].Changes)
                {
                    ch.Dispose();
                }
                projects[currentProject].Changes.Clear();
                projects[currentProject].CurrentChange = 0;
                g.Dispose();
                (new FileInfo(projects[currentProject].Filename)).Delete();
                (new FileInfo(projects[currentProject].Filename + "1")).MoveTo(projects[currentProject].Filename);
                image = new Bitmap(projects[currentProject].Filename);
                g = Graphics.FromImage(image);
                projects[currentProject].Changes.Add(image.Clone() as Bitmap);
                projects[currentProject].NeedSave = false;
                SaveButton.Enabled = false;
                RemoveChagesButton.Enabled = false;
                ReverseRemoveButton.Enabled = false;
            }
        }

        public void SaveAsButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog fileDialog = new SaveFileDialog();
            fileDialog.Filter = "File png(*.png)|*.png|File bmp(*.bmp)|*.bmp|File jpg(*.jpg)|*.jpg";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                projects[currentProject].Filename = fileDialog.FileName; //сохраниение изображения с выбором имени
                image.Save(projects[currentProject].Filename);
                projects[currentProject].NeedSave = false;
            }
        }

        public void SaveAs(int projectNum) //метод для сохранения при закрытии
        {
            SaveFileDialog fileDialog = new SaveFileDialog();
            fileDialog.Filter = "File png(*.png)|*.png|File bmp(*.bmp)|*.bmp|File jpg(*.jpg)|*.jpg";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                projects[projectNum].Filename = fileDialog.FileName;
                image.Save(projects[projectNum].Filename);
                projects[projectNum].NeedSave = false;
            }
        }

        private void PaintWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            for (int i = 0; i < projects.Count; i++)
            {
                if (projects[i].NeedSave)
                {
                    FormClose saving = new FormClose(i); //вызов формы для сохраниения
                    saving.Owner = this;
                    saving.ShowDialog();
                    if (projects[i].NeedSave)
                    {
                        e.Cancel = true;
                    }
                }
            }
        }

        private void ChooseColorButton_Click(object sender, EventArgs e)
        {
            ColorDialog colors = new ColorDialog();
            if (colors.ShowDialog() == DialogResult.OK)
            {
                penColor = colors.Color;
				 pen = new Pen(penColor); //создание объекта кисти
				SolidBrush brush_1 = new SolidBrush(penColor);
				Bitmap buttonImage = new Bitmap(ChooseColorButton.Width, ChooseColorButton.Height); //изменение изображения кнопки
				Graphics.FromImage(buttonImage).FillRectangle(brush_1, new RectangleF(0, 0, ChooseColorButton.Width, ChooseColorButton.Height));
				ChooseColorButton.Image = buttonImage;
            }
        }

        private void LineWidth_ValueChanged(object sender, EventArgs e)
        {
            penWidth = Convert.ToInt32(LineWidth.Value); //изменение размера линии
        }

        private void PictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            ///////////////////////////////////////начало рисования
            projects[currentProject].NeedSave = true;
            SaveButton.Enabled = true;
            SaveAsButton.Enabled = true;
            SaveProjButton.Enabled = true;
            OpenProjButton.Enabled = true;
            painting = true;
            startPoint = e.Location;
            PictureBox_MouseMove(sender, e);
        }

        private void PictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (painting)
            {
               
                switch (figure)
                {
                    case Figure.Brush: //рисование кистью //g.DrawEllipse(pen, new RectangleF(e.X - penWidth / 2, e.Y - penWidth / 2, penWidth, penWidth));
						SolidBrush solidBrush = new SolidBrush(penColor);
						g.FillEllipse(solidBrush, new RectangleF(e.X - penWidth / 2, e.Y - penWidth / 2, penWidth, penWidth));
						PictureBox.Image = image;
                        break;
                    case Figure.Ellipse: //рисование эллипса
                        ellipse.MouseMove(ref image, ref g, startPoint, new Point(e.X, e.Y), pen, ref PictureBox, penWidth);
                        break;
                    case Figure.Rectangle: //рисование прямоугольника
                        rectangle.MouseMove(ref image, ref g, startPoint, new Point(e.X, e.Y), pen, ref PictureBox, penWidth);
                        break;
                    case Figure.Eraser: //использование ластика
                        g.FillEllipse(erase, new RectangleF(e.X - penWidth / 2, e.Y - penWidth / 2, penWidth, penWidth));
                        PictureBox.Image = image;
                        break;
                }
            }
        }

        private void PictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            ///////////////////////////////////////конец рисования
            if (painting)
            {
                switch (figure)
                {
                    case Figure.Brush:
                        break;
                    case Figure.Ellipse: //окончательная отрисовка эллипса
                        ellipse.MouseUp(ref image, ref g, startPoint, new Point(e.X, e.Y), pen, ref PictureBox,  penWidth);
                        break;
                    case Figure.Rectangle: //окончательная отрисовка прямоугольника
                       rectangle.MouseUp(ref image, ref g, startPoint, new Point(e.X, e.Y), pen, ref PictureBox, penWidth);
                        break;
                    case Figure.Eraser:
                        break;
                }
                ///////////////////////////////////////изменение списка изменений
                projects[currentProject].Changes.RemoveRange(projects[currentProject].CurrentChange + 1, projects[currentProject].Changes.Count - projects[currentProject].CurrentChange - 1);
                projects[currentProject].Changes.Add(image.Clone() as Bitmap);
                projects[currentProject].CurrentChange++;
                RemoveChagesButton.Enabled = true;
                ReverseRemoveButton.Enabled = false;
                painting = false;
            }
        }

        private void SelectBrushButton_Click(object sender, EventArgs e)
        {
            ChooseFigureButton.Image = SelectBrushButton.Image;
            figure = Figure.Brush; //выбор кисти
        }

        private void SelectEllipseButton_Click(object sender, EventArgs e)
        {
            ChooseFigureButton.Image = SelectEllipseButton.Image;
            figure = Figure.Ellipse; //выбор эллипса
        }

        private void SelectRectangleButton_Click(object sender, EventArgs e)
        {
            ChooseFigureButton.Image = SelectRectangleButton.Image;
            figure = Figure.Rectangle; //выбор прямоугольника
        }

        private void SelectEraserButton_Click(object sender, EventArgs e)
        {
            ChooseFigureButton.Image = SelectEraserButton.Image;
            figure = Figure.Eraser; //выбор ластика
        }

        private void RemoveChagesButton_Click(object sender, EventArgs e)
        {
            ///////////////////////////////////////////отмена изменений
            image = projects[currentProject].Changes[--projects[currentProject].CurrentChange].Clone() as Bitmap;
            g = Graphics.FromImage(image);
            PictureBox.Image = image;
            if (projects[currentProject].CurrentChange == 0)
            {
                RemoveChagesButton.Enabled = false;
            }
            ReverseRemoveButton.Enabled = true;
        }

        private void ReverseRemoveButton_Click(object sender, EventArgs e)
        {
            ///////////////////////////////////////////возврат изменений
            image = projects[currentProject].Changes[++projects[currentProject].CurrentChange].Clone() as Bitmap;
            g = Graphics.FromImage(image);
            PictureBox.Image = image;
            if (projects[currentProject].CurrentChange == projects[currentProject].Changes.Count - 1)
            {
                ReverseRemoveButton.Enabled = false;
            }
            RemoveChagesButton.Enabled = true;
        }

        private void NewFileButton_Click(object sender, EventArgs e)
        {
            /////////////////////////////////////добавление нового редактируемого файла(нового проекта)
            image.Dispose();
            image = new Bitmap("WhiteBackground.png");
            g = Graphics.FromImage(image);
            Project p = new Project() //создание нового пустого проекта
            {
                Changes = new List<Bitmap>() { image.Clone() as Bitmap },
                CurrentChange = 0,
                Filename = default(string)
            };
            projects.Add(p);
            currentProject++;
            ProjectNumBox.Items.Add(projects.Count);
            ProjectNumBox.SelectedIndex = projects.Count - 1;
            PictureBox.Image = image;
            RemoveChagesButton.Enabled = false;
            ReverseRemoveButton.Enabled = false;
        }

        private void CloseFileButton_Click(object sender, EventArgs e)
        {
            /////////////////////////////////////закрытие редактируемого файла(текущего проекта)
            if (ProjectNumBox.Items.Count == 1)
            {
                return;
            }
            image.Dispose();
            projects.RemoveAt(currentProject);
            if (currentProject == projects.Count)
            {
                currentProject--;
            }
            image = projects[currentProject].Changes[projects[currentProject].CurrentChange].Clone() as Bitmap;
            g = Graphics.FromImage(image);
            PictureBox.Image = image;
            RemoveChagesButton.Enabled = (projects[currentProject].CurrentChange != 0);
            ReverseRemoveButton.Enabled = (projects[currentProject].CurrentChange < projects[currentProject].Changes.Count - 1);
            ProjectNumBox.Items.RemoveAt(ProjectNumBox.Items.Count - 1);
            if (ProjectNumBox.SelectedIndex == -1)
            {
                ProjectNumBox.SelectedIndex = ProjectNumBox.Items.Count - 1;
            }
        }

        private void ProjectNumBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            /////////////////////////////////////////изменение текущего проекта из открытых проектов
            currentProject = ProjectNumBox.SelectedIndex;
            image.Dispose();
            image = projects[currentProject].Changes[projects[currentProject].CurrentChange].Clone() as Bitmap;
            g = Graphics.FromImage(image);
            PictureBox.Image = image;
            RemoveChagesButton.Enabled = (projects[currentProject].CurrentChange != 0);
            ReverseRemoveButton.Enabled = (projects[currentProject].CurrentChange < projects[currentProject].Changes.Count - 1);
        }

        private void SaveProjButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog fileDialog = new SaveFileDialog();
            fileDialog.Filter = "xml file (*.xml)|*.xml";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                using (XmlWriter writer = XmlWriter.Create(fileDialog.FileName))
                {
                    serializer.WriteObject(writer, projects[currentProject]); //сериализация текущего проекта в файл
                }
            }
        }

        private void OpenProjButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "xml file (*.xml)|*.xml";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                using (XmlReader reader = XmlReader.Create(fileDialog.FileName))
                {
                    projects[currentProject] = (Project)serializer.ReadObject(reader); //десериализация проекта из файла в текущий проект
                    image.Dispose();
                    image = projects[currentProject].Changes[projects[currentProject].CurrentChange].Clone() as Bitmap;
                    g = Graphics.FromImage(image);
                    PictureBox.Image = image;
                    RemoveChagesButton.Enabled = (projects[currentProject].CurrentChange != 0);
                    ReverseRemoveButton.Enabled = (projects[currentProject].CurrentChange < projects[currentProject].Changes.Count - 1);
                }
            }
        }

		
	}
}
