using System;

namespace DesignPatterns.Structural.Decorator
{
    public class Decorator
    {
        //Dynamically add functionality without inheritance using composition
        //Also called as wrapper pattern
        //pros: add functionality without change,  no bugs invented in class and follows SOLID concept
    }

    public abstract class AbstractHome
    {
        public int AdditionalPrice = 0;
        public abstract void TotalCost();
    }

    public class ActualHome : AbstractHome
    {
        public override void TotalCost()
        {
            AdditionalPrice = 0;
            Console.WriteLine("Total cost is 1000000");
        }
    }

    public abstract class AbstractDecorator : AbstractHome
    {
        private AbstractHome _home;

        protected AbstractDecorator(AbstractHome home)
        {
            this._home = home;
        }

        public override void TotalCost()
        {
            _home.TotalCost();
        }
        
    }

    public class PaintHome : AbstractDecorator
    {
        public PaintHome(AbstractHome home) : base(home)
        {
        }
        
        public override void TotalCost()
        {
            base.TotalCost();
            Paint();
        }

        private void Paint()
        {
            base.AdditionalPrice = 1000;
            Console.WriteLine("additional cost is"+$"{AdditionalPrice}");
        }
    }
    public class LayTiles : AbstractDecorator
    {
        public LayTiles(AbstractHome home) : base(home)
        {
        }
        
        public override void TotalCost()
        {
            base.TotalCost();
            Tiles();
        }

        private void Tiles()
        {
            base.AdditionalPrice = 1200;
            Console.WriteLine("additional cost is"+$"{AdditionalPrice}");
        }
    }
}