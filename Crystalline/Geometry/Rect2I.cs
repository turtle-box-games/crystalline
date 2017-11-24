using System;

namespace Crystalline.Geometry
{
    public struct Rect2I : IEquatable<Rect2I>
    {
        public int X { get; }
        
        public int Y { get; }
        
        public int Width { get; }
        
        public int Height { get; }

        public Rect2I(int x, int y, int width, int height)
        {
            throw new NotImplementedException();
        }

        public Rect2I(Point2I topLeft, Point2I bottomRight)
        {
            throw new NotImplementedException();
        }
        
        public override string ToString()
        {
            throw new NotImplementedException();
        }
        
        public bool Equals(Rect2I other)
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
        
        public static bool operator ==(Rect2I left, Rect2I right)
        {
            throw new NotImplementedException();
        }
        
        public static bool operator !=(Rect2I left, Rect2I right)
        {
            throw new NotImplementedException();
        }
    }
}