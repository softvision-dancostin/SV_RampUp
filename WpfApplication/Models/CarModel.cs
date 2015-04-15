using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication.Models
{
    public class CarModel
    {
        private int carID;
        private string make;
        private string color;
        private string petName;

        public int CarID
        {
            get { return carID; }
            set { carID = value; }
        }
        public string Make
        {
            get { return make; }
            set { make = value; }
        }
        public string Color
        {
            get { return color; }
            set { color = value; }
        }
        public string PetName
        {
            get { return petName; }
            set { petName = value; }
        }

    }
}
