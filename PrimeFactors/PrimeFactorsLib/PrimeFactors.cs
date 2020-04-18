using System;
using System.Collections.Generic;

namespace PrimeFactorsLib
{
    public class PrimeFactors
    {
        public List<int> PrimeFactorsOf(int number)
        {
            var factors = new List<int>();

            // One is always a factor
            factors.Add(1);

            // Two is a factor if divisible by 2
            if (number % 2 == 0)
            {
                factors.Add(2);
                number /= 2;
            }

            // Find other factors
            Func<int,int> IntSqRoot = (n) => Convert.ToInt32(Math.Sqrt(n));
            var factor = 3;
            var stop_at = IntSqRoot(number);

            while (factor <= stop_at)
            {
                while (number % factor == 0)
                {
                    factors.Add(factor);
                    number = number / factor;
                    stop_at = IntSqRoot(number);
                }

                factor += 2;
            }

            if (number > 1)
            {
                factors.Add(factor);
            }

            return factors;
        }
    }
}
