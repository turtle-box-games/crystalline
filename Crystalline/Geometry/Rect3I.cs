using System;

namespace Crystalline.Geometry
{
    public struct Rect3I : IPrimitive, IEquatable<Rect3I>
    {
        public int X { get; }
        
        public int Y { get; }
        
        public int Z { get; }
        
        public int Width { get; }
        
        public int Height { get; }
        
        public int Depth { get; }

        public Rect3I(int x, int y, int z, int width, int height, int depth)
        {
            throw new NotImplementedException();
        }

        public Rect3I(Point3D topFrontLeft, Point3D bottomBackRight)
        {
            throw new NotImplementedException();
        }
        
        public override string ToString()
        {
            throw new NotImplementedException();
        }
        
        public bool Equals(Rect3I other)
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
        
        public static bool operator ==(Rect3I left, Rect3I right)
        {
            throw new NotImplementedException();
        }
        
        public static bool operator !=(Rect3I left, Rect3I right)
        {
            throw new NotImplementedException();
        }
    }
}