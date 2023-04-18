using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape.Models
{
    class Triangle : Shape
    {
        public double triangleBase;
        public double triangleHauteur;

        public override double Area()
        {
            return triangleBase * triangleHauteur;
        }
    }
}
