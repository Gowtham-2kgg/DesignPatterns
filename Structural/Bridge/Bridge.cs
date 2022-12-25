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

}