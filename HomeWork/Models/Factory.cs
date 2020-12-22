using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork.Models
{
    public enum CarType
    {
        Bus,
        Tractor,
        Truck
    }

    public interface ICarFactory
    {
        public ICar CreateCar(CarType type);
    }

    public class CarFactory : ICarFactory
    {
        public ICar CreateCar(CarType type)
        {
            switch (type)
            {
                case CarType.Bus:
                    return new Bus();
                case CarType.Tractor:
                    return new Tractor();
                case CarType.Truck:
                    return new Truck();
                default:
                    return new Tractor();
            }
        }
    }


}
