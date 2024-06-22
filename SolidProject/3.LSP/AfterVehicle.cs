using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidProject
{
    public abstract class L_Vehicle
    {
        //Common vehicle behavior and properties
    }

    public interface IEnginePowered
    {
         void StartEngine();
         void StopEngine();
    }
    public class L_Car : L_Vehicle, IEnginePowered
    {
        public void StopEngine()
        {
            Console.WriteLine("stoping the car engine");
        }

        public void StartEngine()
        {
            Console.WriteLine("starting the car engine");
        }
    }
    public class L_ElectricCar : L_Vehicle
    {
       //specific behavior for electric Car
    }
}
