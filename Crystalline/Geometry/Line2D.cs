using System;

namespace Crystalline.Geometry
{
    public struct Line2D : IPrimitive, IEquatable<Line2D>
    {
        public Point2D PointA { get; }
        
        public Point2D PointB { get; }
        
        public int Length { get; }

        public Line2D(Point2D pointA, Point2D pointB)
        {
            throw new NotImplementedException();
        }

        public Line2D Flip()
        {
            throw new NotImplementedException();
        }
        
        public override string ToString()
        {
            throw new NotImplementedException();
        }
        
        public bool Equals(Line2D other)
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
        
        public static bool operator ==(Line2D left, Line2D right)
        {
            throw new NotImplementedException();
        }
        
        public static bool operator !=(Line2D left, Line2D right)
        {
            throw new NotImplementedException();
        }
    }
}