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
        protected double _x; // The x-coordinate of the upper-left corner of the bounding rectangle that defines the ellipse.
        protected double _y; // The y-coordinate of the upper-left corner of the bounding rectangle that defines the ellipse.
        protected static double _width;  // Width of the bounding rectangle that defines the ellipse. 
        protected static double _height; // Height of the bounding rectangle that defines the ellipse.

        public Ellipse(double x, double y, double width, double height)
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

        
            
        

    }
}
