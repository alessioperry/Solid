using System;

namespace LiskowSubstitution
{
    public abstract class Shape
    {
        public abstract double Area();
    }

    public class Rectangle : Shape
    {
        private readonly double width;
        private readonly double height;

        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        public double Width()
        {
            return width;
        }

        public double Height()
        {
            return height;
        }

        public override double Area()
        {
            return width * height;
        }
    }

    public class Circle : Shape
    {
        private readonly double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public Double Radius()
        {
            return radius;
        }

        public override double Area()
        {
            return radius * radius * Math.PI;
        }
    }
}