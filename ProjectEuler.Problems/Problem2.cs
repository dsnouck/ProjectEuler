// <copyright file="Problem2.cs" company="Daniel Snouck">
// Copyright (c) Daniel Snouck. All rights reserved.
// Licensed under the MIT License. See LICENSE file in the solution root for full license information.
// </copyright>

namespace ProjectEuler.Problems
{
    using System.Globalization;

    /// <inheritdoc/>
    public class Problem2 : IProblem
    {
        /// <inheritdoc/>
        public string Solve()
        {
            var previousNumber = 1;
            var currentNumber = 1;
            var sum = 0;
            while (currentNumber <= 4000000)
            {
                if (currentNumber % 2 == 0)
                {
                    sum += currentNumber;
                }

                var nextNumber = previousNumber + currentNumber;
                previousNumber = currentNumber;
                currentNumber = nextNumber;
            }

            return sum.ToString(CultureInfo.InvariantCulture);
        }
    }
}
