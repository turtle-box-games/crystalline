using System;

namespace Crystalline.Geometry
{
    /// <summary>
    /// Representation of a direction and distance in two-dimensional space.
    /// </summary>
    /// <remarks>All angles are corrected to be within 0 to 2*PI radians.</remarks>
    /// <remarks>Even though a vector is mathematically defined as an angle and magnitude,
    /// the X and Y components are stored for faster computations.</remarks>
    public struct Vector2D : IEquatable<Vector2D>
    {
        /// <summary>
        /// Direction of the vector in radians.
        /// </summary>
        public double Angle { get; }
        
        /// <summary>
        /// Distance of the vector.
        /// </summary>
        public double Magnitude { get; }
        
        /// <summary>
        /// Magnitude along the x-axis.
        /// </summary>
        public double X { get; }
        
        /// <summary>
        /// Magnitude along the y-axis.
        /// </summary>
        public double Y { get; }

        /// <summary>
        /// Creates a new two-dimensional vector.
        /// </summary>
        /// <param name="angle">Direction of the vector in radians.</param>
        /// <param name="magnitude">Distance of the vector.</param>
        public Vector2D(double angle, double magnitude)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Creates a new two-dimensional vector from x and y magnitudes.
        /// </summary>
        /// <param name="point">X and Y magnitudes.</param>
        public Vector2D(Point2D point)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Creates a new two-dimensional vector from the vector created between two points.
        /// </summary>
        /// <param name="source">Point the vector starts at.</param>
        /// <param name="dest">Point the vector ends at.</param>
        public Vector2D(Point2D source, Point2D dest)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Creates a new vector by rotating the current one.
        /// </summary>
        /// <param name="theta">Angle in radians to rotate the vector by.</param>
        /// <returns>New rotated vector.</returns>
        public Vector2D Rotate(double theta)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Creates a new vector by scaling the current one.
        /// </summary>
        /// <param name="factor">Scaling factor to apply.</param>
        /// <returns>New scaled vector.</returns>
        public Vector2D Scale(double factor)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Creates a new unit vector by normalizing the current one.
        /// The magnitude will be one on the resulting vector.
        /// </summary>
        /// <returns>Normalized unit vector.</returns>
        public Vector2D Normalize()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Creates a vector that cancels out the current one.
        /// The resulting vector will have a 180 degree difference and negative magnitude.
        /// </summary>
        /// <returns>Flipped vector.</returns>
        public Vector2D Opposite()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Calculates the cross-product between two vectors.
        /// </summary>
        /// <param name="vector">Other vector to perform calculation with.</param>
        /// <returns>Cross product result - zero meaning the vectors are colinear.</returns>
        public double CrossProduct(Vector2D vector)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Calculates the dot-product between two vectors.
        /// </summary>
        /// <param name="vector">Other vector to perform calculation with.</param>
        /// <returns>Dot product result - zero meaning the vectors are orthogonal.</returns>
        public double DotProduct(Vector2D vector)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Projects the current vector onto another one.
        /// </summary>
        /// <param name="vector">Vector to project onto.</param>
        /// <returns>Calculated vector.</returns>
        public Vector2D Project(Vector2D vector)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Determines whether this vector and another are parallel.
        /// </summary>
        /// <param name="vector">Other vector to compare against.</param>
        /// <param name="within">Tolerance between the angles of the vectors to still be considered colinear.</param>
        /// <returns>True if the vectors are considered parallel.</returns>
        public bool IsColinear(Vector2D vector, double within = double.Epsilon)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Determines whether this vector and another are perpendicular.
        /// </summary>
        /// <param name="vector">Other vector to compare against.</param>
        /// <param name="within">Tolerance between the angles of the vectors to still be considered orthogonal.</param>
        /// <returns>True if the vectors are considered perpendicular.</returns>
        public bool IsOrthogonal(Vector2D vector, double within = double.Epsilon)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Creates a string representation of the vector.
        /// </summary>
        /// <returns>Vector in the format: [x, y]</returns>
        public override string ToString()
        {
            throw new NotImplementedException();
        }
        
        /// <summary>
        /// Compares this vector to another to determine whether they are the same.
        /// </summary>
        /// <param name="other">Vector to compare against.</param>
        /// <returns>True if the vectors are equal, false otherwise.</returns>
        public bool Equals(Vector2D other)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Determines whether this instance is equal to another.
        /// </summary>
        /// <param name="obj">Other instance to compare against.</param>
        /// <returns>True if the other instance is a vector with the same values.</returns>
        public override bool Equals(object obj)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Computes a hash code from the vector's values.
        /// </summary>
        /// <returns>Hash code.</returns>
        public override int GetHashCode()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Checks whether two vectors are equal.
        /// </summary>
        /// <param name="left">First vector to compare.</param>
        /// <param name="right">Second vector to compare.</param>
        /// <returns>True if the vectors are identical, false otherwise.</returns>
        public static bool operator ==(Vector2D left, Vector2D right)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Checks whether two vectors are different.
        /// </summary>
        /// <param name="left">First vector to compare.</param>
        /// <param name="right">Second vector to compare.</param>
        /// <returns>True if the vectors are different, or false if they're identical.</returns>
        public static bool operator !=(Vector2D left, Vector2D right)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Adds two vectors together.
        /// </summary>
        /// <param name="left">First vector to add.</param>
        /// <param name="right">Second vector to add.</param>
        /// <returns>Result of adding the two vectors.</returns>
        public static Vector2D operator +(Vector2D left, Vector2D right)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Subtracts a vector from another.
        /// </summary>
        /// <param name="left">Vector to subtract from.</param>
        /// <param name="right">Vector to subtract.</param>
        /// <returns>Rersult of subtracting the second vector from the first.</returns>
        public static Vector2D operator -(Vector2D left, Vector2D right)
        {
            throw new NotImplementedException();
        }
    }
}