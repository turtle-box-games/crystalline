using System;

namespace Crystalline.Geometry
{
    public struct Tri2D : IEquatable<Tri2D>
    {
        public Point2D PointA { get; }
        
        public Point2D PointB { get; }
        
        public Point2D PointC { get; }

        public Tri2D(Point2D pointA, Point2D pointB, Point2D pointC)
        {
            throw new NotImplementedException();
        }
        
        public override string ToString()
        {
            throw new NotImplementedException();
        }
        
        public bool Equals(Tri2D other)
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
        
        public static bool operator ==(Tri2D left, Tri2D right)
        {
            throw new NotImplementedException();
        }
        
        public static bool operator !=(Tri2D left, Tri2D right)
        {
            throw new NotImplementedException();
        }
    }
}