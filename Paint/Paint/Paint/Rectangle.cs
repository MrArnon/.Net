using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint
{
    class Rectangle : ToolsClass
    {
        public override void MouseMove(ref Bitmap image, ref Graphics g, Point startPoint, Point e, Pen brush, ref PictureBox pictureBox, int penWidth)
        {
            Bitmap img = image.Clone() as Bitmap; //временный объект для отображения нарисованной фигуры
            pictureBox.Image = img;
            Graphics gg = Graphics.FromImage(img);
			brush.Width = penWidth;
			gg.DrawRectangle(brush, Math.Min(startPoint.X, e.X), Math.Min(startPoint.Y, e.Y), Math.Abs(e.X - startPoint.X), Math.Abs(e.Y - startPoint.Y));
			pictureBox.Image = img;
        }

        public override void MouseUp(ref Bitmap image, ref Graphics g, Point startPoint, Point e, Pen brush, ref PictureBox pictureBox, int penWidth)
        {
			brush.Width = penWidth;
			g.DrawRectangle(brush, Math.Min(startPoint.X, e.X), Math.Min(startPoint.Y, e.Y), Math.Abs(e.X - startPoint.X), Math.Abs(e.Y - startPoint.Y));
			pictureBox.Image = image;
        }
    }
}
