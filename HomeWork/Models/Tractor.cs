using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork
{
    public class Tractor : ICar
    {
        public void Broke()
        {
            Console.WriteLine("Tractor broken");
        }

        public void Ride()
        {
            Console.WriteLine("Tractor ride");
        }
    }
}
