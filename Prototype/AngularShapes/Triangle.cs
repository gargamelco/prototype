using System;

namespace Prototype
{
    public class Triangle : IFigure
    {
        protected Tuple<float, float> _vertexA;
        protected Tuple<float, float> _vertexB;
        protected Tuple<float, float> _vertexC;
        protected float _heightA;
        
        public Triangle(float Ax, float Ay, float Bx, float By, float Cx, float Cy, float height)
        {
            _vertexA = new Tuple<float, float>(Ax, Ay);
            _vertexB = new Tuple<float, float>(Bx, By);
            _vertexC = new Tuple<float, float>(Cx, Cy);
            _heightA = height;
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
            DrawLinePoint(_vertexC.Item1, _vertexA.Item1, _vertexC.Item2, _vertexA.Item2);

            Console.WriteLine($"A new triangle was drawn with coodinates of " +
                              $"A: {_vertexA.Item1},{_vertexA.Item2} ; B: {_vertexB.Item1},{_vertexB.Item2} ; " +
                              $"C: {_vertexC.Item1},{_vertexC.Item2}");
        }

        public float GetSurface()
        {
            float aSideLenght = LenghtCalculator.GetLenght(_vertexA, _vertexB);
            float area = Convert.ToSingle(aSideLenght * _heightA * 0.5);
            return area;
        }
    }
}
