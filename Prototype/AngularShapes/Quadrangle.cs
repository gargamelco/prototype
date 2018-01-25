using System;

namespace Prototype
{
    public class Quadrangle : IFigure
    {
        protected Tuple<float, float> _vertex_A;
        protected Tuple<float, float> _vertex_B;
        protected Tuple<float, float> _vertex_C;
        protected Tuple<float, float> _vertex_D;

        public Quadrangle(float Ax, float Ay, float Bx, float By, 
                          float Cx, float Cy, float Dx, float Dy)
        {
            _vertex_A = new Tuple<float, float>(Ax, Ay);
            _vertex_B = new Tuple<float, float>(Bx, By);
            _vertex_C = new Tuple<float, float>(Cx, Cy);
            _vertex_D = new Tuple<float, float>(Dx, Dy);
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
            DrawLinePoint(_vertex_A.Item1, _vertex_B.Item1, _vertex_A.Item2, _vertex_B.Item2);
            DrawLinePoint(_vertex_B.Item1, _vertex_C.Item1, _vertex_B.Item2, _vertex_C.Item2);
            DrawLinePoint(_vertex_C.Item1, _vertex_D.Item1, _vertex_C.Item2, _vertex_D.Item2);
            DrawLinePoint(_vertex_D.Item1, _vertex_A.Item1, _vertex_D.Item2, _vertex_A.Item2);
        }
    
        public float GetSurface()
        {
            return 0;
        }
    }
}
