using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    class Circle : Ellipse, IFigure
    {
        private double _radius;

        public Circle(float x, float y, float width, float height) 
            : base(x, y, width, height)
        {
            _x = x;
            _y = y;
            _width = width;
            _height = height;
            if(_width == _height)
            {
                _radius = _width / 2;
            }
        }

        public new void Draw()
        {
            DrawEllipse(_x, _y, _width, _height);

            Console.WriteLine($"A new circle was drawn with coodinates of an embedded rectangle - X:{_x} , Y:{_y}, Width: {_width}, Height{_height} and radius: {_radius}");
        }

        public new void CalculateSurface()
        {
            float area = Convert.ToSingle(Math.PI * Math.Pow(_radius, 2));
            Console.WriteLine($"The are of the circle is {area}");
        }
    }
}
