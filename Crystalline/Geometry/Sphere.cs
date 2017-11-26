using System;

namespace Crystalline.Geometry
{
    public struct Sphere : IPrimitive, IEquatable<Sphere>
    {
        public double X { get; }
        
        public double Y { get; }
        
        public double Z { get; }
        
        public double Radius { get; }

        public Sphere(double x, double y, double z, double radius)
        {
            throw new NotImplementedException();
        }

        public Sphere(Point3D center, double radius)
        {
            throw new NotImplementedException();
        }
        
        public override string ToString()
        {
            throw new NotImplementedException();
        }
        
        public bool Equals(Sphere other)
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
        
        public static bool operator ==(Sphere left, Sphere right)
        {
            throw new NotImplementedException();
        }
        
        public static bool operator !=(Sphere left, Sphere right)
        {
            throw new NotImplementedException();
        }
    }
}