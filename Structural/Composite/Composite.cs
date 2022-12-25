using System;
using System.Collections.Generic;

namespace DesignPatterns.Structural.Composite
{
    public class Composite
    {
        //Just to maintain hierarchy
        
        
        //do stuff here
    }

    public interface IEmployee
    {
         string Name { get; set; }
         string Designation { get; set; }
         int Age { get; set; }
    }

    public class Employee : IEmployee
    {
        public string Name { get; set; }
        public string Designation { get; set; }
        public int Age { get; set; }

        public Employee(string name, string designation, int age)
        {
            Name = name;
            Designation = designation;
            Age = age;
        }

        public void DisplayEmployee()
        {
            Console.WriteLine($"Age:{Age},Designation:{Designation},Name:{Name}");
        }
    }
    //interface not mandatory below
    public class CompositeEmployee:IEmployee{
        public string Name { get; set; }
        public string Designation { get; set; }
        public int Age { get; set; }
        private List<IEmployee> _list = new List<IEmployee>();

        public void AddEmployee(IEmployee e)
        {
            _list.Add(e);
        }

        public void RemoveEmployee(IEmployee e)
        {
            if (_list.Contains(e))
            {
                _list.Remove(e);
            }
        }
        
    }
}