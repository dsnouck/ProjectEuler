// <copyright file="Problem4.cs" company="Daniel Snouck">
// Copyright (c) Daniel Snouck. All rights reserved.
// Licensed under the MIT License. See LICENSE file in the solution root for full license information.
// </copyright>

namespace ProjectEuler.Problems
{
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;

    /// <inheritdoc/>
    public class Problem4 : IProblem
    {
        private readonly IHelper helper;

        /// <summary>
        /// Initializes a new instance of the <see cref="Problem4"/> class.
        /// </summary>
        public Problem4()
        {
            this.helper = new Helper();
        }

        /// <inheritdoc/>
        public string Solve()
        {
            const int minimum = 100;
            const int maximum = 1000;
            var palindromes = new List<int>();
            for (var number = minimum; number < maximum; number++)
            {
                for (var otherNumber = number; otherNumber < maximum; otherNumber++)
                {
                    var product = number * otherNumber;
                    if (this.helper.IsPalindrome(product))
                    {
                        palindromes.Add(product);
                    }
                }
            }

            return palindromes.Max().ToString(CultureInfo.InvariantCulture);
        }
    }
}
