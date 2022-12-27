using System;

namespace DesignPatterns.Additional_Patterns.NullableFactory
{
    public class NullFactory
    {
        //To avoid null checks and expressions these kind of patterns are useful
        private void Function()
        {
            var vehicle = Console.ReadLine();
            IVehicle vehicleWeWant = null;
            switch (vehicle)
            {
                case "car":
                    vehicleWeWant = new Car();
                    break;
                case "bike":
                    vehicleWeWant = new Bike();
                    break;
                default:
                    vehicleWeWant = new NullAble();
                    break;
            }
            vehicleWeWant.Name();
            
        }
    }

    public interface IVehicle
    {
        public void Name();
    }
    public class Bike:IVehicle{
        public void Name()
        {
            Console.WriteLine("Bike");
        }
    }
    public class Car:IVehicle{
        public void Name()
        {
            Console.WriteLine("Bike");
        }
    }

    public class NullAble : IVehicle
    {
        private int _nullableCount = 0;

        public NullAble()
        {
            _nullableCount++;
        }

        public void Name()
        {
            //Do nothing
        }
    }
}