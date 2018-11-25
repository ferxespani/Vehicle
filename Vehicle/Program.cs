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
            Vehicle v = new Lorry("Mazda", 1998, 567, "gray", 122);
            Vehicle d = new PassengerCar("Mazda", 1998, 455, "blue", 5);

            if (v.Equals(d))
                Console.WriteLine($"This vehicles:  !{v}! and !{d}! are equal");
            else
                Console.WriteLine("This vehicles are not equal");
        }
    }
}
