using System;

namespace DesignPatterns.AbstractFactory
{
    public class AbstractFactory
    {
        //Little bit complex than actual factory
        //can be also called factories of factories
        //classes are not directly instantiated
        public static void Example()
        {
            var actualFactory = new ActualFactory();
            IAnimalFactory animalFactory = ActualFactory.AnimalFactory("pet");
        }
    }

    //following example might be good
    public interface ITiger
    {
        void Type();
    }

    public interface IDog
    {
        void Type();
    }

    public interface IAnimalFactory
    {
        ITiger Tiger();
        IDog Dog();
    }

    public class PetTiger : ITiger
    {
        public void Type()
        {
            Console.Write("PetTiger");
        }
    }
    public class PetDog : IDog
    {
        public void Type()
        {
            Console.Write("PetDog");

        }
    }
    public class WildTiger : ITiger
    {
        public void Type()
        {
            Console.Write("WildTiger");
        }
    }
    public class WildDog : IDog
    {
        public void Type()
        {
            Console.Write("WildDog");

        }
    }

    public class WildAnimal : IAnimalFactory
    {
        public ITiger Tiger()
        {
            return new WildTiger();
        }

        public IDog Dog()
        {
            return new WildDog();
        }
    }
    public class PetAnimal : IAnimalFactory
    {
        public ITiger Tiger()
        {
            return new PetTiger();
        }

        public IDog Dog()
        {
            return new PetDog();
        }
    }

    public class ActualFactory
    {
        public static IAnimalFactory AnimalFactory(string m)
        {
            switch (m)
            {
                case "pet":
                    return new PetAnimal();
                case "wild":
                    return new WildAnimal();
            }

            return null;
        }
    }
}