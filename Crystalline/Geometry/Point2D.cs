using System;

namespace Crystalline.Geometry
{
    /// <summary>
    /// Two-dimensional point.
    /// X and Y coordinate values are represented as floating-point numbers.
    /// </summary>
    public struct Point2D : IEquatable<Point2D>
    {
        /// <summary>
        /// Point at the center of the coordinate grid.
        /// </summary>
        public static readonly Point2D Origin = new Point2D(0d, 0d);
        
        /// <summary>
        /// X-coordinate of the point.
        /// </summary>
        public double X { get; }

        /// <summary>
        /// Y-coordinate of the point.
        /// </summary>
        public double Y { get; }

        /// <summary>
        /// Creates a new two-dimensional point.
        /// </summary>
        /// <param name="x">Value of the x-coordinate.</param>
        /// <param name="y">Value of the y-coordinate.</param>
        public Point2D(double x, double y)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Creates a string representation of the point.
        /// </summary>
        /// <returns>Point in the format: (x, y)</returns>
        public override string ToString()
        {
            throw new NotImplementedException();
        }
        
        /// <summary>
        /// Compares this point to another to determine whether they are the same.
        /// </summary>
        /// <param name="other">Point to compare against.</param>
        /// <returns>True if the points are equal, false otherwise.</returns>
        public bool Equals(Point2D other)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Determines whether this instance is equal to another.
        /// </summary>
        /// <param name="obj">Other instance to compare against.</param>
        /// <returns>True if the other instance is a point with the same values.</returns>
        public override bool Equals(object obj)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Computes a hash code from the point's values.
        /// </summary>
        /// <returns>Hash code.</returns>
        public override int GetHashCode()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Checks whether two points are equal.
        /// </summary>
        /// <param name="left">First point to compare.</param>
        /// <param name="right">Second point to compare.</param>
        /// <returns>True if the points are identical, false otherwise.</returns>
        public static bool operator ==(Point2D left, Point2D right)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Checks whether two points are different.
        /// </summary>
        /// <param name="left">First point to compare.</param>
        /// <param name="right">Second point to compare.</param>
        /// <returns>True if the points are different, or false if they're identical.</returns>
        public static bool operator !=(Point2D left, Point2D right)
        {
            throw new NotImplementedException();
        }
    }
}