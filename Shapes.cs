using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tsystem_Day4_Assignments
{
    abstract public class Shapes
    {
        abstract public void CalculateArea();
    }

    public class Circle : Shapes,Iprintable
    {
        private int radius;
        private double result, PI = 3.14;

        public Circle(int radius)
        {
            this.radius = radius;

        }
        public override void CalculateArea()
        {
            result = PI * radius * radius;
           
        }

        public string Print()
        {
            return "area of the circle " + result;
        }

        public override string ToString()
        {
            return "area of the circle is : " + result;
        }

    }
    public class Rectangle : Shapes
    {
        private int width;
        private int length;
        private double result;

        public Rectangle(int width,int length)
        {
            this.width = width;
            this.length = length;

        }

        public override void CalculateArea()
        {
            result = width * length ;
           
        }
        public override string ToString()
        {
            return "area of the rectangle is : " + result;
        }
    }
    public class Square : Shapes
    {
        private int width;
        private double result;

        public Square(int width)
        {
            this.width = width;
            

        }
        public override void CalculateArea()
        {
            result = width * width;

        }
        public override string ToString()
        {
            return "area of the Square is : " + result;
        }
    }
}
