using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidProject
{
    public abstract class BeforeVehicle
    {
        public abstract void StartEngine();
        public abstract void StopEngine();
    }
    public class Car : BeforeVehicle
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
    public class ElectricCar : BeforeVehicle
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
