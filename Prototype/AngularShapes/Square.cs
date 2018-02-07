using System;

namespace Prototype
{
    public class Square : Rectangle, IFigure
    {
        public Square(float Ax, float Ay, float Bx, float By, float Cx, float Cy)
           : base(Ax, Ay, Bx, By, Cx, Cy)
        {
        }

        public override float GetSurface()
        {
            float aSideLenght = LenghtCalculator.GetLenght(vertexA, vertexB);
            float area = Convert.ToSingle(Math.Pow(aSideLenght,2));
            return area;
        }

        public override string ToString()
        {
            return "square";
        }
    }
}
