using PrimeFactorsLib;
using System.Collections;

int testNumber = 993;

List<int> primeFactors = PrimeFactorsLib.PrimeFactorsLib.PrimeFactors(testNumber);

if (primeFactors.Count == 0)
{
    WriteLine($"{testNumber} is a prime number!");
}
else
{
    Write("Primefactors: ");
    for (int i = 0; i < primeFactors.Count; i++)
    {
        Write($"{primeFactors[i]}");
        if (i < primeFactors.Count - 1)
        {
            Write(" x ");
        }
    }
    Write($" = {testNumber}");
}







