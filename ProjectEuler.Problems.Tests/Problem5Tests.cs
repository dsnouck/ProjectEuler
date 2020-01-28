// <copyright file="Problem5Tests.cs" company="Daniel Snouck">
// Copyright (c) Daniel Snouck. All rights reserved.
// Licensed under the MIT License. See LICENSE file in the solution root for full license information.
// </copyright>

namespace ProjectEuler.Problems.Tests
{
    using FluentAssertions;
    using Xunit;

    /// <summary>
    /// Provides tests for <see cref="Problem5"/>.
    /// </summary>
    public class Problem5Tests
    {
        private readonly Problem5 problem;

        /// <summary>
        /// Initializes a new instance of the <see cref="Problem5Tests"/> class.
        /// </summary>
        public Problem5Tests()
        {
            this.problem = new Problem5();
        }

        /// <summary>
        /// Tests <see cref="Problem5.Solve()"/>.
        /// </summary>
        [Fact]
        public void WhenSolveIsCalledThenTheCorrectAnswerIsReturned()
        {
            // Act.
            var solution = this.problem.Solve();

            // Assert.
            solution.Should().Be("232792560");
        }
    }
}
