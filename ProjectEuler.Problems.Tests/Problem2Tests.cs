// <copyright file="Problem2Tests.cs" company="Daniel Snouck">
// Copyright (c) Daniel Snouck. All rights reserved.
// Licensed under the MIT License. See LICENSE file in the solution root for full license information.
// </copyright>

namespace ProjectEuler.Problems.Tests
{
    using FluentAssertions;
    using Xunit;

    /// <summary>
    /// Provides tests for <see cref="Problem2"/>.
    /// </summary>
    public class Problem2Tests
    {
        private readonly Problem2 problem;

        /// <summary>
        /// Initializes a new instance of the <see cref="Problem2Tests"/> class.
        /// </summary>
        public Problem2Tests()
        {
            this.problem = new Problem2();
        }

        /// <summary>
        /// Tests <see cref="Problem2.Solve()"/>.
        /// </summary>
        [Fact]
        public void WhenSolveIsCalledThenTheCorrectAnswerIsReturned()
        {
            // Act.
            var solution = this.problem.Solve();

            // Assert.
            solution.Should().Be("4613732");
        }
    }
}
