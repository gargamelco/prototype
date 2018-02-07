using System;

namespace Prototype
{
    public class Ellipse : IFigure
    {
        protected float x; // The x-coordinate of the upper-left corner of the bounding rectangle that defines the ellipse.
        protected float y; // The y-coordinate of the upper-left corner of the bounding rectangle that defines the ellipse.
        protected float width;  // Width of the bounding rectangle that defines the ellipse. 
        protected float height; // Height of the bounding rectangle that defines the ellipse.

        public Ellipse(float x, float y, float width, float height)
        {
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;
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

        public virtual void Draw()
        {
            DrawEllipse(x, y, width, height);

            Console.WriteLine($"A new ellipse was drawn with coodinates of an embedded rectangle - X: {x} , Y: {y}, Width: {width}, Height: {height}");
        }

        private float FocalLenght()
        {
            //distance of the two foci
            double f = Math.Sqrt(Math.Pow(width, 2) - Math.Pow(height, 2));
            return Convert.ToSingle(f);
        }

        public float SumBetweenPointAndAFocusAndFocalLenght()
        {
            //by definition the lenght between a point and a focus is 2a, in our case that is _width*2
            double pointToFocusLenght = width * 2;
            double sum = pointToFocusLenght + FocalLenght();
            return Convert.ToSingle(sum);
        }

        public virtual float GetSurface()
        {
            float area = Convert.ToSingle(Math.PI * width * height);
            return area;
        }
    }
}
