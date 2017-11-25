using System;

namespace Crystalline.Geometry
{
    public struct Rect2D : IPrimitive, IEquatable<Rect2D>
    {
        public double X { get; }
        
        public double Y { get; }
        
        public double Width { get; }
        
        public double Height { get; }

        public Rect2D(double x, double y, double width, double height)
        {
            throw new NotImplementedException();
        }

        public Rect2D(Point2D topLeft, Point2D bottomRight)
        {
            throw new NotImplementedException();
        }
        
        public override string ToString()
        {
            throw new NotImplementedException();
        }
        
        public bool Equals(Rect2D other)
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
        
        public static bool operator ==(Rect2D left, Rect2D right)
        {
            throw new NotImplementedException();
        }
        
        public static bool operator !=(Rect2D left, Rect2D right)
        {
            throw new NotImplementedException();
        }
    }
}