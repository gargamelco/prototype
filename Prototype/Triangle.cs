using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    class Triangle : AngularShapes, IFigure
    {
        // a new idea but not implemented at all for the moment to use tuple type.. still new to this
        //static int a, b, c, d, x, y;
        //private Tuple<int, int> _vertex_coordinates_A = new Tuple<int, int>(a, b);
        //private Tuple<int, int> _vertex_coordinates_B = new Tuple<int, int>(c, d);
        //private Tuple<int, int> _vertex_coordinates_C = new Tuple<int, int>(x, y);

        protected double _vertex_coordinates_A;
        protected double _vertex_coordinates_B;
        protected double _vertex_coordinates_C;


        public Triangle(double vA, double vB, double vC)
        {
            _vertex_coordinates_A = vA;
            _vertex_coordinates_B = vB;
            _vertex_coordinates_C = vC;
        }

        public void Draw()
        {
            DrawLinePoint(_vertex_coordinates_A, _vertex_coordinates_B);
            DrawLinePoint(_vertex_coordinates_B, _vertex_coordinates_C);
            DrawLinePoint(_vertex_coordinates_C, _vertex_coordinates_A);
            Console.WriteLine($"A new triangle was drawn with coodinates of A: {_vertex_coordinates_A} , B: {_vertex_coordinates_B} , C: {_vertex_coordinates_C}");

        }
    }
}
