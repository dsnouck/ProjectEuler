// <copyright file="Problem3Tests.cs" company="Daniel Snouck">
// Copyright (c) Daniel Snouck. All rights reserved.
// Licensed under the MIT License. See LICENSE file in the solution root for full license information.
// </copyright>

namespace ProjectEuler.Problems.Tests
{
    using FluentAssertions;
    using Xunit;

    /// <summary>
    /// Provides tests for <see cref="Problem3"/>.
    /// </summary>
    public class Problem3Tests
    {
        private readonly Problem3 problem;

        /// <summary>
        /// Initializes a new instance of the <see cref="Problem3Tests"/> class.
        /// </summary>
        public Problem3Tests()
        {
            this.problem = new Problem3();
        }

        /// <summary>
        /// Tests <see cref="Problem3.Solve()"/>.
        /// </summary>
        [Fact]
        public void WhenSolveIsCalledThenTheCorrectAnswerIsReturned()
        {
            // Act.
            var solution = this.problem.Solve();

            // Assert.
            solution.Should().Be("6857");
        }
    }
}
