using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape.Models
{
    public class Rectangle : Shape
    {
        public double Height { get; set; }
        public double Wight { get; set; }

        public override double Area()
        {
            return Height * Wight;
        }
    }
}
