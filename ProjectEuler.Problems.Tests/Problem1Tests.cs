// <copyright file="Problem1Tests.cs" company="Daniel Snouck">
// Copyright (c) Daniel Snouck. All rights reserved.
// Licensed under the MIT License. See LICENSE file in the solution root for full license information.
// </copyright>

namespace ProjectEuler.Problems.Tests
{
    using FluentAssertions;
    using Xunit;

    /// <summary>
    /// Provides tests for <see cref="Problem1"/>.
    /// </summary>
    public class Problem1Tests
    {
        private readonly Problem1 problem;

        /// <summary>
        /// Initializes a new instance of the <see cref="Problem1Tests"/> class.
        /// </summary>
        public Problem1Tests()
        {
            this.problem = new Problem1();
        }

        /// <summary>
        /// Tests <see cref="Problem1.Solve()"/>.
        /// </summary>
        [Fact]
        public void WhenSolveIsCalledThenTheCorrectAnswerIsReturned()
        {
            // Act.
            var solution = this.problem.Solve();

            // Assert.
            solution.Should().Be("233168");
        }
    }
}
