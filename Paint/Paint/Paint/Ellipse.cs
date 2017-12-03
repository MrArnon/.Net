using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint
{
    class Ellipse : ToolsClass
    {
        public override void MouseMove(ref Bitmap image, ref Graphics g, Point startPoint, Point e, Pen brush, ref PictureBox pictureBox, int penWidth)
        {
            Bitmap img = image.Clone() as Bitmap; //временный объект для отображения ненарисованной фигуры
            pictureBox.Image = img;
            Graphics gg = Graphics.FromImage(img);
			brush.Width = penWidth;
			gg.DrawEllipse(brush, new RectangleF(startPoint.X, startPoint.Y, e.X - startPoint.X, e.Y - startPoint.Y));
			 pictureBox.Image = img;
        }

        public override void MouseUp(ref Bitmap image, ref Graphics g, Point startPoint, Point e, Pen brush, ref PictureBox pictureBox, int penWidth)
        {
			brush.Width = penWidth;
			g.DrawEllipse(brush, new RectangleF(startPoint.X, startPoint.Y, e.X - startPoint.X, e.Y - startPoint.Y));
			pictureBox.Image = image;
        }
    }
}
