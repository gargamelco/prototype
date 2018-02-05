using System;
using Prototype.BST;

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
            Console.WriteLine($"square's surface area is { square.GetSurface() } \n");

            Tree t1 = new Tree();

            t1.Add(ellipse.GetSurface());
            t1.Add(circle.GetSurface());
            t1.Add(parallelogram.GetSurface());
            t1.Add(square.GetSurface());

            Console.Write("Tree ordered ascending by shapes' surfaces : ");
            t1.InAscOrderTreeDisplay(t1.root);

            Console.Write("\nTree ordered descending by shapes' surfaces: ");
            t1.InDescOrderTreeDisplay(t1.root);

            Console.Write("\nTree searched for surface equal to 61. Output is: ");
            Console.WriteLine(t1.FindValue(t1.root, Convert.ToSingle(61)) ? "Found" : "Not Found");
        }
    }
}
    
    

