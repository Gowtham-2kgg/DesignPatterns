using System;

namespace DesignPatterns.Structural.Bridge
{
    public class Bridge
    {
        //separating abstraction from its implementation
        public void Example()
        {
            Electronics electronics = new BridgeProductCar();
            electronics.Price = new ShowRoom();
            electronics.ProdType = "car";
            electronics.Details();
        }
}

    public abstract class Electronics
    {
        public IPrice Price;
        public string ProdType;
        public abstract void Details();
    }

    public class BridgeProductCar:Electronics
    {
        
        public override void Details()
        {
            Price.Price(ProdType);
        }
    }

    public interface IPrice
    {
        void Price(string m);
    }

    public class ShowRoom : IPrice
    {
        public void Price(string m)
        {
            Console.WriteLine($"{m} is rs 10000");
        }
    }
    public class Online : IPrice
    {
        public void Price(string m)
        {
            Console.WriteLine($"{m} is rs 10100");

        }
    }

    public interface IDetails
    {
        public string Name {
        get;
        set;
    }

    void Discount();
        void Price();
    }

    public class Sofa : IDetails
    {
        public string Name { get; set; }

        public void Discount()
        {
            Console.WriteLine($"{Name} is 1000 off");
        }

        public void Price()
        {
            Console.WriteLine($"{Name} is 100000 ");
        }
    }

    public class Furniture
    {
        public IDetails Details;

        public Furniture(IDetails details)
        {
            this.Details = details;
        }

        public void Attributes()
        {
            Details.Discount();
            Details.Price();
        }
    }

}