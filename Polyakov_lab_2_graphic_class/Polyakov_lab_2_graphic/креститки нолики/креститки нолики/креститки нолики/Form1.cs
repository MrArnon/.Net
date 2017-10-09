using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace креститки_нолики
{
    public partial class Cross_zero : Form
    {


        public Cross_zero()
        {

            InitializeComponent();

        }
        Game game = new Game();

        private void Start_but_Click(object sender, EventArgs e)
        {
            game.start = true;
            Start_but.Visible = false;

            if (game.pc == 1)  //первый ход компа
            {
                game.Turn = true;
                game.hod1();
                paint();
                First_comp_but.Visible = false;
                First_player_but.Visible = false;
            }
            else     //первый ход пользователя
            {
                game.Turn = false;
                Label_mes.Text = ("Ваш ход");
                First_comp_but.Visible = false;
                First_player_but.Visible = false;

            }
        }

        private void Game_field_Paint(object sender, PaintEventArgs e)
        {
            Graphics gPanel = Game_field.CreateGraphics();

            Pen p1 = new Pen(Color.DeepSkyBlue, 2);

            gPanel.DrawLine(p1, new Point(100, 0), new Point(100, 300));
            gPanel.DrawLine(p1, new Point(200, 0), new Point(200, 300));
            gPanel.DrawLine(p1, new Point(0, 100), new Point(300, 100));
            gPanel.DrawLine(p1, new Point(0, 200), new Point(300, 200));
        }

        private void Game_field_MouseClick(object sender, MouseEventArgs e)
        {
            if (game.start)
            {
                if (game.pc == 0)  //если пользователь сразу нажимает на доску, не выбрав кто будет ходить первым
                {
                    MessageBox.Show("Выберите игрока");
                }
                else
                {
                    if (game.Turn == false)   //ход пользователя
                    {
                        if (game.pc == 2)    //первый ход пользователя, значит он играет крестиками
                        {
                            if (e.Location.X > 0 && e.Location.X < 100 && e.Location.Y > 0 && e.Location.Y < 100)  //1 ячейка
                            {

                                if (game.Field[0, 0] == 0)
                                {
                                    Graphics gPanel = Game_field.CreateGraphics();
                                    Pen p = new Pen(Color.Red, 3);
                                    gPanel.DrawLine(p, 2, 2, 98, 98);
                                    gPanel.DrawLine(p, 98, 2, 2, 98);
                                    game.Field[0, 0] = 2;
                                    game.xlast = 0;
                                    game.ylast = 0;
                                    game.first = false;
                                }
                                else
                                {
                                    Label_mes.Text = "Ячейка уже занята";
                                }
                            }

                            if (e.Location.X > 100 && e.Location.X < 200 && e.Location.Y > 0 && e.Location.Y < 100)//2 ячейка
                            {
                                if (game.Field[1, 0] == 0)
                                {
                                    Graphics gPanel = Game_field.CreateGraphics();
                                    Pen p = new Pen(Color.Red, 3);
                                    gPanel.DrawLine(p, 102, 2, 198, 98);
                                    gPanel.DrawLine(p, 198, 2, 102, 98);
                                    game.Field[1, 0] = 2;
                                    game.xlast = 1;
                                    game.ylast = 0;
                                    game.first = false;
                                }
                                else
                                {
                                    Label_mes.Text = "Ячейка уже занята";
                                }
                            }
                            if (e.Location.X > 200 && e.Location.X < 300 && e.Location.Y > 0 && e.Location.Y < 100)//3 ячейка
                            {
                                if (game.Field[2, 0] == 0)
                                {
                                    Graphics gPanel = Game_field.CreateGraphics();
                                    Pen p = new Pen(Color.Red, 3);
                                    gPanel.DrawLine(p, 202, 2, 298, 98);
                                    gPanel.DrawLine(p, 298, 2, 202, 98);
                                    game.Field[2, 0] = 2;
                                    game.xlast = 2;
                                    game.ylast = 0;
                                    game.first = false;
                                }
                                else
                                {
                                    Label_mes.Text = "Ячейка уже занята";
                                }
                            }
                            if (e.Location.X > 0 && e.Location.X < 100 && e.Location.Y > 100 && e.Location.Y < 200)//4 ячейка
                            {
                                if (game.Field[0, 1] == 0)
                                {
                                    Graphics gPanel = Game_field.CreateGraphics();
                                    Pen p = new Pen(Color.Red, 3);
                                    gPanel.DrawLine(p, 2, 102, 98, 198);
                                    gPanel.DrawLine(p, 98, 102, 2, 198);
                                    game.Field[0, 1] = 2;
                                    game.xlast = 0;
                                    game.ylast = 1;
                                    game.first = false;
                                }
                                else
                                {
                                    Label_mes.Text = "Ячейка уже занята";
                                }
                            }
                            if (e.Location.X > 100 && e.Location.X < 200 && e.Location.Y > 100 && e.Location.Y < 200)//5 ячейка
                            {
                                if (game.Field[1, 1] == 0)
                                {
                                    Graphics gPanel = Game_field.CreateGraphics();
                                    Pen p = new Pen(Color.Red, 3);
                                    gPanel.DrawLine(p, 102, 102, 198, 198);
                                    gPanel.DrawLine(p, 198, 102, 102, 198);
                                    game.Field[1, 1] = 2;
                                    game.xlast = 1;
                                    game.ylast = 1;
                                    if (game.first)
                                    {
                                        game.xfir = 1;
                                        game.yfir = 1;
                                        game.first = false;
                                    }
                                }
                                else
                                {
                                    Label_mes.Text = "Ячейка уже занята";
                                }
                            }
                            if (e.Location.X > 200 && e.Location.X < 300 && e.Location.Y > 100 && e.Location.Y < 200)//6 ячейка
                            {
                                if (game.Field[2, 1] == 0)
                                {
                                    Graphics gPanel = Game_field.CreateGraphics();
                                    Pen p = new Pen(Color.Red, 3);
                                    gPanel.DrawLine(p, 202, 102, 298, 198);
                                    gPanel.DrawLine(p, 298, 102, 202, 198);
                                    game.Field[2, 1] = 2;
                                    game.xlast = 2;
                                    game.ylast = 1;
                                    game.first = false;
                                }
                                else
                                {
                                    Label_mes.Text = "Ячейка уже занята";
                                }
                            }
                            if (e.Location.X > 0 && e.Location.X < 100 && e.Location.Y > 200 && e.Location.Y < 300)//7 ячейка
                            {
                                if (game.Field[0, 2] == 0)
                                {
                                    Graphics gPanel = Game_field.CreateGraphics();
                                    Pen p = new Pen(Color.Red, 3);
                                    gPanel.DrawLine(p, 2, 202, 98, 298);
                                    gPanel.DrawLine(p, 98, 202, 2, 298);
                                    game.Field[0, 2] = 2;
                                    game.xlast = 0;
                                    game.ylast = 2;
                                    game.first = false;
                                }
                                else
                                {
                                    Label_mes.Text = "Ячейка уже занята";
                                }
                            }
                            if (e.Location.X > 100 && e.Location.X < 200 && e.Location.Y > 200 && e.Location.Y < 300)//8 ячейка
                            {
                                if (game.Field[1, 2] == 0)
                                {
                                    Graphics gPanel = Game_field.CreateGraphics();
                                    Pen p = new Pen(Color.Red, 3);
                                    gPanel.DrawLine(p, 102, 202, 198, 298);
                                    gPanel.DrawLine(p, 198, 202, 102, 298);
                                    game.Field[1, 2] = 2;
                                    game.xlast = 1;
                                    game.ylast = 2;
                                    game.first = false;
                                }
                                else
                                {
                                    Label_mes.Text = "Ячейка уже занята";
                                }
                            }
                            if (e.Location.X > 200 && e.Location.X < 300 && e.Location.Y > 200 && e.Location.Y < 300)//8 ячейка
                            {
                                if (game.Field[2, 2] == 0)
                                {
                                    Graphics gPanel = Game_field.CreateGraphics();
                                    Pen p = new Pen(Color.Red, 3);
                                    gPanel.DrawLine(p, 202, 202, 298, 298);
                                    gPanel.DrawLine(p, 298, 202, 202, 298);
                                    game.Field[2, 2] = 2;
                                    game.xlast = 2;
                                    game.ylast = 2;
                                    game.first = false;
                                }
                                else
                                {
                                    Label_mes.Text = "Ячейка уже занята";
                                }
                            }
                        }
                        else   // пользователь играет ноликами!!!
                        {
                            if (e.Location.X > 0 && e.Location.X < 100 && e.Location.Y > 0 && e.Location.Y < 100)  //1 ячейка
                            {

                                if (game.Field[0, 0] == 0)
                                {
                                    Graphics gPanel = Game_field.CreateGraphics();
                                    Pen p = new Pen(Color.DarkGreen, 3);
                                    gPanel.DrawEllipse(p, 4, 4, 92, 92);
                                    game.Field[0, 0] = 2;
                                    game.xlast = 0;
                                    game.ylast = 0;
                                }
                                else
                                {
                                    Label_mes.Text = "Ячейка уже занята";
                                }
                            }

                            if (e.Location.X > 100 && e.Location.X < 200 && e.Location.Y > 0 && e.Location.Y < 100)//2 ячейка
                            {
                                if (game.Field[1, 0] == 0)
                                {
                                    Graphics gPanel = Game_field.CreateGraphics();
                                    Pen p = new Pen(Color.DarkGreen, 3);
                                    gPanel.DrawEllipse(p, 104, 4, 92, 92);
                                    game.Field[1, 0] = 2;
                                    game.xlast = 1;
                                    game.ylast = 0;
                                }
                                else
                                {
                                    Label_mes.Text = "Ячейка уже занята";
                                }
                            }
                            if (e.Location.X > 200 && e.Location.X < 300 && e.Location.Y > 0 && e.Location.Y < 100)//3 ячейка
                            {
                                if (game.Field[2, 0] == 0)
                                {
                                    Graphics gPanel = Game_field.CreateGraphics();
                                    Pen p = new Pen(Color.DarkGreen, 3);
                                    gPanel.DrawEllipse(p, 204, 4, 92, 92);
                                    game.Field[2, 0] = 2;
                                    game.xlast = 2;
                                    game.ylast = 0;
                                }
                                else
                                {
                                    Label_mes.Text = "Ячейка уже занята";
                                }
                            }
                            if (e.Location.X > 0 && e.Location.X < 100 && e.Location.Y > 100 && e.Location.Y < 200)//4 ячейка
                            {
                                if (game.Field[0, 1] == 0)
                                {
                                    Graphics gPanel = Game_field.CreateGraphics();
                                    Pen p = new Pen(Color.DarkGreen, 3);
                                    gPanel.DrawEllipse(p, 4, 104, 92, 92);
                                    game.Field[0, 1] = 2;
                                    game.xlast = 0;
                                    game.ylast = 1;
                                }
                                else
                                {
                                    Label_mes.Text = "Ячейка уже занята";
                                }
                            }
                            if (e.Location.X > 100 && e.Location.X < 200 && e.Location.Y > 100 && e.Location.Y < 200)//5 ячейка
                            {
                                if (game.Field[1, 1] == 0)
                                {
                                    Graphics gPanel = Game_field.CreateGraphics();
                                    Pen p = new Pen(Color.DarkGreen, 3);
                                    gPanel.DrawEllipse(p, 104, 104, 92, 92);
                                    game.Field[1, 1] = 2;
                                    game.xlast = 1;
                                    game.ylast = 1;
                                }
                                else
                                {
                                    Label_mes.Text = "Ячейка уже занята";
                                }
                            }
                            if (e.Location.X > 200 && e.Location.X < 300 && e.Location.Y > 100 && e.Location.Y < 200)//6 ячейка
                            {
                                if (game.Field[2, 1] == 0)
                                {
                                    Graphics gPanel = Game_field.CreateGraphics();
                                    Pen p = new Pen(Color.DarkGreen, 3);
                                    gPanel.DrawEllipse(p, 204, 104, 92, 92);
                                    game.Field[2, 1] = 2;
                                    game.xlast = 2;
                                    game.ylast = 1;
                                }
                                else
                                {
                                    Label_mes.Text = "Ячейка уже занята";
                                }
                            }
                            if (e.Location.X > 0 && e.Location.X < 100 && e.Location.Y > 200 && e.Location.Y < 300)//7 ячейка
                            {
                                if (game.Field[0, 2] == 0)
                                {
                                    Graphics gPanel = Game_field.CreateGraphics();
                                    Pen p = new Pen(Color.DarkGreen, 3);
                                    gPanel.DrawEllipse(p, 4, 204, 92, 92);
                                    game.Field[0, 2] = 2;
                                    game.xlast = 0;
                                    game.ylast = 2;
                                }
                                else
                                {
                                    Label_mes.Text = "Ячейка уже занята";
                                }
                            }
                            if (e.Location.X > 100 && e.Location.X < 200 && e.Location.Y > 200 && e.Location.Y < 300)//8 ячейка
                            {
                                if (game.Field[1, 2] == 0)
                                {
                                    Graphics gPanel = Game_field.CreateGraphics();
                                    Pen p = new Pen(Color.DarkGreen, 3);
                                    gPanel.DrawEllipse(p, 104, 204, 92, 92);
                                    game.Field[1, 2] = 2;
                                    game.xlast = 1;
                                    game.ylast = 2;
                                }
                                else
                                {
                                    Label_mes.Text = "Ячейка уже занята";

                                }
                            }
                            if (e.Location.X > 200 && e.Location.X < 300 && e.Location.Y > 200 && e.Location.Y < 300)//9 ячейка
                            {
                                if (game.Field[2, 2] == 0)
                                {
                                    Graphics gPanel = Game_field.CreateGraphics();
                                    Pen p = new Pen(Color.DarkGreen, 3);
                                    gPanel.DrawEllipse(p, 204, 204, 92, 92);
                                    game.Field[2, 2] = 2;
                                    game.xlast = 2;
                                    game.ylast = 2;
                                }
                                else
                                {
                                    Label_mes.Text = "Ячейка уже занята";
                                }
                            }
                        }
                        if (Label_mes.Text == "Ячейка уже занята")
                        {
                            game.Turn = false;
                            Label_mes.Text = "Неверный ход";
                        }
                        else
                        {

                            
                            game.Turn = !(game.check_player());   //след ход компьютера
                                paint();
                            game.hod();
                            paint();

                            winner();
                                paint();
                           
                        }
                    }
                }
            }
        }

        private void First_comp_but_CheckedChanged(object sender, EventArgs e)
        {
            if (First_comp_but.Checked)
            {
                game.pc = 1;   //первый ход компьютера
            }
        }

        private void First_player_but_CheckedChanged(object sender, EventArgs e)
        {
            if (First_player_but.Checked)
            {
                game.pc = 2;    //первый ход человека
            }
        }

        private void Clear_but_Click(object sender, EventArgs e)
        {
            //newgame();
            game.Clearing();
            Label_mes.Text = string.Empty;
            Graphics gPanel = Game_field.CreateGraphics();
            Game_field.Controls.Clear();
            Game_field.Invalidate();
            Pen p1 = new Pen(Color.DeepSkyBlue, 2);
            gPanel.DrawLine(p1, new Point(100, 0), new Point(100, 300));
            gPanel.DrawLine(p1, new Point(200, 0), new Point(200, 300));
            gPanel.DrawLine(p1, new Point(0, 100), new Point(300, 100));
            gPanel.DrawLine(p1, new Point(0, 200), new Point(300, 200));
            First_comp_but.Visible = true;
            First_player_but.Visible = true;
            First_comp_but.Checked = false;
            First_player_but.Checked = true;
            Start_but.Visible = true;
        }
        private void paint()
        {
            for (int i = 0; i < game.n; i++)
            {
                for (int j = 0; j < game.n; j++)
                {
                    if (game.pc == 1)   //если компьютер начинал, то 1 - это крестики
                    {
                        if (game.Field[i, j] == 1)
                        {
                            Graphics gPanel = Game_field.CreateGraphics();
                            Pen p = new Pen(Color.Red, 3);
                            gPanel.DrawLine(p, 2 + i * 100, 2 + j * 100, 98 + i * 100, 98 + j * 100);
                            gPanel.DrawLine(p, 98 + i * 100, 2 + j * 100, 2 + i * 100, 98 + j * 100);
                        }
                    }
                    else   //компьютер ходил вторым, 1 - нолики
                    {
                        if (game.Field[i, j] == 1)
                        {
                            Graphics gPanel = Game_field.CreateGraphics();
                            Pen p = new Pen(Color.DarkGreen, 3);
                            gPanel.DrawEllipse(p, 4 + i * 100, 4 + j * 100, 92, 92);
                        }
                    }
                }
            }
        }
        private void winner()
        {
            Graphics gPanel = Game_field.CreateGraphics();
            Pen p = new Pen(Color.Blue, 6);
            switch (game.line)
            {
                case 1: gPanel.DrawLine(p, 2, 50, 298, 50); break;
                case 2: gPanel.DrawLine(p, 2, 150, 298, 150); break;
                case 3: gPanel.DrawLine(p, 2, 250, 298, 250); break;
                case 4: gPanel.DrawLine(p, 50, 2, 50, 298); break;
                case 5: gPanel.DrawLine(p, 150, 2, 150, 298); break;
                case 6: gPanel.DrawLine(p, 250, 2, 250, 298); break;
                case 7: gPanel.DrawLine(p, 2, 2, 298, 298); break;
                case 8: gPanel.DrawLine(p, 298, 2, 2, 298); break;
            }
            switch (game.win)
            {
                case 1: { MessageBox.Show("Компьютер выиграл"); break; }
                case 2: { MessageBox.Show("Пользователь выиграл"); break; }
                case 3: { MessageBox.Show("Ничья"); break; }
            }
        }









    }
}
