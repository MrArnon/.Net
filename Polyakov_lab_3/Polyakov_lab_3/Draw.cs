using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Polyakov_lab_3
{
	class Draw
	{
		public Color CurrentColor { get; set; }
		public bool isPressed { get; set; }
		public Point CurrentPoint { get; set; }
		public Point PrevPoint { get; set; }
		public Graphics g { get; set; }
		public int Width { get; set; }
		public Draw()  
		{
			 CurrentColor = Color.Black;
			isPressed = false;
			Width = 2;
			//g = panel1.CreateGraphics();
		}
		public void paint_simple()
		{
			Pen p = new Pen(CurrentColor,Width);
			try
			{
				g.DrawLine(p, PrevPoint, CurrentPoint);
			}
			catch (System.NullReferenceException) { MessageBox.Show("Вы не выбрали цвет"); }
			}
	}
}
