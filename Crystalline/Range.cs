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
        public int Count => End - Start;

        /// <summary>
        /// Creates a new range of values.
        /// </summary>
        /// <param name="start">Start of the range - inclusive.</param>
        /// <param name="end">End of the range - exclusive.</param>
        /// <exception cref="ArgumentException">The end of the range must be after the start.</exception>
        public Range(int start, int end)
        {
            if(end <= start)
                throw new ArgumentException("End of range must be after start.");
            Start = start;
            End   = end;
        }

        /// <summary>
        /// Checks whether a value is within the range.
        /// </summary>
        /// <param name="value">Value to check.</param>
        /// <returns>True if the range contains the value, or false if it doesn't.</returns>
        public bool Contains(int value)
        {
            return value >= Start && value < End;
        }

        /// <summary>
        /// Checks whether this value completely encompasses another range.
        /// </summary>
        /// <param name="other">Range to check against.</param>
        /// <returns>True if <paramref name="other"/> is entirely contained within this range.</returns>
        public bool Contains(Range other)
        {
            return Start <= other.Start && End >= other.End;
        }

        /// <summary>
        /// Checks whether this range overlaps with another range.
        /// </summary>
        /// <param name="other">Range to check against.</param>
        /// <returns>True if <paramref name="other"/> overlaps partially or entirely with this range.</returns>
        public bool Overlaps(Range other)
        {
            return Start < other.End && other.Start < End;
        }

        /// <summary>
        /// Creates an enumerator to iterate over integers in the range.
        /// </summary>
        /// <returns>Integer enumerator.</returns>
        public IEnumerator<int> GetEnumerator()
        {
            return new Enumerator(Start, End);
        }

        /// <summary>
        /// Creates an enumerator to iterate over integers in the range with a specified step.
        /// </summary>
        /// <param name="step">Amount to increment for each step.</param>
        /// <returns>Integer step enumerator.</returns>
        /// <exception cref="ArgumentOutOfRangeException"><paramref name="step"/> must be greater than zero.</exception>
        public IEnumerator<int> GetEnumerator(int step)
        {
            if(step < 1)
                throw new ArgumentOutOfRangeException(nameof(step), "Step must be greater than zero.");
            return new Enumerator(Start, End, step);
        }

        /// <summary>
        /// Creates an enumerator to iterate over integers in the range.
        /// </summary>
        /// <returns>Integer enumerator.</returns>
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        /// <summary>
        /// Checks whether this range is equal to another one.
        /// </summary>
        /// <param name="other">Other range to compare against.</param>
        /// <returns>True if the ranges are identical, false otherwise.</returns>
        public bool Equals(Range other)
        {
            return Start == other.Start && End == other.End;
        }

        /// <summary>
        /// Compares this instance to another.
        /// </summary>
        /// <param name="obj">Other instance to compare against.</param>
        /// <returns>True if the instance is a range with the same values.</returns>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            return obj is Range range && Equals(range);
        }

        /// <summary>
        /// Generates a hash code from the values in the range.
        /// </summary>
        /// <returns>A hash code.</returns>
        public override int GetHashCode()
        {
            unchecked
            {
                return (Start * 397) ^ End;
            }
        }

        /// <summary>
        /// Compares two ranges to determine whether they are equal.
        /// </summary>
        /// <param name="left">First range to compare.</param>
        /// <param name="right">Second range to compare.</param>
        /// <returns>True if the ranges are identical, false if they're different.</returns>
        public static bool operator ==(Range left, Range right)
        {
            return left.Equals(right);
        }

        /// <summary>
        /// Compares two ranges to determine whether they are different.
        /// </summary>
        /// <param name="left">First range to compare.</param>
        /// <param name="right">Second range to compare.</param>
        /// <returns>True if the ranges are different, false if they're the same.</returns>
        public static bool operator !=(Range left, Range right)
        {
            return !left.Equals(right);
        }

        /// <summary>
        /// Enumerator for iterating over values in a range.
        /// </summary>
        private class Enumerator : IEnumerator<int>
        {
            private readonly int _lower, _upper, _step;
            
            /// <summary>
            /// Creates the enumerator.
            /// </summary>
            /// <param name="lower">Lower bound on the range.</param>
            /// <param name="upper">Upper (non-inclusive) bound on the range.</param>
            /// <param name="step">Amount to increment each iteration.</param>
            public Enumerator(int lower, int upper, int step = 1)
            {
                _lower  = lower;
                _upper  = upper;
                _step   = step;
                Current = lower - _step;
            }
            
            /// <summary>
            /// Cleans up resources used by the enumerator.
            /// </summary>
            public void Dispose()
            {
                // ...
            }

            /// <summary>
            /// Advances to the next value in the range.
            /// </summary>
            /// <returns>True while the end of the range hasn't been reached.</returns>
            public bool MoveNext()
            {
                if (Current + _step < _upper)
                {
                    Current += _step;
                    return true;
                }
                return false;
            }

            /// <summary>
            /// Resets the enumerator back to be start of the range.
            /// </summary>
            public void Reset()
            {
                Current = _lower - _step;
            }

            /// <summary>
            /// Retrieves the current value of the iteration.
            /// </summary>
            public int Current { get; private set; }

            /// <summary>
            /// Retrieves the current value of the interation.
            /// </summary>
            object IEnumerator.Current => Current;
        }
    }
}