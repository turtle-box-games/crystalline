using System;

namespace Crystalline.Geometry
{
    /// <summary>
    /// Three-dimensional point.
    /// X, Y, and Z coordinate values are represented as integers.
    /// </summary>
    /// <remarks>This structure is ideal for tracking positions and depth in user interfaces.</remarks>
    public struct Point3I : IPrimitive, IEquatable<Point3I>
    {
        /// <summary>
        /// Point at the center of the coordinate grid.
        /// </summary>
        public static readonly Point3I Origin = new Point3I(0, 0, 0);
        
        /// <summary>
        /// X-coordinate of the point.
        /// </summary>
        public int X { get; }

        /// <summary>
        /// Y-coordinate of the point.
        /// </summary>
        public int Y { get; }

        /// <summary>
        /// Y-coordinate of the point.
        /// </summary>
        public int Z { get; }

        /// <summary>
        /// Creates a new three-dimensional point.
        /// </summary>
        /// <param name="x">Value of the x-coordinate.</param>
        /// <param name="y">Value of the y-coordinate.</param>
        /// <param name="z">Value of the z-coordinate.</param>
        public Point3I(int x, int y, int z)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Creates a string representation of the point.
        /// </summary>
        /// <returns>Point in the format: (x, y, z)</returns>
        public override string ToString()
        {
            throw new NotImplementedException();
        }
        
        /// <summary>
        /// Compares this point to another to determine whether they are the same.
        /// </summary>
        /// <param name="other">Point to compare against.</param>
        /// <returns>True if the points are equal, false otherwise.</returns>
        public bool Equals(Point3I other)
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
        public static bool operator ==(Point3I left, Point3I right)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Checks whether two points are different.
        /// </summary>
        /// <param name="left">First point to compare.</param>
        /// <param name="right">Second point to compare.</param>
        /// <returns>True if the points are different, or false if they're identical.</returns>
        public static bool operator !=(Point3I left, Point3I right)
        {
            throw new NotImplementedException();
        }
    }
}