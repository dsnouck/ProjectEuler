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
            var solution = 0;
            for (var number = 1; number < 1000; number++)
            {
                if (number % 3 == 0 || number % 5 == 0)
                {
                    solution += number;
                }
            }

            return solution.ToString(CultureInfo.InvariantCulture);
        }
    }
}
