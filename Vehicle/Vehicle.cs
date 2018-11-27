using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle
{
    public abstract partial class Vehicle
    {
        protected string Model;
        protected int YearOfIssue;
        protected int Price;
        protected string Color;
        protected static int AmountOfCars = 0;
        protected readonly int Discount;
        protected DateTime d;


        public Vehicle(string model, int yearOfIssue, int price, string color)
        {
            Model = model;
            d = new DateTime(yearOfIssue, 1, 1, 0, 0, 0);
            YearOfIssue = yearOfIssue;
            Price = price;
            Color = color;
            Discount = 10;
            ++AmountOfCars;
        }

        public virtual int getPriceSale()
        {
            return Price - (Price / 100 * Discount);
        }

        public int GetAgeOfVehicle()
        {
            int n = DateTimeExtention.Age(d);
            return n;
        }

        public static void GetAmountOfCars()
        {
            Console.WriteLine($"Amount of Cars: {AmountOfCars} ");
        }

        public override bool Equals(object obj)
        {
            if (obj is Vehicle v)
            {
                if (v.Model == Model && v.YearOfIssue == YearOfIssue && v.Price == Price && v.Color == Color)
                    return true;
                else
                    return false;
            }
            else
                return false;
        }
    }

    public abstract partial class Vehicle
    {
        public override string ToString()
        {
            return "Vehicle: " + " " + Model + " " + YearOfIssue + " " + Price + " " + Color;
        }

        public static bool operator <(Vehicle v1, Vehicle v2)
        {
            if (v1.Price < v2.Price)
                return true;
            else
                return false;
        }

        public static bool operator >(Vehicle v1, Vehicle v2)
        {
            if (v1.Price > v2.Price)
                return true;
            else
                return false;
        }
    }
}
