using System;

namespace Prototype
{
    class Parallelogram : Quadrangle, IFigure
    {
        float _vertical_height;

        public Parallelogram(float coordinateA1, float coordinateA2, float coordinateB1, float coordinateB2, float coordinateC1, float coordinateC2, float height)
            : base (coordinateA1, coordinateA2, coordinateB1, coordinateB2, coordinateC1, coordinateC2)
        {
            _vertex_coordinates_A = new Tuple<float, float>(coordinateA1, coordinateA2);
            _vertex_coordinates_B = new Tuple<float, float>(coordinateB1, coordinateB2);
            _vertex_coordinates_C = new Tuple<float, float>(coordinateC1, coordinateC2);

            // from the mathematical Dx - Ax = Cx - Bx => Dx = Cx - Bx + Ax
            float coordinateD1 = coordinateC1 - coordinateB1 + coordinateA1;
            // from the mathematical Dy - Ay = Cy - By => Dy = Cy - By + Ay
            float coordinateD2 = coordinateC2 - coordinateB2 + coordinateA2;

            _vertex_coordinates_D = new Tuple<float, float>(coordinateD1, coordinateD2);

            _vertical_height = height;
        }

        public new void Draw()
        {
            DrawLinePoint(_vertex_coordinates_A.Item1, _vertex_coordinates_B.Item1, _vertex_coordinates_A.Item2, _vertex_coordinates_B.Item2);
            DrawLinePoint(_vertex_coordinates_B.Item1, _vertex_coordinates_C.Item1, _vertex_coordinates_B.Item2, _vertex_coordinates_C.Item2);
            DrawLinePoint(_vertex_coordinates_C.Item1, _vertex_coordinates_D.Item1, _vertex_coordinates_C.Item2, _vertex_coordinates_D.Item2);
            DrawLinePoint(_vertex_coordinates_D.Item1, _vertex_coordinates_A.Item1, _vertex_coordinates_D.Item2, _vertex_coordinates_A.Item2);
            Console.WriteLine($"A new parallelogram was drawn with coodinates of A: {_vertex_coordinates_A.Item1},{_vertex_coordinates_A.Item2} ; B: {_vertex_coordinates_B.Item1},{_vertex_coordinates_B.Item2} ; C: {_vertex_coordinates_C.Item1},{_vertex_coordinates_C.Item2} ; D: {_vertex_coordinates_D.Item1},D: {_vertex_coordinates_D.Item2}");
        }

        public new void CalculateSurface()
        {
            float a_side_lenght = LenghtCalculator.GetLenght(_vertex_coordinates_A.Item1, _vertex_coordinates_B.Item1, _vertex_coordinates_A.Item2, _vertex_coordinates_B.Item2);
            float area = a_side_lenght * _vertical_height;
            Console.WriteLine($"The surface area of the parallelogram is {area}");
        }
    }
}
