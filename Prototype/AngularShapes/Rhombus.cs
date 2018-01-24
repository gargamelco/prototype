using System;

namespace Prototype
{
    class Rhombus : Parallelogram, IFigure
    {
        protected float _diagonal1;
        protected float _diagonal2;

        public Rhombus(float Ax, float Ay, float Bx, float By, float Cx, float Cy, float d1, float d2)
           : base(Ax, Ay, Bx, By, Cx, Cy, height:Convert.ToSingle(null))
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

            _diagonal1 = d1;
            _diagonal2 = d2;
        }

        public new void Draw()
        {
            base.Draw();
            Console.WriteLine($"A new rhombus was drawn with coodinates of " +
                              $"A: {_vertex_A.Item1},{_vertex_A.Item2} ; B: {_vertex_B.Item1},{_vertex_B.Item2} ; " +
                              $"C: {_vertex_C.Item1},{_vertex_C.Item2} ; D: {_vertex_D.Item1},{_vertex_D.Item2}");
        }


        public new float GetSurface()
        {
            float area = Convert.ToSingle(_diagonal1 * _diagonal2 * 0.5);
            return area;
        }
    }
}
