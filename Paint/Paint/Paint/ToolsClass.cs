using System.Drawing;
using System.Windows.Forms;

namespace Paint
{
    abstract class ToolsClass
    {
		// protected SolidBrush eraseBrush = new SolidBrush(Color.White);
		protected Pen erase = new Pen(Color.White);
		protected int penWidth = 2;
        public abstract void MouseMove(ref Bitmap image, ref Graphics g, Point startPoint, Point e, Pen brush, ref PictureBox pictureBox, int penWidth);
        public abstract void MouseUp(ref Bitmap image, ref Graphics g, Point startPoint, Point e, Pen brush, ref PictureBox pictureBox, int penWidth);
    }
}
