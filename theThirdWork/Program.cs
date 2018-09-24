using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 第三次作业
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle triangle1 = new Triangle(1.5,2.1);
            triangle1.getArea();
            circle circle1 = new circle(3.8);
            circle1.getArea();
            square square1 = new square(2.23);
            square1.getArea();
            rectangle rectangle1 = new rectangle(1.5, 2);
            rectangle1.getArea();
        }
    }
}
