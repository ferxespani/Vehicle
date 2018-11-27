using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle
{
    class Lorry : Vehicle, IGetLoadCapacity
    {
        private int MaxCapacity { get; }

        public Lorry(string model, int yearOfIssue, int price, string color, int maxCapacity) : base(model, yearOfIssue, price, color)
        {
            MaxCapacity = maxCapacity;
        }

        public int GetLoadCapacity()
        {
            return MaxCapacity;
        }

        public void GetMileage(int MileAge = 0)
        {
            Console.WriteLine($"MileAge is: {MileAge}");
        }
    }
}
