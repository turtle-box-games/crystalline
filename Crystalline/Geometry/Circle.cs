using System;

namespace Crystalline.Geometry
{
    public struct Circle : IPrimitive, IEquatable<Circle>
    {
        public double X { get; }
        
        public double Y { get; }
        
        public double Radius { get; }

        public Circle(double x, double y, double radius)
        {
            throw new NotImplementedException();
        }

        public Circle(Point2D center, double radius)
        {
            throw new NotImplementedException();
        }
        
        public override string ToString()
        {
            throw new NotImplementedException();
        }
        
        public bool Equals(Circle other)
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
        
        public static bool operator ==(Circle left, Circle right)
        {
            throw new NotImplementedException();
        }
        
        public static bool operator !=(Circle left, Circle right)
        {
            throw new NotImplementedException();
        }
    }
}