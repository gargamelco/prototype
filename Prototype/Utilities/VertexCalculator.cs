using System;

namespace Prototype.Utilities
{
    public static class VertexCalculator
    {
        public static Tuple<float, float> GetVertex(float Ax, float Ay,float Bx,float By,float Cx,float Cy)
        {
            // from the mathematical Dx - Ax = Cx - Bx => Dx = Cx - Bx + Ax
            float Dx = Cx - Bx + Ax;

            // from the mathematical Dy - Ay = Cy - By => Dy = Cy - By + Ay
            float Dy = Cy - By + Ay;

            // the new vertex 
            var vertexD = new Tuple<float, float>(Dx, Dy);

            return vertexD;
        }
    }
}
