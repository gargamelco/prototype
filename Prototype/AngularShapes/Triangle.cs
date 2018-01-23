using System;

namespace Prototype
{
    class Triangle : AngularShapes, IFigure
    {
        protected Tuple<float, float> _vertex_coordinates_A;
        protected Tuple<float, float> _vertex_coordinates_B;
        protected Tuple<float, float> _vertex_coordinates_C;
        protected float _height_a;
        
        public Triangle(float coordinateA1, float coordinateA2, float coordinateB1, float coordinateB2, float coordinateC1, float coordinateC2, float height)
        {
            _vertex_coordinates_A = new Tuple<float, float>(coordinateA1, coordinateA2);
            _vertex_coordinates_B = new Tuple<float, float>(coordinateB1, coordinateB2);
            _vertex_coordinates_C = new Tuple<float, float>(coordinateC1, coordinateC2);
            _height_a = height;
        }

        public void Draw()
        {
            DrawLinePoint(_vertex_coordinates_A.Item1, _vertex_coordinates_B.Item1, _vertex_coordinates_A.Item2, _vertex_coordinates_B.Item2);
            DrawLinePoint(_vertex_coordinates_B.Item1, _vertex_coordinates_C.Item1, _vertex_coordinates_B.Item2, _vertex_coordinates_C.Item2);
            DrawLinePoint(_vertex_coordinates_C.Item1, _vertex_coordinates_A.Item1, _vertex_coordinates_C.Item2, _vertex_coordinates_A.Item2);
            Console.WriteLine($"A new triangle was drawn with coodinates of A: {_vertex_coordinates_A.Item1},{_vertex_coordinates_A.Item2} ; B: {_vertex_coordinates_B.Item1},{_vertex_coordinates_B.Item2} ; C: {_vertex_coordinates_C.Item1},{_vertex_coordinates_C.Item2}");
        }

        public void CalculateSurface()
        {
            float a_side_lenght = LenghtCalculator.GetLenght(_vertex_coordinates_A.Item1, _vertex_coordinates_B.Item1, _vertex_coordinates_A.Item2, _vertex_coordinates_B.Item2);
            float area = Convert.ToSingle(a_side_lenght * _height_a * 0.5);
            Console.WriteLine($"The surface area of the triangle is {area}");
        }
    }
}
