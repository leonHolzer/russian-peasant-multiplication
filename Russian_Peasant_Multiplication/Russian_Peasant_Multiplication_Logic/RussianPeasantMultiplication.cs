namespace Russian_Peasant_Multiplication_Logic
{
    public static class RussianPeasantMultiplication
    {
        public static int Multiply(int multiplicand, int multiplier)
        {
            bool negative = false;
            if ((multiplicand < 0 && multiplier > 0) || (multiplicand > 0 && multiplier < 0))
            {
                negative = true;
            }

            multiplicand = multiplicand < 0 ? multiplicand *-1 : multiplicand;
            multiplier = multiplier < 0 ? multiplier * -1 : multiplier;

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
            if ((multiplicand < 0 && multiplier > 0) || (multiplicand > 0 && multiplier < 0))
            {
                negative = true;
            }

            multiplicand = multiplicand < 0 ? multiplicand * -1 : multiplicand;
            multiplier = multiplier < 0 ? multiplier * -1 : multiplier;

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