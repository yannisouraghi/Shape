using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape.Models
{
    public class AreaCalculator
    {
        public double TotalArea(object[] arrObjects)
        {
            double area = 0;
            Rectangle ObjRectangle;
            Circle ObjCircle;
            Square ObjSquare;
            Triangle ObjTriangle;
            foreach (var obj in arrObjects)
            {
                if (obj is Rectangle)
                {
                    ObjRectangle = (Rectangle)obj;
                    area += ObjRectangle.Height * ObjRectangle.Wight;
                }
                else if (obj is Square)
                {
                    ObjSquare = (Square)obj;
                    area += ObjSquare.Wight * ObjSquare.Wight;
                }
                else if (obj is Triangle)
                {
                    ObjTriangle = (Triangle)obj;
                    area += (ObjTriangle.triangleBase * ObjTriangle.triangleHauteur)/ 2;
                }
                else 
                {
                    ObjCircle = (Circle)obj;
                    area += ObjCircle.Radius * ObjCircle.Radius * System.Math.PI;
                }
            }
            return area;
        }
    }
}
