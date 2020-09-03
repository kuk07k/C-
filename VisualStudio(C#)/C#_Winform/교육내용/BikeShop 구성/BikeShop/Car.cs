using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace BikeShop
{
    public class Human
    {
        public string FirstName { get; set; }
        public bool HasDrivingLicense { get; set; }
    }
    public class Car
    {
        public double Speed { get; set; } // get, set은 속성(값을 가져오고, 값을 집어넣고)
        public Color color { get; set; } 
        public Human Driver { get; set; }
    }
}
