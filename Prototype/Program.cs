﻿using System;
using System.Collections.Generic;
using Prototype.BST;
using Prototype.Utilities;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            // oval shapes
            // ellipse
            Ellipse ellipse = new Ellipse(3, 5, 20, 15);
            ellipse.Draw();
            Console.WriteLine($"ellipse's sum between a poin and the two foci is { ellipse.SumBetweenPointAndAFocusAndFocalLenght() }");
            Console.WriteLine($"ellipse's surface area is { ellipse.GetSurface() } \n");

            // circle
            Circle circle = new Circle(2, 2, 10, 10);
            circle.Draw();
            Console.WriteLine($"circle's surface area is { circle.GetSurface() } \n ");

            // angular shapes built with construct mechanism
            // parallelogram
            var figOne = ConstructMechanism.GetProperFigureType(new Tuple<float, float>(8, 5), new Tuple<float, float>(17, 5), new Tuple<float, float>(21, 10));
            figOne.Draw();
            Console.WriteLine($"{ figOne.ToString() }'s surface area is { figOne.GetSurface() } \n");

            //square
            var figTwo = ConstructMechanism.GetProperFigureType(new Tuple<float, float>(0, 5), new Tuple<float, float>(5, 5), new Tuple<float, float>(5, 10));
            figTwo.Draw();
            Console.WriteLine($"{ figTwo.ToString() }'s surface area is { figTwo.GetSurface() } \n");

            //rhombus
            var figThree = ConstructMechanism.GetProperFigureType(new Tuple<float, float>(0, 0), new Tuple<float, float>(5, 0), new Tuple<float, float>(8, 4));
            figThree.Draw();
            Console.WriteLine($"{ figThree.ToString() }'s surface area is { figThree.GetSurface() } \n");


            List<Quadrangle> list = new List<Quadrangle>{figOne, figTwo, figThree};

            //BST initialised, filled and operated
            Tree<Quadrangle> t1 = new Tree<Quadrangle>();

            foreach (var item in list)
            {
                t1.Add(item.GetSurface());
            }

            Console.Write("Tree ordered ascending by shapes' surfaces : ");
            t1.InAscOrderTreeDisplay(t1.root);

            Console.Write("\nTree ordered descending by shapes' surfaces: ");
            t1.InDescOrderTreeDisplay(t1.root);

            Console.Write("\nTree searched for surface equal to 25. Output is: ");
            Console.WriteLine(t1.FindValue(t1.root, 25) ? "Found" : "Not Found");
        }
    }
}
    
    

