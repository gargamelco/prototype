using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    class Circle : Ellipse, IFigure
    {
        private double radius;

        public Circle(double x, double y, double width, double height) 
            : base(x, y, width, height)
        {
            _x = x;
            _y = y;
            _width = width;
            _height = height;
            if(_width == _height)
            {
                radius = _width / 2;
            }
        }

        public new void Draw()
        {
            DrawEllipse(_x, _y, _width, _height);

            Console.WriteLine($"A new circle was drawn with coodinates of an embedded rectangle - X:{_x} , Y:{_y}, Width: {_width}, Height{_height} and radius: {radius}");
        }
    }
}
