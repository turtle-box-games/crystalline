using System;

namespace Crystalline.Geometry
{
    public struct Rect3D : IPrimitive, IEquatable<Rect3D>
    {
        public double X { get; }
        
        public double Y { get; }
        
        public double Z { get; }
        
        public double Width { get; }
        
        public double Height { get; }
        
        public double Depth { get; }

        public Rect3D(double x, double y, double z, double width, double height, double depth)
        {
            throw new NotImplementedException();
        }

        public Rect3D(Point3D topFrontLeft, Point3D bottomBackRight)
        {
            throw new NotImplementedException();
        }
        
        public override string ToString()
        {
            throw new NotImplementedException();
        }
        
        public bool Equals(Rect3D other)
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
        
        public static bool operator ==(Rect3D left, Rect3D right)
        {
            throw new NotImplementedException();
        }
        
        public static bool operator !=(Rect3D left, Rect3D right)
        {
            throw new NotImplementedException();
        }
    }
}