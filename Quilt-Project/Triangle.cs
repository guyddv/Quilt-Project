using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quilt_Project
{
    public class Triangle : Shape
    {
        int sideOne = 0;
        int sideTwo = 0;
        int sideThree = 0;

        public Triangle(string color, int side1, int side2, int side3)
        {
            Name = "Rectangle";
            Color = color;
            sideOne = side1;
            sideTwo = side2;
            sideThree = side3;
        }
        public override double ShapeArea()
        {
            double perimeter = (sideOne + sideTwo + sideThree) / 2.0d;
            Area = Convert.ToInt32(Math.Sqrt((perimeter * (perimeter - sideOne) * (perimeter - sideTwo) * (perimeter - sideThree))));
            return Area;
        }
    }
}
