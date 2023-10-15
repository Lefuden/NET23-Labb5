using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb5
{
    internal class Geometry
    {
        //the names don't make much sense after adding all kinds of shapes. but naming them eg "_x _y _z" makes it harder to read, so i'm keeping it.
        private float _radius;
        private float _height;
        private float _width;

        //constructor overloading since different shapes don't require the same amount of data.
        public Geometry(float radius)
        {
            _radius = radius;
        }

        public Geometry(float radius, float height)
        {
            _radius = radius;
            _height = height;
        }

        public Geometry(float radius, float height, float width)
        {
            _radius = radius;
            _height = height;
            _width = width;
        }

        //methods for different calculations. a couple notes: Math.Round() to limit amount of decimals.
        //Math.PI is used instead of adding a variable for pi. Math.Sqrt() for square root. Math.Pow() for 'to the power of'.
        //I probably went a bit overboard here.
        public void CalculateCircle()
        {
            Console.WriteLine($"Diameter of circle: {Math.Round(_radius * 2, 2)}");
            Console.WriteLine($"Circumference of circle: {Math.Round(Math.PI * _radius * 2, 2)}");
            Console.WriteLine($"Area of circle: {Math.Round(Math.PI * Math.Pow(_radius, 2), 2)}\n");
        }

        public void CalculateSphere()
        {
            Console.WriteLine($"Area of sphere: {Math.Round(4 * Math.PI * Math.Pow(_radius, 2), 2)}");
            Console.WriteLine($"Volume of sphere: {Math.Round(Math.PI * 4 * Math.Pow(_radius, 3) / 3, 2)}\n");
        }

        public void CalculateTriangle()
        {
            Console.WriteLine($"Perimeter of triangle: {Math.Round(_radius + _height + _width, 2)}");
            Console.WriteLine($"Area of triangle: {Math.Round(_radius * _height / 2, 2)}\n");
        }

        public void CalculateCylinder()
        {
            Console.WriteLine($"Area of cylinder: {Math.Round(2 * Math.PI * _radius * _height + 2 * Math.PI * Math.Pow(_radius, 2), 2)}");
            Console.WriteLine($"Mantle of cylinder: {Math.Round(2 * Math.PI * _radius * _height, 2)}");
            Console.WriteLine($"Volume of cylinder: {Math.Round(Math.PI * Math.Pow(_radius, 2) * _height, 2)}\n");
        }

        public void CalculateRectangle()
        {
            Console.WriteLine($"Diameter of rectangle: {Math.Round(Math.Sqrt(Math.Pow(_radius, 2) + Math.Pow(_height, 2)), 2)}");
            Console.WriteLine($"Perimeter of rectangle: {Math.Round((_radius + _height) * 2, 2)}");
            Console.WriteLine($"Area of rectangle: {Math.Round(_radius * _height, 2)}\n");
        }
    }
}