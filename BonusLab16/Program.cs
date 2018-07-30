using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BonusLab16
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] header = { "Make", "Model", "Year", "Price" };
            List<Car> CarList = new List<Car>();

           

            while (true)
            {
                Car temp = new Car();

                Console.WriteLine("Please provide the following information:");
                
                temp.CarMake = ValidateCarMake();

                temp.CarModel = ValidateCarModel();

                temp.CarYear = ValidateCarYear();

                temp.CarPrice = ValidateCarPrice();
                
                CarList.Add(temp);

                Console.WriteLine("Do you want to add additional car information?");
                string choice = Console.ReadLine();
                if (choice == "no")
                {
                    break;
                }
            
            }
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine($"{header[0], -15}{header[1],-15}{header[2],-15}{header[3],-15}");
            Console.WriteLine("-------------------------------------------------------");
            foreach (Car cars in CarList)
            {
                
                Console.Write($"{cars.CarMake, -15}");
                Console.Write($"{cars.CarModel, -15}");
                Console.Write($"{cars.CarYear, -15}");
                Console.WriteLine($"{cars.CarPrice:C}");

            }
        }

        public static string ValidateCarMake()
        {
            while (true)
            {

                Console.WriteLine("Make of car:");
                string carMake = Console.ReadLine();
                if (Regex.IsMatch(carMake, @"^[A-Za-z]{0,20}$"))
                {
                    return carMake;
                }
                
            }
        }
        public static string ValidateCarModel()
        {
            while (true)
            {

                Console.WriteLine("Model of car:");
                string carModel = Console.ReadLine();
                if (Regex.IsMatch(carModel, @"^[A-Za-z0-9]{0,20}$"))
                {
                    return carModel;
                }

            }
        }

        public static int ValidateCarYear()
        {
            while (true)
            {

                Console.WriteLine("Year of car:");
                int carYear = int.Parse(Console.ReadLine());
                if (Regex.IsMatch(carYear.ToString(), @"^[0-9]{2,4}$"))
                {
                    return carYear;
                }

            }
        }

        public static double ValidateCarPrice()
        {
            while (true)
            {

                Console.WriteLine("Price of car:");
                double carPrice = double.Parse(Console.ReadLine());
                if (Regex.IsMatch(carPrice.ToString(), @"^[0-9]{0,7}.[0-9]{0,2}$"))
                {
                    return carPrice;
                }

            }
        }
    }
}
