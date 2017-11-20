using System;
using System.Collections;
using System.Collections.Generic;

namespace Crystalline
{
    /// <summary>
    /// Discrete range of integer values.
    /// </summary>
    public struct Range : IReadOnlyCollection<int>, IEquatable<Range>
    {
        /// <summary>
        /// First, inclusive value in the range.
        /// </summary>
        public int Start { get; }
        
        /// <summary>
        /// Last, exclusive value in the range.
        /// </summary>
        public int End { get; }

        /// <summary>
        /// Number of integers in the range.
        /// </summary>
        public int Count { get; }

        /// <summary>
        /// Checks whether a value is within the range.
        /// </summary>
        /// <param name="value">Value to check.</param>
        /// <returns>True if the range contains the value, or false if it doesn't.</returns>
        public bool Contains(int value)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Checks whether this value completely encompasses another range.
        /// </summary>
        /// <param name="other">Range to check against.</param>
        /// <returns>True if <paramref name="other"/> is entirely contained within this range.</returns>
        public bool Contains(Range other)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Checks whether this range overlaps with another range.
        /// </summary>
        /// <param name="other">Range to check against.</param>
        /// <returns>True if <paramref name="other"/> overlaps partially or entirely with this range.</returns>
        public bool Overlaps(Range other)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Creates an enumerator to iterate over integers in the range.
        /// </summary>
        /// <returns>Integer enumerator.</returns>
        public IEnumerator<int> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Creates an enumerator to iterate over integers in the range with a specified step.
        /// </summary>
        /// <param name="step">Amount to increment for each step.</param>
        /// <returns>Integer step enumerator.</returns>
        public IEnumerator<int> GetEnumerator(int step)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Creates an enumerator to iterate over integers in the range.
        /// </summary>
        /// <returns>Integer enumerator.</returns>
        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Checks whether this range is equal to another one.
        /// </summary>
        /// <param name="other">Other range to compare against.</param>
        /// <returns>True if the ranges are identical, false otherwise.</returns>
        public bool Equals(Range other)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Compares this instance to another.
        /// </summary>
        /// <param name="obj">Other instance to compare against.</param>
        /// <returns>True if the instance is a range with the same values.</returns>
        public override bool Equals(object obj)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Generates a hash code from the values in the range.
        /// </summary>
        /// <returns>A hash code.</returns>
        public override int GetHashCode()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Compares two ranges to determine whether they are equal.
        /// </summary>
        /// <param name="left">First range to compare.</param>
        /// <param name="right">Second range to compare.</param>
        /// <returns>True if the ranges are identical, false if they're different.</returns>
        public static bool operator ==(Range left, Range right)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Compares two ranges to determine whether they are different.
        /// </summary>
        /// <param name="left">First range to compare.</param>
        /// <param name="right">Second range to compare.</param>
        /// <returns>True if the ranges are different, false if they're the same.</returns>
        /// <exception cref="NotImplementedException"></exception>
        public static bool operator !=(Range left, Range right)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Enumerator for iterating over values in a range.
        /// </summary>
        private class Enumerator : IEnumerator<int>
        {
            /// <summary>
            /// Creates the enumerator.
            /// </summary>
            /// <param name="lower">Lower bound on the range.</param>
            /// <param name="upper">Upper (non-inclusive) bound on the range.</param>
            /// <param name="step">Amount to increment each iteration.</param>
            public Enumerator(int lower, int upper, int step = 1)
            {
                throw new NotImplementedException();
            }
            
            /// <summary>
            /// Cleans up resources used by the enumerator.
            /// </summary>
            public void Dispose()
            {
                throw new NotImplementedException();
            }

            /// <summary>
            /// Advances to the next value in the range.
            /// </summary>
            /// <returns>True while the end of the range hasn't been reached.</returns>
            public bool MoveNext()
            {
                throw new NotImplementedException();
            }

            /// <summary>
            /// Resets the enumerator back to be start of the range.
            /// </summary>
            public void Reset()
            {
                throw new NotImplementedException();
            }

            /// <summary>
            /// Retrieves the current value of the iteration.
            /// </summary>
            public int Current { get; }

            /// <summary>
            /// Retrieves the current value of the interation.
            /// </summary>
            object IEnumerator.Current => Current;
        }
    }
}