using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork
{
    public class Truck: ICar
    {
        public void Broke()
        {
            Console.WriteLine("Truck broken");
        }

        public void Ride()
        {
            Console.WriteLine("Truck ride");
        }
    }
}
