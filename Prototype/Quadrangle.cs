using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    class Quadrangle : AngularShapes, IFigure
    {
        protected double _vertex_coordinates_A;
        protected double _vertex_coordinates_B;
        protected double _vertex_coordinates_C;
        protected double _vertex_coordinates_D;

        public Quadrangle(double vA, double vB, double vC, double vD)
        {
            _vertex_coordinates_A = vA;
            _vertex_coordinates_B = vB;
            _vertex_coordinates_C = vC;
            _vertex_coordinates_D = vD;
        }

        public void Draw()
        {
            DrawLinePoint(_vertex_coordinates_A, _vertex_coordinates_B);
            DrawLinePoint(_vertex_coordinates_B, _vertex_coordinates_C);
            DrawLinePoint(_vertex_coordinates_C, _vertex_coordinates_D);
            DrawLinePoint(_vertex_coordinates_D, _vertex_coordinates_A);
            Console.WriteLine($"A new quadrangle was drawn with coodinates of A: {_vertex_coordinates_A} , B: {_vertex_coordinates_B} , C: {_vertex_coordinates_C} , D: {_vertex_coordinates_D}");

        }
    }
}
