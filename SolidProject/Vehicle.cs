using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidProject
{
    public abstract class Vehicle
    {
        public abstract void StartEngine();
        public abstract void StopEngine();
    }
    public class Car : Vehicle
    {
        public override void StopEngine()
        {
            Console.WriteLine("stoping the car engine");
        }

        public override void StartEngine()
        {
            Console.WriteLine("starting the car engine");
        }
    }
    public class ElectricCar : Vehicle
    {
        public override void StopEngine()
        {
            throw new InvalidOperationException("ElectricCars do not have Engine");
        }

        public override void StartEngine()
        {
            throw new InvalidOperationException("ElectricCars do not have Engine");
        }
    }
}
