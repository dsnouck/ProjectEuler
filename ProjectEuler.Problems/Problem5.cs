// <copyright file="Problem5.cs" company="Daniel Snouck">
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
    public class Problem5 : IProblem
    {
        private readonly IHelper helper;

        /// <summary>
        /// Initializes a new instance of the <see cref="Problem5"/> class.
        /// </summary>
        public Problem5()
        {
            this.helper = new Helper();
        }

        /// <inheritdoc/>
        public string Solve()
        {
            const int minimum = 1;
            const int maximum = 20;
            var factorsWithMaximumMultiplicity = new Dictionary<int, int>();
            for (var number = minimum; number <= maximum; number++)
            {
                var factors = this.helper.Factorize(number);
                var factorsWithMultiplicity = factors
                    .GroupBy(factor => factor)
                    .ToDictionary(group => group.Key, group => group.Count());
                foreach (var factorWithMultiplicity in factorsWithMultiplicity)
                {
                    var factor = factorWithMultiplicity.Key;
                    var multiplicity = factorWithMultiplicity.Value;
                    if (!factorsWithMaximumMultiplicity.ContainsKey(factor))
                    {
                        factorsWithMaximumMultiplicity[factor] = multiplicity;
                    }
                    else
                    {
                        var maximumMultiplicity = factorsWithMaximumMultiplicity[factor];
                        factorsWithMaximumMultiplicity[factor] = Math.Max(maximumMultiplicity, multiplicity);
                    }
                }
            }

            var product = 1;
            foreach (var factorWithMaximumMultiplicity in factorsWithMaximumMultiplicity)
            {
                var factor = factorWithMaximumMultiplicity.Key;
                var multiplicity = factorWithMaximumMultiplicity.Value;
                for (var index = 0; index < multiplicity; index++)
                {
                    product *= factor;
                }
            }

            return product.ToString(CultureInfo.InvariantCulture);
        }
    }
}
