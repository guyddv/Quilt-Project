using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quilt_Project
{
    public class Rectangle : Shape
    {
        public Rectangle(string color, int length, int width)
        {
            Name = "Rectangle";
            Color = color;
            Length = length;
            Width = width;
        }

        public override double ShapeArea()
        {
            Area = Length * Width;
            return Area;
        }
    }
}
