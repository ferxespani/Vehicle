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
            Vehicle k = new PassengerCar("Mazda", 1998, 455, 5);
            Console.WriteLine(k);
        }
    }
}
