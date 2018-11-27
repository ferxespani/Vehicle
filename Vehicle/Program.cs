using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle
{
    class Program
    {
        static void Main(string[] args)
        {
            var car1 = new PassengerCar("Mazda", 1998, 300, 5);
            var car2 = new Lorry("Mazda", 1994, 455, "blue", 345);

            int Price = car1.getPriceSale();

            car2.GetMileage(MileAge: 198);    
            
            Console.WriteLine(Price);
            Vehicle.GetAmountOfCars();

            if (car1 < car2)
                Console.WriteLine("True");
            else
                Console.WriteLine("False");

            int n1 = car1.GetAgeOfVehicle();
            int n2 = car2.GetAgeOfVehicle();
            Console.WriteLine($"{n1}    {n2}");
        }
    }

    public static class DateTimeExtention
    {
        public static int Age(this DateTime date)
        {
            return DateTime.Now.Year - date.Year;
        }
    }
}
