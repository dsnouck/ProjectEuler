// <copyright file="Problem4.cs" company="Daniel Snouck">
// Copyright (c) Daniel Snouck. All rights reserved.
// Licensed under the MIT License. See LICENSE file in the solution root for full license information.
// </copyright>

namespace ProjectEuler.Problems
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;

    /// <inheritdoc/>
    public class Problem4 : IProblem
    {
        /// <inheritdoc/>
        public string Solve()
        {
            var palindromes = new List<int>();
            for (var number = 100; number < 1000; number++)
            {
                for (var otherNumber = number; otherNumber < 1000; otherNumber++)
                {
                    var product = number * otherNumber;
                    if (IsPalindrome(product))
                    {
                        palindromes.Add(product);
                    }
                }
            }

            return palindromes.Max().ToString(CultureInfo.InvariantCulture);
        }

        private static bool IsPalindrome(int number, int numberBase = 10)
        {
            var digits = Digits(number, numberBase);
            var reversedDigits = Enumerable.Reverse(digits).ToList();
            return digits.SequenceEqual(reversedDigits);
        }

        private static List<int> Digits(int number, int numberBase = 10)
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
    }
}
