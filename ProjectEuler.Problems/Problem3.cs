// <copyright file="Problem3.cs" company="Daniel Snouck">
// Copyright (c) Daniel Snouck. All rights reserved.
// Licensed under the MIT License. See LICENSE file in the solution root for full license information.
// </copyright>

namespace ProjectEuler.Problems
{
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;

    /// <inheritdoc/>
    public class Problem3 : IProblem
    {
        /// <inheritdoc/>
        public string Solve()
        {
            var number = 600851475143L;
            var factors = new List<long>();
            var factor = 2L;
            while (factor <= number)
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

            return factors.Last().ToString(CultureInfo.InvariantCulture);
        }
    }
}
