using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle
{
    public partial class Vehicle
    {
        private string Model { get; }
        private int YearOfIssue { get; }
        private int Price { get; }
        private string Color { get; }

        public Vehicle(string model, int yearOfIssue, int price, string color)
        {
            Model = model;
            YearOfIssue = yearOfIssue;
            Price = price;
            Color = color;
        }

        public int getPriceSale()
        {
            return Price - (Price / 100 * 10);
        }
    }

    public partial class Vehicle
    {
        public override string ToString()
        {
            return "Vehicle: " + " " + Model + " " + YearOfIssue + " " + Price + " " + Color;
        }

        public bool Equals(Vehicle v)
        {
            if (Model == v.Model && YearOfIssue == v.YearOfIssue)
                return true;
            else
                return false;
        }
    }
}
