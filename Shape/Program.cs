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
            obj.Radius = 9;
            AreaCalculator calc = new AreaCalculator();
            Console.WriteLine("Cercle : " + calc.TotalArea(new object[] { obj }));

            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

            Rectangle obj2 = new Rectangle();
            obj2.Height = 4;
            obj2.Wight = 18;
            Console.WriteLine("Rectangle : " + calc.TotalArea(new object[] { obj2 }));

            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

            Square obj3 = new Square();
            obj3.Wight = 14;
            Console.WriteLine("Carré : " + calc.TotalArea(new object[] { obj3 }));

            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

            Triangle obj4 = new Triangle();
            obj4.triangleBase = 13;
            obj4.triangleHauteur = 11;
            Console.WriteLine("Triangle : " + calc.TotalArea(new object[] { obj4 }));

            Console.ReadLine();
        }

    }
   
}
