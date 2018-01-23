using System;

namespace Prototype
{
    class Quadrangle : AngularShapes, IFigure
    {
        protected Tuple<float, float> _vertex_coordinates_A;
        protected Tuple<float, float> _vertex_coordinates_B;
        protected Tuple<float, float> _vertex_coordinates_C;
        protected Tuple<float, float> _vertex_coordinates_D;

        public Quadrangle(float coordinateA1, float coordinateA2, float coordinateB1, float coordinateB2, float coordinateC1, float coordinateC2, float coordinateD1, float coordinateD2)
        {
            _vertex_coordinates_A = new Tuple<float, float>(coordinateA1, coordinateA2);
            _vertex_coordinates_B = new Tuple<float, float>(coordinateB1, coordinateB2);
            _vertex_coordinates_C = new Tuple<float, float>(coordinateC1, coordinateC2);
            _vertex_coordinates_D = new Tuple<float, float>(coordinateD1, coordinateD2);
        }

        public Quadrangle(float coordinateA1, float coordinateA2, float coordinateB1, float coordinateB2, float coordinateC1, float coordinateC2)
        {
        }

        public void Draw()
        {
            DrawLinePoint(_vertex_coordinates_A.Item1, _vertex_coordinates_B.Item1, _vertex_coordinates_A.Item2, _vertex_coordinates_B.Item2);
            DrawLinePoint(_vertex_coordinates_B.Item1, _vertex_coordinates_C.Item1, _vertex_coordinates_B.Item2, _vertex_coordinates_C.Item2);
            DrawLinePoint(_vertex_coordinates_C.Item1, _vertex_coordinates_D.Item1, _vertex_coordinates_C.Item2, _vertex_coordinates_D.Item2);
            DrawLinePoint(_vertex_coordinates_D.Item1, _vertex_coordinates_A.Item1, _vertex_coordinates_D.Item2, _vertex_coordinates_A.Item2);
            Console.WriteLine($"A new quadrangle was drawn with coodinates of A: {_vertex_coordinates_A.Item1},{_vertex_coordinates_A.Item2} ; B: {_vertex_coordinates_B.Item1},{_vertex_coordinates_B.Item2} ; C: {_vertex_coordinates_C.Item1},{_vertex_coordinates_C.Item2} ; D: {_vertex_coordinates_D.Item1},D: {_vertex_coordinates_D.Item2}");
        }
    
        public void CalculateSurface()
        {
            Console.WriteLine("No specific formula for no specific shape like quadrangle");
        }
    }
}
