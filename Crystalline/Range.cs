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

        public bool Equals(Range other)
        {
            throw new NotImplementedException();
        }

        public override bool Equals(object obj)
        {
            throw new NotImplementedException();
        }

        public override int GetHashCode()
        {
            throw new NotImplementedException();
        }

        public static bool operator ==(Range left, Range right)
        {
            throw new NotImplementedException();
        }

        public static bool operator !=(Range left, Range right)
        {
            throw new NotImplementedException();
        }

        private class Enumerator : IEnumerator<int>
        {
            public Enumerator(int lower, int upper, int step = 1)
            {
                throw new NotImplementedException();
            }
            
            public void Dispose()
            {
                throw new NotImplementedException();
            }

            public bool MoveNext()
            {
                throw new NotImplementedException();
            }

            public void Reset()
            {
                throw new NotImplementedException();
            }

            public int Current { get; }

            object IEnumerator.Current
            {
                get { return Current; }
            }
        }
    }
}