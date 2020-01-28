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
            const int maximum = 4000000;
            var previousNumber = 0;
            var currentNumber = 2;
            var sum = 0;
            while (currentNumber <= maximum)
            {
                sum += currentNumber;
                var nextNumber = previousNumber + (4 * currentNumber);
                previousNumber = currentNumber;
                currentNumber = nextNumber;
            }

            return sum.ToString(CultureInfo.InvariantCulture);
        }
    }
}
