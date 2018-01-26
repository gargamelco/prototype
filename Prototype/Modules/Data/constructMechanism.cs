using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.Modules.Data
{
    public static class ConstructMechanism
    {
        public static Parallelogram GetProperFigureType(Tuple<float, float> p1, Tuple<float, float> p2, Tuple<float, float> p3, Tuple<float, float> p4)
        {
            float side_a = LenghtCalculator.GetLenght(p1, p2);
            float side_b = LenghtCalculator.GetLenght(p2, p3);
            float side_c = LenghtCalculator.GetLenght(p3, p4);
            float side_d = LenghtCalculator.GetLenght(p4, p1);
            float d1 = LenghtCalculator.GetLenght(p1, p3);
            float d2 = LenghtCalculator.GetLenght(p2, p4);

            if (side_a == side_b && side_a == side_c && side_a == side_d)
            {
                if(d1 != d2)
                {
                    return new Rhombus(p1.Item1, p1.Item2, p2.Item1, p2.Item2, p3.Item1, p3.Item2, d1, d2);
                }
                else if(d1 == d2)
                {
                    return new Square(p1.Item1, p1.Item2, p2.Item1, p2.Item2, p3.Item1, p3.Item2);
                }
            }
            else if (side_a == side_c && side_b == side_d)
            {
                return new Rectangle(p1.Item1, p1.Item2, p2.Item1, p2.Item2, p3.Item1, p3.Item2);
            }
            else
            {
                return new Parallelogram(p1.Item1, p1.Item2, p2.Item1, p2.Item2, p3.Item1, p3.Item2, height:0);
            }
        }
    }
}
