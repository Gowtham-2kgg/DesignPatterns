using System;
using System.Collections.Generic;

namespace DesignPatterns.Structural.FlyWeight
{
    public class FlyWeight
    {
        //used in creating pool of object which are similar but not same
        public void Example()
        {
            FlyWeightPattern weightPattern = new FlyWeightPattern();
            for (int i = 0; i < 10; i++)
            {
                var car = weightPattern.GetVehicle("car");
            }
            for (int i = 0; i < 10; i++)
            {
                var bike = weightPattern.GetVehicle("bike");
            }
            for (int i = 0; i < 10; i++)
            {
                var cycle = weightPattern.GetVehicle("cycle");
            }
        }
    }

    public interface IVehicle
    {
        void Type();
    }

    public class Car : IVehicle
    {
        public void Type()
        {
            Console.Write("I'm car");
        }
    }
    public class Cycle : IVehicle
    {
        public void Type()
        {
            Console.Write("I'm cycle");
        }
    }
    public class Bike : IVehicle
    {
        public void Type()
        {
            Console.Write("I'm bike");
        }
    }

    public class FlyWeightPattern
    {
        public Dictionary<string, IVehicle> Vehicles = new Dictionary<string, IVehicle>();

        public IVehicle GetVehicle(string m)
        {
            IVehicle vehicle = null;
            if (Vehicles.ContainsKey(m))
            {
                return Vehicles[m];
            }
            else
            {
                switch (m)
                {
                    case "car":
                        vehicle = new Car();
                        Vehicles.Add("car",vehicle);
                        break;
                    case "bike":
                        vehicle = new Bike();
                        Vehicles.Add("bike",vehicle);
                        break;
                    case "cycle":
                        vehicle = new Cycle();
                        Vehicles.Add("cycle",vehicle);
                        break;
                    default:
                        vehicle = null;
                        break;
                }

                return vehicle;
            }

            return null;
        }
    }
}