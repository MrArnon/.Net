using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Polyakov_lab_1
{
    class Ship
    {
        // private string Name, Type, Country;
        public string Name { get; }
        public string Type { get; }
        public string Country { get; }
        private int General_caliber;
        public int general_caliber { get; }
        public Ship()
        {
            Name = string.Empty;
            Type = string.Empty;
            Country = string.Empty;
            General_caliber = 0;
        }
        public Ship(string name, string type, string country, int general_caliber)
        {
            Name = name;
            Type = type;
            Country = country;
            General_caliber = general_caliber;
        }
        public Ship(string name, string type, string country, string general_caliber)
        {
            Name = name;
            Type = type;
            Country = country;
            try
            {

                General_caliber = Convert.ToInt32(general_caliber);
            }
            catch (Exception e) { MessageBox.Show(e.Message); }
        }


    }
}

