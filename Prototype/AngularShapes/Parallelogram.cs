using System;

namespace Prototype
{
    public class Parallelogram : Quadrangle, IFigure
    {
        protected float _verticalHeight;

        public Parallelogram(float Ax, float Ay, float Bx, float By, float Cx, float Cy, float height)
            : base (Ax, Ay, Bx, By, Cx, Cy, Dx: Cx - Bx + Ax, Dy: Cy - By + Ay)
        {
            // from the mathematical Dx - Ax = Cx - Bx => Dx = Cx - Bx + Ax
            float Dx = Cx - Bx + Ax;
            // from the mathematical Dy - Ay = Cy - By => Dy = Cy - By + Ay
            float Dy = Cy - By + Ay;
            // the new vertex 
            _vertexD = new Tuple<float, float>(Dx, Dy);

            _verticalHeight = height;
        }

        public override float GetSurface()
        {
            float aSideLenght = LenghtCalculator.GetLenght(_vertexA, _vertexB);
            float area = aSideLenght * _verticalHeight;
            return area;
        }

        public override string ToString()
        {
            return "parallelogram";
        }
    }
}
