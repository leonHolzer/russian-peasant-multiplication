using System.Diagnostics;

namespace Russian_Peasant_Multiplication_Logic
{
    public static class RussianPeasantMultiplication
    {
        public static int Multiply(int multiplicand, int multiplier)
        {
            //this bit could be handled with bitwise operators for cleaner code and better performance, but sadly I do not know enough about them
            //a possible improvement for this algorithm is swapping the multiplicand for the multiplier if it's even to minimize the number of additions, but sadly I do not know how this would improve efficency in the code (or when I should use it to improve efficency)
            bool negative = false;

            //switch multiplicand and multiplier to always divide the smaller number
            if (multiplicand > multiplier)
            {
                int temp = multiplicand;
                multiplicand = multiplier;
                multiplier = temp;
            }
            
            //set all numbers absolute, set flag if result has to be negative
            if (multiplicand < 0)
            {
                multiplicand *= -1;
                negative = true;
            }

            if (multiplier < 0)
            {
                multiplier *= -1;
                negative = negative ? false : true;
            }


            int result = 0;

            while (multiplicand > 0)
            {
                if (multiplicand % 2 != 0)
                {
                    result += multiplier;
                }

                multiplicand = (int)Math.Floor(Convert.ToDecimal(multiplicand) / 2);
                multiplier *= 2;
            }

            return negative ? -result : result;
        }

        public static long Multiply(long multiplicand, long multiplier)
        {
            bool negative = false;

            //switch multiplicand and multiplier to always divide the smaller number
            if (multiplicand > multiplier)
            {
                long temp = multiplicand;
                multiplicand = multiplier;
                multiplier = temp;
            }

            //set all numbers absolute, set flag if result has to be negative
            if (multiplicand < 0)
            {
                multiplicand *= -1;
                negative = true;
            }

            if (multiplier < 0)
            {
                multiplier *= -1;
                negative = !negative ? true : false;
            }


            long result = 0;

            while (multiplicand > 0)
            {
                if (multiplicand % 2 != 0)
                {
                    result += multiplier;
                }

                multiplicand = (long)Math.Floor(Convert.ToDecimal(multiplicand) / 2);
                multiplier *= 2;
            }

            return negative ? -result : result;
        }
    }
}