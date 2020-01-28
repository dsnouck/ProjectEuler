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
        private readonly IHelper helper;

        /// <summary>
        /// Initializes a new instance of the <see cref="Problem1"/> class.
        /// </summary>
        public Problem1()
        {
            this.helper = new Helper();
        }

        /// <inheritdoc/>
        public string Solve()
        {
            const int maximum = 999;
            var solution = this.helper.SumOfMultiples(3, maximum)
                + this.helper.SumOfMultiples(5, maximum)
                - this.helper.SumOfMultiples(15, maximum);
            return solution.ToString(CultureInfo.InvariantCulture);
        }
    }
}
