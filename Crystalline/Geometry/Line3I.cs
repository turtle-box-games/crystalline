using System;

namespace Crystalline.Geometry
{
    public struct Line3I : IPrimitive, IEquatable<Line3I>
    {
        public Point3D PointA { get; }
        
        public Point3D PointB { get; }
        
        public double Length { get; }

        public Line3I(Point3I pointA, Point3I pointB)
        {
            throw new NotImplementedException();
        }

        public Line3I Flip()
        {
            throw new NotImplementedException();
        }
        
        public override string ToString()
        {
            throw new NotImplementedException();
        }
        
        public bool Equals(Line3I other)
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
        
        public static bool operator ==(Line3I left, Line3I right)
        {
            throw new NotImplementedException();
        }
        
        public static bool operator !=(Line3I left, Line3I right)
        {
            throw new NotImplementedException();
        }
    }
}