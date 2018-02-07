using System;

namespace Prototype
{
    public class Quadrangle : IFigure
    {
        protected Tuple<float, float> vertexA;
        protected Tuple<float, float> vertexB;
        protected Tuple<float, float> vertexC;
        protected Tuple<float, float> vertexD;

        public Quadrangle(float Ax, float Ay, float Bx, float By, 
                          float Cx, float Cy, float Dx, float Dy)
        {
            vertexA = new Tuple<float, float>(Ax, Ay);
            vertexB = new Tuple<float, float>(Bx, By);
            vertexC = new Tuple<float, float>(Cx, Cy);
            vertexD = new Tuple<float, float>(Dx, Dy);
        }

        protected void DrawLinePoint(float x1, float y1, float x2, float y2)
        {
            // Code for actual drawing the figure
            // DrawLine connects point to point(in our case vertices of the quadrangle)
            // making the edges of the figure
            // Create pen.
            // Pen blackPen = new Pen(Color.Black, 3);
            // Draw line to screen.
            // e.Graphics.DrawLine(blackPen, x1, y1, x2, y2);
        }

        public void Draw()
        {
            DrawLinePoint(vertexA.Item1, vertexB.Item1, vertexA.Item2, vertexB.Item2);
            DrawLinePoint(vertexB.Item1, vertexC.Item1, vertexB.Item2, vertexC.Item2);
            DrawLinePoint(vertexC.Item1, vertexD.Item1, vertexC.Item2, vertexD.Item2);
            DrawLinePoint(vertexD.Item1, vertexA.Item1, vertexD.Item2, vertexA.Item2);
            Console.WriteLine($"A new { ToString() } was drawn.");
        }
    
        public virtual float GetSurface()
        {
            return 0;
        }

        public override string ToString()
        {
            return "quadrangle";
        }
    }
}
