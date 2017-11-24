using System;

namespace Crystalline.Geometry
{
    public struct Line3D : IEquatable<Line3D>
    {
        public Point3D PointA { get; }
        
        public Point3D PointB { get; }
        
        public int Length { get; }

        public Line3D(Point3D pointA, Point3D pointB)
        {
            throw new NotImplementedException();
        }
        
        public override string ToString()
        {
            throw new NotImplementedException();
        }
        
        public bool Equals(Line3D other)
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
        
        public static bool operator ==(Line3D left, Line3D right)
        {
            throw new NotImplementedException();
        }
        
        public static bool operator !=(Line3D left, Line3D right)
        {
            throw new NotImplementedException();
        }
    }
}