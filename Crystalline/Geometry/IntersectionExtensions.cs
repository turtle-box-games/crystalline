using System;

namespace Crystalline.Geometry
{
    public static class IntersectionExtensions
    {
        #region Rect2I

        public static bool Contains(this Rect2I rect, Point2I point)
        {
            throw new NotImplementedException();
        }
        
        public static bool Contains(this Rect2I rect, Rect2I other)
        {
            throw new NotImplementedException();
        }
        
        #endregion
        
        #region Rect2D
        
        public static bool Contains(this Rect2D rect, Point2D point)
        {
            throw new NotImplementedException();
        }

        public static bool Contains(this Rect2D rect, Rect2D other)
        {
            throw new NotImplementedException();
        }

        public static bool Contains(this Rect2D rect, Line2D line)
        {
            throw new NotImplementedException();
        }

        public static bool Intersects(this Rect2D rect, Rect2D other)
        {
            throw new NotImplementedException();
        }

        public static bool Intersects(this Rect2D rect, Line2D line)
        {
            throw new NotImplementedException();
        }
        
        #endregion
        
        #region Rect3I

        public static bool Contains(this Rect3I rect, Point3I point)
        {
            throw new NotImplementedException();
        }

        public static bool Contains(this Rect3I rect, Rect3I other)
        {
            throw new NotImplementedException();
        }

        public static bool Intersects(this Rect3I rect, Rect3I other)
        {
            throw new NotImplementedException();
        }
        
        #endregion
        
        #region Rect3D

        public static bool Contains(this Rect3D rect, Point3D point)
        {
            throw new NotImplementedException();
        }
        
        #endregion
        
        #region Tri2D
        
        public static bool Contains(this Tri2D tri, Point2D point)
        {
            throw new NotImplementedException();
        }
        
        public static bool Contains(this Tri2D tri, Line2D line)
        {
            throw new NotImplementedException();
        }
        
        #endregion
        
        #region Tri3D
        
        #endregion
    }
}