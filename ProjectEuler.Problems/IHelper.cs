// <copyright file="IHelper.cs" company="Daniel Snouck">
// Copyright (c) Daniel Snouck. All rights reserved.
// Licensed under the MIT License. See LICENSE file in the solution root for full license information.
// </copyright>

namespace ProjectEuler.Problems
{
    using System.Collections.Generic;

    /// <summary>
    /// Provides operations that help solving problems.
    /// </summary>
    public interface IHelper
    {
        /// <summary>
        /// Extracts the digits of a number in the given base.
        /// </summary>
        /// <param name="number">The number.</param>
        /// <param name="numberBase">The base.</param>
        /// <returns>The digits of the number in the given base.</returns>
        List<int> Digits(int number, int numberBase = 10);

        /// <summary>
        /// Factorizes a number.
        /// </summary>
        /// <param name="number">The number.</param>
        /// <returns>The factors of the number.</returns>
        List<long> Factorize(long number);

        /// <summary>
        /// Determines whether a number is a palindrome in the given base.
        /// </summary>
        /// <param name="number">The number.</param>
        /// <param name="numberBase">The base.</param>
        /// <returns>Whether the number is a palindrome in the given base.</returns>
        bool IsPalindrome(int number, int numberBase = 10);

        /// <summary>
        /// Calculates the sum of the multiples of a number with the given maximum.
        /// </summary>
        /// <param name="number">The number.</param>
        /// <param name="maximum">The maximum.</param>
        /// <returns>The sum of the multiples with the given maximum.</returns>
        int SumOfMultiples(int number, int maximum);
    }
}