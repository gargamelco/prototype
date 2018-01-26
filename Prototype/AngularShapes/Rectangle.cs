using System;

namespace Prototype
{
    public class Rectangle : Parallelogram , IFigure
    {
        public Rectangle(float Ax, float Ay, float Bx, float By, float Cx, float Cy)
           : base(Ax, Ay, Bx, By, Cx, Cy, height:Convert.ToSingle(null))
        {
        }

        public override float GetSurface()
        {
            float aSideLenght = LenghtCalculator.GetLenght(_vertexA, _vertexB);
            float bSideLenght = LenghtCalculator.GetLenght(_vertexB, _vertexC);
            float area = aSideLenght * bSideLenght;
            return area;
        }

        public override string ToString()
        {
            return "rectangle";
        }
    }
}
