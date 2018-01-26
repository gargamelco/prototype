using System;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            //oval shapes
            Ellipse ellipse = new Ellipse(3, 5, 20, 15);
            ellipse.Draw();
            Console.WriteLine($"ellipse's sum between a poin and the two foci is { ellipse.SumBetweenPointAndAFocusAndFocalLenght() }");
            Console.WriteLine($"ellipse's surface area is { ellipse.GetSurface() }");

            Circle circle = new Circle(2, 2, 10, 10);
            circle.Draw();
            Console.WriteLine($"circle's surface area is { circle.GetSurface() }");

            //angular shapes
            Parallelogram parallelogram = new Parallelogram(2, 3, 4, 5, 6, 7, 8);
            parallelogram.Draw();
            Console.WriteLine($"parallelogram's surface area is { parallelogram.GetSurface() } ");

            Square square = new Square(0, 5, 6, 10, 8, 12);
            square.Draw();
            Console.WriteLine($"square's surface area is { square.GetSurface() } ");

        }
    }
}
    
    

