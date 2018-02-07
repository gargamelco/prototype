using System;

namespace Prototype
{
    public class Circle : Ellipse, IFigure
    {
        private double radius;

        public Circle(float x, float y, float width, float height) 
            : base(x, y, width, height)
        {
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;
            if(width == height)
            {
                radius = width / 2;
            }
        }

        public override void Draw()
        {
            DrawEllipse(x, y, width, height);

            Console.WriteLine($"A new circle was drawn with coodinates of an embedded rectangle - X: {x} , Y: {y}, Width: {width}, Height: {height} and a radius: {radius}");
        }

        public override float GetSurface()
        {
            float area = Convert.ToSingle(Math.PI * Math.Pow(radius, 2));
            return area;
        }
    }
}
