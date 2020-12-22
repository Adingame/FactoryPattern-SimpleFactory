using System;
using System.Collections.Generic;
using System.Data;
using System.IO;

namespace HomeWork
{
    class Program
    {
        static void Main()
        {
            //Из за переопределение метода они будут показывает разные значения
            Truck bestTruck = new Truck();

            bestTruck.Broke();

            Tractor bestTractor = new Tractor();

            bestTractor.Broke();
        }
    }
}
