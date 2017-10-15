using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Polyakov_lab_1
{
    public partial class Ships : Form
    {
        List<Ship> spisok = new List<Ship>();


        public Ships()
        {
            InitializeComponent();
        }

        private void Create_new_object_Click(object sender, EventArgs e)
        {
            Ship temp = new Ship(Name_ship.Text, Type_ship.Text, Coutry.Text, General_caliber.Text);
            if (!string.IsNullOrEmpty(Name_ship.Text))
            {
                spisok.Add(temp);
                Value_objects.Text = spisok.Count.ToString();
            }
            Name_ship.Text = Type_ship.Text = Coutry.Text = General_caliber.Text = string.Empty;

        }

        private void Delete_object_Click(object sender, EventArgs e)
        {
            string str = Del_name.Text;
            for (int i = 0; i < spisok.Count; i++)
            {
                Ship temp = spisok[i];
                string s = temp.Name;
                if (s == str) spisok.RemoveAt(i);
                Value_objects.Text = spisok.Count.ToString();
                Del_name.Text = string.Empty;
            }
        }

        private void Show_one_object_Click(object sender, EventArgs e)
        {
            string str = Show_name.Text;
            if (string.IsNullOrWhiteSpace(str)) { MessageBox.Show("Вы ввели пустую строку"); }
            else
            {
                bool b = false;

                for (int i = 0; i < spisok.Count; i++)
                {
                    Ship temp = spisok[i];
                    string s = temp.Name;
                    if (s == str)
                    {
                        Show_name.Text = temp.Name;
                        Show_type.Text = temp.Type;
                        Show_country.Text = temp.Country;
                        Show_caliber.Text = temp.general_caliber.ToString();
                        b = true;
                    }

                }

                if (spisok.Count() == 0)

                    MessageBox.Show("Список элементов пуст");
                else if (!b) MessageBox.Show("Такого объекта нет");
            }
        }

        private void Show_all_objects_Click(object sender, EventArgs e)
        {
            Show_all_obj.Text = string.Empty;
            for (int i = 0; i < spisok.Count; i++)
            {
                Ship temp = spisok[i];
                string s = temp.Name;
                Show_all_obj.Text += s + "\r\n";
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            Show_all_obj.Text = Show_caliber.Text = Show_country.Text = Show_type.Text = Show_name.Text = Name_ship.Text = Type_ship.Text = Coutry.Text = General_caliber.Text = Del_name.Text = string.Empty;
        }
    }

}

