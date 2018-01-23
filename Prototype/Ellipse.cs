using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public delegate double SumDelegate();
    class Ellipse : OvalShapes, IFigure
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

        public void Draw()
        {
            SumDelegate sum = SumBetweenPointAndAFocusAndFocalLenght;

            DrawEllipse(_x, _y, _width, _height);

            Console.WriteLine($"A new ellipse was drawn with coodinates of an embedded rectangle - X:{_x} , Y:{_y}, Width: {_width}, Height{_height} and sum: {sum}");
        }

        public double FocalLenght()
        {
            //distance of the two foci
            double F = Math.Sqrt(Math.Pow(_width, 2) - Math.Pow(_height, 2));
            return F;
        }

        public double SumBetweenPointAndAFocusAndFocalLenght()
        {
            //by definition the lenght between a point and a focus is 2a, in our case that is _width*2
            double pointToFocusLenght = _width * 2;
            double sum = pointToFocusLenght + FocalLenght();
            return sum;
        }

        public void CalculateSurface()
        {
            float area = Convert.ToSingle(Math.PI * _width * _height);
            Console.WriteLine($"The are of the ellipse is {area}");
        }



    }
}
