using System;

namespace DesignPatterns.Behaviour_Patterns.Strategy
{
    public class Strategy
    {
        //Implements a list of algorithm and encapsulate them and client can access any of it
    }

    public interface IProperty
    {
        void AboutMe();
    }

    public class Initial : IProperty
    {
        public void AboutMe()
        {
            Console.WriteLine("can run on road");
        }
    }
    public class Float : IProperty
    {
        public void AboutMe()
        {
            Console.WriteLine("can float on water");
        }
    }
    public class Fly : IProperty
    {
        public void AboutMe()
        {
            Console.WriteLine("can fly in air");
        }
    }

    public interface IVehicle
    {
        void Details();
    }

    public class Vehicle : IVehicle
    {
        private IProperty _Property { get; set; }

        public  Vehicle()
        {
            _Property = new Initial();
        }

        public void ChangeProp(IProperty property)
        {
            _Property = property;
        }

        public void Details()
        {
            _Property.AboutMe();
        }
    }

}