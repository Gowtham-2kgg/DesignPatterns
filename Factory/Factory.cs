using System;
using DesignPatterns.Additional_Patterns;

namespace DesignPatterns.Factory
{
    public class Factory
    {
        //Sub classes defines which class is to initiated
        //it involves a interface which will be get implemented by sub classes whose 
        //object will be created
        //Involves one abstract class which used in creating those object
        //pros:separation of code and not tightly coupled
        //cons:affects performance
        public void Client()
        {
            TigerFactory tigerFactory = new TigerFactory();
            LionFactory lionFactory = new LionFactory();
            CheetahFactory cheetahFactory = new CheetahFactory();
            var tiger = tigerFactory.GetAnimal();
            var lion = lionFactory.GetAnimal();
            var cheetah = cheetahFactory.GetAnimal();
        }
    }

    public interface IAnimals
    {
        void AnimalName();
    }

    public class Tiger : IAnimals
    {
        public void AnimalName()
        {
            Console.Write("Tiger");

        }
    }
    public class Lion : IAnimals
    {
        public void AnimalName()
        {
            Console.Write("Lion");
        }
    }
    public class Cheetah : IAnimals
    {
        public void AnimalName()
        {
            Console.Write("Cheetah");

        }
    }

    public abstract class AnimalFactory
    {
        public abstract IAnimals GetAnimal();
    }

    public class TigerFactory : AnimalFactory
    {
        public override IAnimals GetAnimal()
        {
            return new Tiger();
        }
    }
    public class LionFactory : AnimalFactory
    {
        public override IAnimals GetAnimal()
        {
            return new Lion();
        }
    }
    public class CheetahFactory : AnimalFactory
    {
        public override IAnimals GetAnimal()
        {
            return new Cheetah();
        }
    }

}