using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quilt_Project
{
    public abstract class Shape
    {
        public string Name = " ";
        public string Color = " ";
        public int Length = 0;
        public int Width = 0;
        public double Area = 0.0d;

        public virtual double ShapeArea()
        {
            Area = Length * Width;
            return Area;
        }
    }
}
