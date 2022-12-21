using System;

namespace DesignPatterns.Additional_Patterns
{
    public class SimpleFactory
    {
        //hiding implementation of instantiation of obj also others from client
        //object that creates another object or creates many prototypes
        //though its not in patterns but both factory as well as abstract factory both can be said as
        //this simple factory
        public void client()
        { 
            Creator Creator = new Creator();
            var animal = Creator.GetAnimal(); 
            animal.AnimalName();
        }
}

    public interface IAnimal
    {
        void AnimalName();
    }
    public class Dog:IAnimal{
        public void AnimalName()
        {
            Console.Write("Dog");

        }
    }
    public class Cat:IAnimal{
        public void AnimalName()
        {
            Console.Write("Cat");
        }
    }
    //Director -- creates an object of type main guy here
    public class Creator
    {
        public IAnimal GetAnimal()
        {
            IAnimal animal = null;
            var i = Console.Read();
            switch (i)
            {
                case 1:
                    animal = new Cat();
                    break;
                case 0:
                    animal = new Dog();
                    break;
                default:
                    animal = null;
                    break;
            }

            return animal;
        }
    }
}