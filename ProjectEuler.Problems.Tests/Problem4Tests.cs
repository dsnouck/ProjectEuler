// <copyright file="Problem4Tests.cs" company="Daniel Snouck">
// Copyright (c) Daniel Snouck. All rights reserved.
// Licensed under the MIT License. See LICENSE file in the solution root for full license information.
// </copyright>

namespace ProjectEuler.Problems.Tests
{
    using FluentAssertions;
    using Xunit;

    /// <summary>
    /// Provides tests for <see cref="Problem4"/>.
    /// </summary>
    public class Problem4Tests
    {
        private readonly Problem4 problem;

        /// <summary>
        /// Initializes a new instance of the <see cref="Problem4Tests"/> class.
        /// </summary>
        public Problem4Tests()
        {
            this.problem = new Problem4();
        }

        /// <summary>
        /// Tests <see cref="Problem4.Solve()"/>.
        /// </summary>
        [Fact]
        public void WhenSolveIsCalledThenTheCorrectAnswerIsReturned()
        {
            // Act.
            var solution = this.problem.Solve();

            // Assert.
            solution.Should().Be("906609");
        }
    }
}
