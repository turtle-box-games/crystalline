using System;

namespace Crystalline.Geometry
{
    public struct Line2I : IPrimitive, IEquatable<Line2I>
    {
        public Point2I PointA { get; }
        
        public Point2I PointB { get; }
        
        public double Length { get; }

        public Line2I(Point2I pointA, Point2I pointB)
        {
            throw new NotImplementedException();
        }

        public Line2I Flip()
        {
            throw new NotImplementedException();
        }
        
        public override string ToString()
        {
            throw new NotImplementedException();
        }
        
        public bool Equals(Line2I other)
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
        
        public static bool operator ==(Line2I left, Line2I right)
        {
            throw new NotImplementedException();
        }
        
        public static bool operator !=(Line2I left, Line2I right)
        {
            throw new NotImplementedException();
        }
    }
}