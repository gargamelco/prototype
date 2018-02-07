using System;

namespace Prototype
{
    public class Triangle : IFigure
    {
        private Tuple<float, float> vertexA;
        private Tuple<float, float> vertexB;
        private Tuple<float, float> vertexC;
        private float heightA;
        
        public Triangle(float Ax, float Ay, float Bx, float By, float Cx, float Cy, float height)
        {
            vertexA = new Tuple<float, float>(Ax, Ay);
            vertexB = new Tuple<float, float>(Bx, By);
            vertexC = new Tuple<float, float>(Cx, Cy);
            heightA = height;
        }

        private void DrawLinePoint(float x1, float y1, float x2, float y2)
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
            DrawLinePoint(vertexC.Item1, vertexA.Item1, vertexC.Item2, vertexA.Item2);

            Console.WriteLine($"A new triangle was drawn with coodinates of " +
                              $"A: {vertexA.Item1},{vertexA.Item2} ; B: {vertexB.Item1},{vertexB.Item2} ; " +
                              $"C: {vertexC.Item1},{vertexC.Item2}");
        }

        public float GetSurface()
        {
            float aSideLenght = LenghtCalculator.GetLenght(vertexA, vertexB);
            float area = Convert.ToSingle(aSideLenght * heightA * 0.5);
            return area;
        }
    }
}
