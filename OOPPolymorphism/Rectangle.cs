using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPolymorphism
{
    internal class Rectangle : Geometry
    {
        public double Length { get; set; }
        public double Width { get; set; }

        public Rectangle()
        {
            Length = 5;

            Width = 3;

        }

        public override double Area()
        {
            return Length * Width;
        }
    }
}
