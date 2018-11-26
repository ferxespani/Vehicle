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

        public PassengerCar(string model, int yearOfIssue, int price, string color) : base(model, yearOfIssue, price, color)
        {
        }

        public PassengerCar(string model, int yearOfIssue, int price, int maxNumberPassengers) : this(model, yearOfIssue, price, "green")
        {
            MaxNumberPassengers = maxNumberPassengers;
        }

        public int GetMaxNumberPassengers()
        {
            return MaxNumberPassengers;
        }
    }
}
