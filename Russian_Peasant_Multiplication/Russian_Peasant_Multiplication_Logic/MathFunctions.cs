using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Russian_Peasant_Multiplication_Logic
{
    internal static class MathFunctions
    {
        public static bool ContainsOneNegativeNumber(long[] numbers)
        {
            int negatives = 0;

            foreach (long number in numbers)
            {
                if (number < 0)
                {
                    negatives++;
                }
            }

            return negatives == 1 ? true : false;
        }

        public static long SetAbsolute(long number)
        {
            return number = number < 0 ? number * -1 : number;
        }
    }
}
