using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    class Parallelogram : Quadrangle, IFigure
    {
        public Parallelogram(double vA, double vB, double vC, double vD)
            : base (vA, vB, vC, vD)
        {
            _vertex_coordinates_A = vA;
            _vertex_coordinates_B = vB;
            _vertex_coordinates_C = vC;
            _vertex_coordinates_D = vD;
        }
    }
}
