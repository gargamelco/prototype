using Prototype.Utilities;

namespace Prototype
{
    public class Parallelogram : Quadrangle, IFigure
    {
        private float verticalHeight;

        public Parallelogram(float Ax, float Ay, float Bx, float By, float Cx, float Cy, float height)
            : base (Ax, Ay, Bx, By, Cx, Cy, Dx: Cx - Bx + Ax, Dy: Cy - By + Ay)
        {
            vertexD = VertexCalculator.GetVertex(Ax, Ay, Bx, By, Cx, Cy);

            verticalHeight = height;
        }

        public override float GetSurface()
        {
            float aSideLenght = LenghtCalculator.GetLenght(vertexA, vertexB);
            float area = aSideLenght * verticalHeight;
            return area;
        }

        public override string ToString()
        {
            return "parallelogram";
        }
    }
}
