using System;

namespace Prototype
{
    public class Rhombus : Parallelogram, IFigure
    {
        private float diagonal1;
        private float diagonal2;

        public Rhombus(float Ax, float Ay, float Bx, float By, float Cx, float Cy)
           : base(Ax, Ay, Bx, By, Cx, Cy, height:Convert.ToSingle(null))
        {
            diagonal1 = LenghtCalculator.GetLenght(vertexA, vertexC);
            diagonal2 = LenghtCalculator.GetLenght(vertexB, vertexD);
        }

        public override float GetSurface()
        {
            float area = Convert.ToSingle(diagonal1 * diagonal2 * 0.5);
            return area;
        }

        public override string ToString()
        {
            return "rhombus";
        }
    }
}
