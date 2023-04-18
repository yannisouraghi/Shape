using Shape.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{   
    class Program
    {
        private static void Main(string[] args)
        {
            Circle obj = new Circle();
            obj.Radius = 3;
            AreaCalculator calc = new AreaCalculator();
            Console.WriteLine("Cercle : " + obj.Area());

            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

            Rectangle obj2 = new Rectangle();
            obj2.Height = 5;
            obj2.Wight = 10;
            Console.WriteLine("Rectangle : " + obj2.Area());

            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

            Square obj3 = new Square();
            obj3.Wight = 5;
            Console.WriteLine("Carré : " + obj3.Area());

            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

            Triangle obj4 = new Triangle();
            obj4.triangleBase = 2;
            obj4.triangleHauteur = 4;
            Console.WriteLine("Triangle : " + obj4.Area());

            Console.ReadLine();
        }

    }
   
}
