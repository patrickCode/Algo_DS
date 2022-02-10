namespace GeneralAlgo
{
    public class UglyNumber
    {
        public static bool IsUgly(int num)
        {
            int remainingNum = num;
            int[] primeFactors = new int[] { 2, 3, 5 };
            int primeFactorIndex = 0;

            while (remainingNum != 1 && primeFactorIndex <= 2)
            {
                if (remainingNum % primeFactors[primeFactorIndex] == 0)
                {
                    remainingNum /= primeFactors[primeFactorIndex];
                }
                else
                {
                    primeFactorIndex++;
                }
            }

            if (remainingNum == 1)
                return true;
            return false;
        }
    }
}
