using System;

namespace Prototype
{
    public delegate double SumDelegate();
    public class Ellipse : IFigure
    {
        protected float _x; // The x-coordinate of the upper-left corner of the bounding rectangle that defines the ellipse.
        protected float _y; // The y-coordinate of the upper-left corner of the bounding rectangle that defines the ellipse.
        protected static float _width;  // Width of the bounding rectangle that defines the ellipse. 
        protected static float _height; // Height of the bounding rectangle that defines the ellipse.

        public Ellipse(float x, float y, float width, float height)
        {
            _x = x;
            _y = y;
            _width = width;
            _height = height;
        }

        protected void DrawEllipse(float x, float y, float width, float height)
        {
            // Code for actual drawing the figure
            // DrawEllipse uses a rectangle to draw an ellipse defined by its upper-left corner coordinates,its height and  width.
            // Create pen.
            // Pen blackPen = new Pen(Color.Black, 3);
            // Draw ellipse to screen.
            // e.Graphics.DrawEllipse(blackPen, x, y, width, height);
        }

        public void Draw()
        {
            SumDelegate sum = SumBetweenPointAndAFocusAndFocalLenght;

            DrawEllipse(_x, _y, _width, _height);

            Console.WriteLine($"A new ellipse was drawn with coodinates of an embedded rectangle - X:{_x} , Y:{_y}, Width: {_width}, Height{_height} and sum: {sum}");
        }

        private double FocalLenght()
        {
            //distance of the two foci
            double f = Math.Sqrt(Math.Pow(_width, 2) - Math.Pow(_height, 2));
            return f;
        }

        public double SumBetweenPointAndAFocusAndFocalLenght()
        {
            //by definition the lenght between a point and a focus is 2a, in our case that is _width*2
            double pointToFocusLenght = _width * 2;
            double sum = pointToFocusLenght + FocalLenght();
            return sum;
        }

        public float GetSurface()
        {
            float area = Convert.ToSingle(Math.PI * _width * _height);
            return area;
        }
    }
}
