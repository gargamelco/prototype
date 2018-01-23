using System;

namespace Prototype
{
    public static class LenghtCalculator
    {
        public static float GetLenght(float x1, float y1, float x2, float y2)
        {
            return Convert.ToSingle(Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2)));
        }
    }
}
