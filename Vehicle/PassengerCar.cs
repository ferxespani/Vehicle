using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle
{
    public class PassengerCar : Vehicle, IGetMaxNumberPassengers
    {
        private int MaxNumberPassengers { get; }

        const int Month = 8;
        const int SpecialDiscount = 50;
        int month;

        public PassengerCar(string model, int yearOfIssue, int price, string color) : base(model, yearOfIssue, price, color)
        {
        }

        public PassengerCar(string model, int yearOfIssue, int price, int maxNumberPassengers) : this(model, yearOfIssue, price, "green")
        {
            MaxNumberPassengers = maxNumberPassengers;
        }

        public int GetMonth()
        {
            month = int.Parse(Console.ReadLine());
            return month;
        }

        public override int getPriceSale()
        {
            int month = GetMonth();
            if (month != Month)
            {
                return Price - (Price / 100 * 10) + 2 * month;
            }
            else
                return Price - (Price / 100 * SpecialDiscount);
        }

        public int GetMaxNumberPassengers()
        {
            return MaxNumberPassengers;
        }
    }
}
