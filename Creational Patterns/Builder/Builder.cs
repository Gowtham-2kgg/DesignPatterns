using System;
using System.Collections.Generic;

namespace DesignPatterns.Creational_Patterns.Builder
{
    public class Builder
    {
        //Creating subcomponents of the system such a way they are independent on each other
        //Building complex component bit by bit
        //Return different object with different behaviour
        //pros: can create diff object using same method, encapsulation, internal rep of produt
        //cons: duplicate code, not suit in mutable stuff
        private void Example()
        {
            Director director = new Director();
            IBuilder bike = new Bike("Bike");
            IBuilder cycle = new Cycle("Cycle");
            var prodBike=director.Construct(bike);
            var prodCycle=director.Construct(cycle);
        }
    }

    public interface IBuilder
    {
        void CreateProduct();
        void MarketProduct();
        void SellProduct();
        void Register();
        Product GetProduct();
    }

    public class Product
    {
        public List<string> Process = new List<string>();
        public string Name;

        public void ShowName()
        {
            Console.Write(Name);
        }
    }

    public class Cycle : IBuilder
    {
        private Product _cycle;

        public Cycle(string m)
        {
            this._cycle = new Product();
            this._cycle.Name = m;
        }

        public void CreateProduct()
        {
            this._cycle.Process.Add("Create Cycle");
        }

        public void MarketProduct()
        {
            this._cycle.Process.Add("Market Cycle");
        }

        public void SellProduct()
        {
            this._cycle.Process.Add("Sell Cycle");
        }

        public void Register()
        {
            this._cycle.Process.Add("Register Cycle");
        }

        public Product GetProduct()
        {
            return this._cycle;
        }
    }
    public class Bike : IBuilder
    {
        private Product _bike;

        public Bike(string m)
        {
            this._bike = new Product();
            this._bike.Name = m;
        }

        public void CreateProduct()
        {
            this._bike.Process.Add("Create Bike");
        }

        public void MarketProduct()
        {
            this._bike.Process.Add("Market Bike");
        }

        public void SellProduct()
        {
            this._bike.Process.Add("Sell Bike");
        }

        public void Register()
        {
            this._bike.Process.Add("Register Bike");
        }

        public Product GetProduct()
        {
            return this._bike;
        }
    }

    public class Director
    {
        private IBuilder _builder;

        public Product Construct(IBuilder builder)
        {
            this._builder = builder;
            _builder.CreateProduct();
            _builder.MarketProduct();
            _builder.SellProduct();
            _builder.Register();
            return _builder.GetProduct();
            
        }
    }
}