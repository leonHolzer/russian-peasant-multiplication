namespace Russian_Peasant_Multiplication_Logic
{
    public static class RussianPeasantMultiplication
    {
        public static int Multiply(int multiplicand, int multiplier)
        {
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

            return result;
        }
    }
}