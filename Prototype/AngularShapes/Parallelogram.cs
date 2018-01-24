using System;

namespace Prototype
{
    class Parallelogram : Quadrangle, IFigure
    {
        protected float _vertical_height;

        public Parallelogram(float Ax, float Ay, float Bx, float By, float Cx, float Cy, float height)
            : base (Ax, Ay, Bx, By, Cx, Cy, Dx: Cx - Bx + Ax, Dy: Cy - By + Ay)
        {
            _vertex_A = new Tuple<float, float>(Ax, Ay);
            _vertex_B = new Tuple<float, float>(Bx, By);
            _vertex_C = new Tuple<float, float>(Cx, Cy);

            // from the mathematical Dx - Ax = Cx - Bx => Dx = Cx - Bx + Ax
            float Dx = Cx - Bx + Ax;
            // from the mathematical Dy - Ay = Cy - By => Dy = Cy - By + Ay
            float Dy = Cy - By + Ay;
            // the new vertex 
            _vertex_D = new Tuple<float, float>(Dx, Dy);

            _vertical_height = height;
        }

        public new void Draw()
        {
            base.Draw();
            Console.WriteLine($"A new parallelogram was drawn with coodinates of " +
                              $"A: {_vertex_A.Item1},{_vertex_A.Item2} ; B: {_vertex_B.Item1},{_vertex_B.Item2} ; " +
                              $"C: {_vertex_C.Item1},{_vertex_C.Item2} ; D: {_vertex_D.Item1},{_vertex_D.Item2}");
        }

        public new float GetSurface()
        {
            float a_side_lenght = LenghtCalculator.GetLenght(_vertex_A.Item1, _vertex_B.Item1, _vertex_A.Item2, _vertex_B.Item2);
            float area = a_side_lenght * _vertical_height;
            return area;
        }
    }
}
