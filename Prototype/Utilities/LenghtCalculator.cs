using System;

namespace Prototype
{
    public static class LenghtCalculator
    {
        public static float GetLenght(Tuple<float, float> p1, Tuple<float, float> p2)
        {
            float result = Convert.ToSingle(Math.Sqrt(Math.Pow((p1.Item1 - p2.Item1), 2) + Math.Pow((p1.Item2 - p2.Item2), 2)));
            return result;
        }
    }
}
