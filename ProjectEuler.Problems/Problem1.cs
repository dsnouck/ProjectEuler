// <copyright file="Problem1.cs" company="Daniel Snouck">
// Copyright (c) Daniel Snouck. All rights reserved.
// Licensed under the MIT License. See LICENSE file in the solution root for full license information.
// </copyright>

namespace ProjectEuler.Problems
{
    using System.Globalization;

    /// <inheritdoc/>
    public class Problem1 : IProblem
    {
        /// <inheritdoc/>
        public string Solve()
        {
            const int maximum = 999;
            var solution = SumOfMultiples(3, maximum) + SumOfMultiples(5, maximum) - SumOfMultiples(15, maximum);
            return solution.ToString(CultureInfo.InvariantCulture);
        }

        private static int SumOfMultiples(int factor, int maximum)
        {
            var count = maximum / factor;
            return factor * count * (count + 1) / 2;
        }
    }
}
