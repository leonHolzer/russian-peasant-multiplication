namespace Russian_Peasant_Multiplication_Logic
{
    public static class RussianPeasantMultiplication
    {
        public static int Multiply(int multiplicand, int multiplier)
        {
            bool negative = MathFunctions.ContainsOneNegativeNumber(new long[] { multiplicand, multiplier });

            multiplicand = (int)MathFunctions.SetAbsolute(multiplicand);
            multiplier = (int)MathFunctions.SetAbsolute(multiplier);

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
            bool negative = MathFunctions.ContainsOneNegativeNumber(new long[] { multiplicand, multiplier });

            multiplicand = MathFunctions.SetAbsolute(multiplicand);
            multiplier = MathFunctions.SetAbsolute(multiplier);

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