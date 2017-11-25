using System;

namespace Crystalline.Geometry
{
    public struct Tri3D : IPrimitive, IEquatable<Tri3D>
    {
        public Point3D PointA { get; }
        
        public Point3D PointB { get; }
        
        public Point3D PointC { get; }

        public Tri3D(Point3D pointA, Point3D pointB, Point3D pointC)
        {
            throw new NotImplementedException();
        }
        
        public override string ToString()
        {
            throw new NotImplementedException();
        }
        
        public bool Equals(Tri3D other)
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
        
        public static bool operator ==(Tri3D left, Tri3D right)
        {
            throw new NotImplementedException();
        }
        
        public static bool operator !=(Tri3D left, Tri3D right)
        {
            throw new NotImplementedException();
        }
    }
}