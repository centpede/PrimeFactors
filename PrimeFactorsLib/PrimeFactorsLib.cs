namespace PrimeFactorsLib
{
    public static class PrimeFactorsLib
    {
        static List<int>? primeNumbers = new();
        public static List<int> PrimeFactors(int testNumber)
        {
            List<int> primeFactors = new();

            if (primeNumbers!.Count == 0)
            {
                CreatePrimeNumbersList();
            }

            primeFactors.Clear();

            if (!primeNumbers!.Contains(testNumber)!)
            {
                for (int i = 0; i < primeNumbers.Count && testNumber > 1; i++)
                {
                    if (testNumber % primeNumbers[i] == 0)
                    {
                        primeFactors.Add(primeNumbers[i]);
                        testNumber /= primeNumbers[i];
                        i = 0;
                    }
                }
            }
            return primeFactors;
        }

        public static void CreatePrimeNumbersList(int maxPrime = 1000)
        {
            for (int i = 2; i < maxPrime; i++)
            {
                if (IsPrime(i))
                {
                    primeNumbers!.Add(i);
                }
            }
        }

        public static bool IsPrime(int testNumber)
        {
            if (testNumber < 2)
            {
                return false;
            }
            else
            {
                for (int i = 2; i < testNumber; i++)
                {
                    if (testNumber % i == 0)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
