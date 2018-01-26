using System;

namespace Prototype
{
    public class Rhombus : Parallelogram, IFigure
    {
        private float _diagonal1;
        private float _diagonal2;

        public Rhombus(float Ax, float Ay, float Bx, float By, float Cx, float Cy)
           : base(Ax, Ay, Bx, By, Cx, Cy, height:Convert.ToSingle(null))
        {
            _diagonal1 = LenghtCalculator.GetLenght(_vertexA, _vertexC);
            _diagonal2 = LenghtCalculator.GetLenght(_vertexB, _vertexD);
        }

        public override float GetSurface()
        {
            float area = Convert.ToSingle(_diagonal1 * _diagonal2 * 0.5);
            return area;
        }

        public override string ToString()
        {
            return "rhombus";
        }
    }
}
