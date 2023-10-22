using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPolymorphism
{
    internal class Ellipse : Geometry
    {
        public double HalfMajorAxis { get; set; }
        public double HalfMinorAxis { get; set; }

        public Ellipse()
        {
            HalfMajorAxis = 5;
            HalfMinorAxis = 3;
        }

        public override double Area()
        {
            return Math.PI * HalfMajorAxis * HalfMinorAxis;
        }
    }
}
