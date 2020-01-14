// <copyright file="IProblem.cs" company="Daniel Snouck">
// Copyright (c) Daniel Snouck. All rights reserved.
// Licensed under the MIT License. See LICENSE file in the solution root for full license information.
// </copyright>

namespace ProjectEuler.Problems
{
    /// <summary>
    /// Provides a solution to a problem.
    /// </summary>
    public interface IProblem
    {
        /// <summary>
        /// Solves the problem.
        /// </summary>
        /// <returns>The solution.</returns>
        string Solve();
    }
}