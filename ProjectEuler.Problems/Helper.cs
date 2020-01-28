// <copyright file="Helper.cs" company="Daniel Snouck">
// Copyright (c) Daniel Snouck. All rights reserved.
// Licensed under the MIT License. See LICENSE file in the solution root for full license information.
// </copyright>

namespace ProjectEuler.Problems
{
    using System.Collections.Generic;
    using System.Linq;

    /// <inheritdoc/>
    public class Helper : IHelper
    {
        /// <inheritdoc/>
        public List<int> Digits(int number, int numberBase = 10)
        {
            var digits = new List<int>();
            while (number > 0)
            {
                var rest = number / numberBase;
                var digit = number - (numberBase * rest);
                digits.Add(digit);
                number = rest;
            }

            return digits;
        }

        /// <inheritdoc/>
        public List<long> Factorize(long number)
        {
            var factors = new List<long>();
            var factor = 2L;
            while (number > 1L)
            {
                var nextNumber = number / factor;
                var remainder = number - (nextNumber * factor);
                if (remainder == 0L)
                {
                    factors.Add(factor);
                    number = nextNumber;
                }
                else
                {
                    factor++;
                }
            }

            return factors;
        }

        /// <inheritdoc/>
        public bool IsPalindrome(int number, int numberBase = 10)
        {
            var digits = this.Digits(number, numberBase);
            var reversedDigits = Enumerable.Reverse(digits).ToList();
            return digits.SequenceEqual(reversedDigits);
        }

        /// <inheritdoc/>
        public int SumOfMultiples(int number, int maximum)
        {
            var count = maximum / number;
            return number * count * (count + 1) / 2;
        }
    }
}
