
using System;
namespace AbstractClass
{
    abstract class MotorBike
    {

        public abstract void brake();
    }

    class SportsBike : MotorBike
    {

        
        public override void brake()
        {
            Console.WriteLine("Sports Bike Brake");
        }

    }
    class MountainBike : MotorBike
    {

        
        public override void brake()
        {
            Console.WriteLine("Mountain Bike Brake");
        }

    }
}
