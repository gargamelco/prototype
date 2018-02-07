using System;

namespace Prototype
{
    public class Quadrangle : IFigure
    {
        protected Tuple<float, float> _vertexA;
        protected Tuple<float, float> _vertexB;
        protected Tuple<float, float> _vertexC;
        protected Tuple<float, float> _vertexD;

        public Quadrangle(float Ax, float Ay, float Bx, float By, 
                          float Cx, float Cy, float Dx, float Dy)
        {
            _vertexA = new Tuple<float, float>(Ax, Ay);
            _vertexB = new Tuple<float, float>(Bx, By);
            _vertexC = new Tuple<float, float>(Cx, Cy);
            _vertexD = new Tuple<float, float>(Dx, Dy);
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
            DrawLinePoint(_vertexA.Item1, _vertexB.Item1, _vertexA.Item2, _vertexB.Item2);
            DrawLinePoint(_vertexB.Item1, _vertexC.Item1, _vertexB.Item2, _vertexC.Item2);
            DrawLinePoint(_vertexC.Item1, _vertexD.Item1, _vertexC.Item2, _vertexD.Item2);
            DrawLinePoint(_vertexD.Item1, _vertexA.Item1, _vertexD.Item2, _vertexA.Item2);
            Console.WriteLine($"A new {this.ToString()} was drawn.");
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
