using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 第三次作业
{
    class Shape
    {
        static double area;
        public void getArea()
        {
            Console.WriteLine("The area of this shape is zero ");
        }
    }

    class Triangle : Shape
    {
        static double a;
        static double h;
        public Triangle(double q, double w)
        {
            a = q;
            h = w;
        }
        new public void getArea()
        {
            double area = 0.5 * a * h;
            Console.WriteLine("The area of this shape is: " + area);
        }
    }

    class circle : Shape
    {
        static double r;
        public circle(double q)
        {
            r = q;
        }
        new public void getArea()
        {
            double area = 3.14 * r * r;
            Console.WriteLine("The area of this shape is: " + area);
        }
    }
    class square : Shape
    {
        static double a;
        public square(double q)
        {
            a = q;
        }
        new public void getArea()
        {
            double area = a * a;
            Console.WriteLine("The area of this shape is: " + area);
        }
       
    }
    class rectangle : Shape
    {
        static double a, b;
        public rectangle(double q, double w)
        {
            a = q;
            b = w;
        }
        new public void getArea()
        {
            double area = a * b;
            Console.WriteLine("The area of this shape is: " + area);
        }
    }

}
