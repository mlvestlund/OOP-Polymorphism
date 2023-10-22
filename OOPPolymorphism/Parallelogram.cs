using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPolymorphism
{
    internal class Parallelogram : Geometry
    {
        public double Length {  get; set; }
        public double Height { get; set; }

        public Parallelogram()
        {
            Length = 5; 
            Height = 3;
        }

        public override double Area()
        {
            return Length * Height;
        }
    }
}
