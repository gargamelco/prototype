using System;

namespace Prototype.Utilities
{
    public static class ConstructMechanism
    {
        public static Quadrangle GetProperFigureType(Tuple<float, float> p1, Tuple<float, float> p2, Tuple<float, float> p3)
        {
            var p4 = VertexCalculator.GetVertex(p1.Item1, p1.Item2, p2.Item1, p2.Item2, p3.Item1, p3.Item2);

            float sideA = LenghtCalculator.GetLenght(p1, p2);
            float sideB = LenghtCalculator.GetLenght(p2, p3);
            float sideC = LenghtCalculator.GetLenght(p3, p4);
            float sideD = LenghtCalculator.GetLenght(p4, p1);
            float d1 = LenghtCalculator.GetLenght(p1, p3);
            float d2 = LenghtCalculator.GetLenght(p2, p4);

            if (sideA == sideB && sideA == sideC && sideA == sideD)
            {
                if(d1 != d2)
                {
                    return new Rhombus(p1.Item1, p1.Item2, p2.Item1, p2.Item2, p3.Item1, p3.Item2);
                }
                else
                {
                    return new Square(p1.Item1, p1.Item2, p2.Item1, p2.Item2, p3.Item1, p3.Item2);
                }
            }
            else if (sideA == sideC && sideB == sideD)
            {
                if (d1 != d2)
                {
                    return new Parallelogram(p1.Item1, p1.Item2, p2.Item1, p2.Item2, p3.Item1, p3.Item2, height: new Random().Next(1, 11));
                }
                else
                {
                    return new Rectangle(p1.Item1, p1.Item2, p2.Item1, p2.Item2, p3.Item1, p3.Item2);
                }
            }
            else
            {
                return new Quadrangle(p1.Item1, p1.Item2, p2.Item1, p2.Item2, p3.Item1, p3.Item2, p4.Item1, p4.Item2);
            }
        }
    }
}
