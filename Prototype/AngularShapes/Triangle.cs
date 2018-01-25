using System;

namespace Prototype
{
    public class Triangle : IFigure
    {
        protected Tuple<float, float> _vertex_A;
        protected Tuple<float, float> _vertex_B;
        protected Tuple<float, float> _vertex_C;
        protected float _height_a;
        
        public Triangle(float Ax, float Ay, float Bx, float By, float Cx, float Cy, float height)
        {
            _vertex_A = new Tuple<float, float>(Ax, Ay);
            _vertex_B = new Tuple<float, float>(Bx, By);
            _vertex_C = new Tuple<float, float>(Cx, Cy);
            _height_a = height;
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
            DrawLinePoint(_vertex_C.Item1, _vertex_A.Item1, _vertex_C.Item2, _vertex_A.Item2);

            Console.WriteLine($"A new triangle was drawn with coodinates of " +
                              $"A: {_vertex_A.Item1},{_vertex_A.Item2} ; B: {_vertex_B.Item1},{_vertex_B.Item2} ; " +
                              $"C: {_vertex_C.Item1},{_vertex_C.Item2}");
        }

        public float GetSurface()
        {
            float a_side_lenght = LenghtCalculator.GetLenght(_vertex_A, _vertex_B);
            float area = Convert.ToSingle(a_side_lenght * _height_a * 0.5);
            return area;
        }
    }
}
