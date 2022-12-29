using System;

namespace DesignPatterns.Structural.Facade
{
    public class Facade
    {
        //unified interface to a set of interface
        //loosely couples and high level system
        //class makes use of subclasses
    }

    public class RobotBuilder
    {
        public void CreateRobot()
        {
            Console.WriteLine("Robot Created");
        }

        public void DestroyRobot()
        {
            Console.WriteLine("Robot Destroyed");
        }
    }
    public class RobotColor
    {
        public void ApplyColor()
        {
            Console.WriteLine("Color Applied");
        }

        public void RemoveColor()
        {
            Console.WriteLine("Color Removed");
        }
    }

    public class RobotCreation
    {
        private RobotCreation _robotCreation;
        private RobotColor _robotColor;

        public RobotCreation()
        {
            _robotColor = new RobotColor();
            _robotCreation = new RobotCreation();
        }

        public void Create()
        {
            _robotCreation.Create();
            _robotColor.ApplyColor();
        }

        public void Destroy()
        {
            _robotColor.RemoveColor();
            _robotCreation.Destroy();
        }
    }
}