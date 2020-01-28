// <copyright file="Problem3.cs" company="Daniel Snouck">
// Copyright (c) Daniel Snouck. All rights reserved.
// Licensed under the MIT License. See LICENSE file in the solution root for full license information.
// </copyright>

namespace ProjectEuler.Problems
{
    using System.Globalization;
    using System.Linq;

    /// <inheritdoc/>
    public class Problem3 : IProblem
    {
        private readonly IHelper helper;

        /// <summary>
        /// Initializes a new instance of the <see cref="Problem3"/> class.
        /// </summary>
        public Problem3()
        {
            this.helper = new Helper();
        }

        /// <inheritdoc/>
        public string Solve()
        {
            var number = 600851475143L;
            var factors = this.helper.Factorize(number);
            return factors.Max().ToString(CultureInfo.InvariantCulture);
        }
    }
}
