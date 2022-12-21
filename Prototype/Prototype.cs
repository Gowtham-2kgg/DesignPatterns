using System;

namespace DesignPatterns.Prototype
{
    public class Prototype
    {
    /*Instead of creating a new Instance using NEW keyword we can do copy or clone of existing one
     * by having subclasses for base class(which is abstract)
     *
     * challenges: making a copy is not easy and each subclass needs a clone
     *
     * pros:used in modifying and testing before modifying original one,
     * can add or delete functions,
     * provide same thing as new keyword
     * creates object without using new
     * */
    public void Function()
    {
        NanoPrototypeOne nanoPrototypeOne = new NanoPrototypeOne("nano");
        FordPrototypeOne fordPrototypeOne = new FordPrototypeOne("Ford");
        CarPrototypeBaseOne anotherNano = nanoPrototypeOne.Clone();
        CarPrototypeBaseOne anotherFord = fordPrototypeOne.Clone();
    }
    }

    public abstract class CarPrototypeBaseOne
    {
        protected int BasePrice { get; set; }
        protected string Model { get; set; }

        public static int GetAdditionalPrice()
        {
            return new Random().Next(0, 100);
        }

        public abstract CarPrototypeBaseOne Clone();
    }

    public class NanoPrototypeOne : CarPrototypeBaseOne
    {
        public NanoPrototypeOne(string m)
        {
            Model = m;
            BasePrice = 134;
        }

        public override CarPrototypeBaseOne Clone()
        {
            return this.MemberwiseClone() as NanoPrototypeOne;
        }
    }
    public class FordPrototypeOne : CarPrototypeBaseOne
    {
        public FordPrototypeOne(string m)
        {
            Model = m;
            BasePrice = 234;
        }

        public override CarPrototypeBaseOne Clone()
        {
            return this.MemberwiseClone() as FordPrototypeOne;
        }
    }
    // option 2 we can go by having another thing
    public class CarFactoryOne
    {
        private FordPrototypeOne FordPrototypeOne { set; get; }
        private NanoPrototypeOne NanoPrototypeOne { set; get; }

        public CarFactoryOne()
        {
            FordPrototypeOne = new FordPrototypeOne("Ford");
            NanoPrototypeOne = new NanoPrototypeOne("Nano");
        }

        public CarPrototypeBaseOne GetFordClone()
        {
            return FordPrototypeOne.Clone();
        }
        public CarPrototypeBaseOne GetNanoClone()
        {
            return NanoPrototypeOne.Clone();
        }
    }
    //Slight modification
    public class CarFactoryTwo
    {
        private FordPrototypeOne FordPrototypeOne { set; get; }
        private NanoPrototypeOne NanoPrototypeOne { set; get; }

        public CarPrototypeBaseOne GetFordClone()
        {
            if (FordPrototypeOne == null)
            {
                FordPrototypeOne = new FordPrototypeOne("Ford");
            }

            return FordPrototypeOne.Clone();
        }
        public CarPrototypeBaseOne GetNanoClone()
        {
            if (NanoPrototypeOne == null)
            {
                NanoPrototypeOne = new NanoPrototypeOne("Nano");
            }
            return NanoPrototypeOne.Clone();
        }
    }
    //Deep copy vs Shallow copy
    //In shallow copy non static fields are copied using bit by bit in case of object and ref in case of ref
}