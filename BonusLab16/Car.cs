using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonusLab16
{
    class Car
    {
        private string carMake;
        private string carModel;
        private int carYear;
        private double carPrice;


        public string CarMake
        {
            set { carMake = value; }
            get { return carMake; }
        }

        public string CarModel
        {
            set { carModel = value; }
            get { return carModel; }
        }

        public int CarYear
        {
            set { carYear = value; }
            get { return carYear; }
        }

        public double CarPrice
        {
            set { carPrice = value; }
            get { return carPrice; }
        }
    }
}
