using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quilt_Project
{
    public class Square : Shape
    {
        public Square(string color, int length)
        {
            Name = "Square";
            Color = color;
            Length = length;
        }
        
        public override double ShapeArea()
        {
            Area = Length * Length;
            return Area;
        }
    }
}
