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
            Vehicle k = new PassengerCar("Mazda", 1998, 455, "blue", 5);

            if (v.Equals(k))
                Console.WriteLine($"This vehicles:  !{v}! and !{k}! are equal");
            else
                Console.WriteLine("This vehicles are not equal");
        }
    }
}
