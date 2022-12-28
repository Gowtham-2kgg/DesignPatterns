using System;

namespace DesignPatterns.Structural.Adapter
{
    public class Adapter
    {
        //conversion of interface to client.. classes needs to be together
        public void Example()
        {
            IRectangle rectangle = new Rectangle(12, 1);
            ITriangle triangle = new Triangle(123, 23);
            RectangleAdapter rectangleAdapter = new RectangleAdapter(triangle);
            rectangle.About();
            rectangle.Area();
            triangle.AreaOfTriangle();
            triangle.TriangleInfo();
            rectangleAdapter.About();
            rectangleAdapter.Area();
        }
    }

    public interface IRectangle
    {
        void About();
        void Area();
    }

    public class Rectangle : IRectangle
    {
        private int _length { get; }
        private int _height { get; }

        public Rectangle(int length, int height)
        {
            _length = length;
            _height = height;
        }

        public void About()
        {
            Console.WriteLine("I'm a Rectangle");
        }

        public void Area()
        {
            Console.WriteLine($"{2*(_length*_height)}");
        }
    }

    public interface ITriangle
    {
        void AreaOfTriangle();
        void TriangleInfo();
    }

    public class Triangle : ITriangle
    {
        private int _length { get; }
        private int _height { get; }
        
        public Triangle(int length, int height)
        {
            _length = length;
            _height = height;
        }
        public void AreaOfTriangle()
        {
            Console.WriteLine($"{(0.5)*(_length*_height)}");
        }

        public void TriangleInfo()
        {
            Console.WriteLine("I'm a Triangle");
        }
    }

    //Inheritance can be include Triangle also to extend its properties
    /*
     *public class RectAdap:IRectangle,Trianlge{}
     * 
     */
    public class RectangleAdapter : IRectangle
    {
        private ITriangle _triangle;

        public RectangleAdapter(ITriangle triangle)
        {
            _triangle = triangle;
        }

        public void About()
        {
            _triangle.TriangleInfo();
        }

        public void Area()
        {
            _triangle.AreaOfTriangle();
        }
    }
}