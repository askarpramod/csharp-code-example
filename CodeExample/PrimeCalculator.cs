using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeExample
{
    /// <summary>
    /// Calculate the sum of all prime numbers up to a given integer 'n'.
    /// </summary>
    public class PrimeCalculator
    {
        protected PrimeCalculator() { }

        public static long SumPrimes(int n)
        {            
            long sum = 0;

            for (int i = 2; i <= n; i++)
            {
                if (IsPrime(i))
                {
                    sum += i;
                }
            }

            return sum;
        }
        static bool IsPrime(int number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;

            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0) return false;
            }

            return true;
        }
    }
}
