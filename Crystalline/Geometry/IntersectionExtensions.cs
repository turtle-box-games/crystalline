using System;

namespace Crystalline.Geometry
{
    /// <summary>
    /// Methods for calculating when two geometric primitives intersect or when one is entirely contained in another.
    /// </summary>
    /// <remarks>3D primitives that rest along their own plane, such as <see cref="Tri3D"/>,
    /// do not have Contains() methods because it would require checking if another primitive existed on the same plane.
    /// This is a very unlikely scenario and is omitted.</remarks>
    public static class IntersectionExtensions
    {
        public static bool Contains(this IPrimitive primitive, IPrimitive other)
        {
            switch (primitive)
            {
                case Rect2I rect:
                    return Contains(rect, other);
                case Rect2D rect:
                    return Contains(rect, other);
                case Rect3I rect:
                    return Contains(rect, other);
                case Rect3D rect:
                    return Contains(rect, other);
                case Tri2D tri:
                    return Contains(tri, other);
                case Circle circle:
                    return Contains(circle, other);
                case Sphere sphere:
                    return Contains(sphere, other);
                default:
                    throw new NotSupportedException(
                        $"Primitive {primitive.GetType()} does not support checking for containment");
            }
        }

        public static bool Intersects(this IPrimitive primitive, IPrimitive other)
        {
            switch (primitive)
            {
                case Rect2I rect:
                    return Intersects(rect, other);
                case Rect2D rect:
                    return Intersects(rect, other);
                case Rect3I rect:
                    return Intersects(rect, other);
                case Rect3D rect:
                    return Intersects(rect, other);
                case Tri2D tri:
                    return Intersects(tri, other);
                case Tri3D tri:
                    return Intersects(tri, other);
                case Circle circle:
                    return Intersects(circle, other);
                case Sphere sphere:
                    return Intersects(sphere, other);
                default:
                    throw new NotSupportedException(
                        $"Primitive {primitive.GetType()} does not support checking for containment");
            }
        }

        #region Rect2I

        public static bool Contains(this Rect2I rect, IPrimitive primitive)
        {
            switch (primitive)
            {
                case Point2I point:
                    return Contains(rect, point);
                case Line2I line:
                    return Contains(rect, line);
                case Rect2I other:
                    return Contains(rect, other);
                default:
                    throw new NotSupportedException($"Unsupported containable primitive {primitive.GetType()}");
            }
        }

        public static bool Intersects(this Rect2I rect, IPrimitive primitive)
        {
            switch (primitive)
            {
                case Line2I line:
                    return Intersects(rect, line);
                case Rect2I other:
                    return Intersects(rect, other);
                default:
                    throw new NotImplementedException($"Unsupported intersectable primitive {primitive.GetType()}");
            }
        }

        public static bool Contains(this Rect2I rect, Point2I point)
        {
            throw new NotImplementedException();
        }

        public static bool Contains(this Rect2I rect, Line2I line)
        {
            throw new NotImplementedException();
        }

        public static bool Contains(this Rect2I rect, Rect2I other)
        {
            throw new NotImplementedException();
        }

        public static bool Intersects(this Rect2I rect, Line2I line)
        {
            throw new NotImplementedException();
        }

        public static bool Intersects(this Rect2I rect, Rect2I other)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region Rect2D

        public static bool Contains(this Rect2D rect, IPrimitive primitive)
        {
            switch (primitive)
            {
                case Point2D point:
                    return Contains(rect, point);
                case Rect2D other:
                    return Contains(rect, other);
                case Tri2D tri:
                    return Contains(rect, tri);
                case Line2D line:
                    return Contains(rect, line);
                case Circle circle:
                    return Contains(rect, circle);
                default:
                    throw new NotSupportedException($"Unsupported containable primitive {primitive.GetType()}");
            }
        }

        public static bool Intersects(this Rect2D rect, IPrimitive primitive)
        {
            switch (primitive)
            {
                case Rect2D other:
                    return Intersects(rect, other);
                case Tri2D tri:
                    return Intersects(rect, tri);
                case Line2D line:
                    return Intersects(rect, line);
                case Circle circle:
                    return Intersects(rect, circle);
                default:
                    throw new NotImplementedException($"Unsupported intersectable primitive {primitive.GetType()}");
            }
        }

        public static bool Contains(this Rect2D rect, Point2D point)
        {
            throw new NotImplementedException();
        }

        public static bool Contains(this Rect2D rect, Rect2D other)
        {
            throw new NotImplementedException();
        }

        public static bool Contains(this Rect2D rect, Tri2D tri)
        {
            throw new NotImplementedException();
        }

        public static bool Contains(this Rect2D rect, Line2D line)
        {
            throw new NotImplementedException();
        }

        public static bool Contains(this Rect2D rect, Circle circle)
        {
            throw new NotImplementedException();
        }

        public static bool Intersects(this Rect2D rect, Rect2D other)
        {
            throw new NotImplementedException();
        }

        public static bool Intersects(this Rect2D rect, Tri2D tri)
        {
            throw new NotImplementedException();
        }

        public static bool Intersects(this Rect2D rect, Line2D line)
        {
            throw new NotImplementedException();
        }

        public static bool Intersects(this Rect2D rect, Circle circle)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region Rect3I

        public static bool Contains(this Rect3I rect, IPrimitive primitive)
        {
            switch (primitive)
            {
                case Point3I point:
                    return Contains(rect, point);
                case Line3I line:
                    return Contains(rect, line);
                case Rect3I other:
                    return Contains(rect, other);
                default:
                    throw new NotSupportedException($"Unsupported containable primitive {primitive.GetType()}");
            }
        }

        public static bool Intersects(this Rect3I rect, IPrimitive primitive)
        {
            switch (primitive)
            {
                case Line3I line:
                    return Intersects(rect, line);
                case Rect3I other:
                    return Intersects(rect, other);
                default:
                    throw new NotImplementedException($"Unsupported intersectable primitive {primitive.GetType()}");
            }
        }

        public static bool Contains(this Rect3I rect, Point3I point)
        {
            throw new NotImplementedException();
        }

        public static bool Contains(this Rect3I rect, Line3I line)
        {
            throw new NotImplementedException();
        }

        public static bool Contains(this Rect3I rect, Rect3I other)
        {
            throw new NotImplementedException();
        }

        public static bool Intersects(this Rect3I rect, Line3I line)
        {
            throw new NotImplementedException();
        }

        public static bool Intersects(this Rect3I rect, Rect3I other)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region Rect3D

        public static bool Contains(this Rect3D rect, IPrimitive primitive)
        {
            switch (primitive)
            {
                case Point3D point:
                    return Contains(rect, point);
                case Line3D line:
                    return Contains(rect, line);
                case Rect3D other:
                    return Contains(rect, other);
                case Tri3D tri:
                    return Contains(rect, tri);
                case Sphere sphere:
                    return Contains(rect, sphere);
                default:
                    throw new NotSupportedException($"Unsupported containable primitive {primitive.GetType()}");
            }
        }

        public static bool Intersects(this Rect3D rect, IPrimitive primitive)
        {
            switch (primitive)
            {
                case Line3D line:
                    return Intersects(rect, line);
                case Rect3D other:
                    return Intersects(rect, other);
                case Tri3D tri:
                    return Intersects(rect, tri);
                case Sphere sphere:
                    return Intersects(rect, sphere);
                default:
                    throw new NotImplementedException($"Unsupported intersectable primitive {primitive.GetType()}");
            }
        }

        public static bool Contains(this Rect3D rect, Point3D point)
        {
            throw new NotImplementedException();
        }

        public static bool Contains(this Rect3D rect, Line3D line)
        {
            throw new NotImplementedException();
        }

        public static bool Contains(this Rect3D rect, Rect3D other)
        {
            throw new NotImplementedException();
        }

        public static bool Contains(this Rect3D rect, Tri3D tri)
        {
            throw new NotImplementedException();
        }

        public static bool Contains(this Rect3D rect, Sphere sphere)
        {
            throw new NotImplementedException();
        }

        public static bool Intersects(this Rect3D rect, Line3D line)
        {
            throw new NotImplementedException();
        }

        public static bool Intersects(this Rect3D rect, Rect3D other)
        {
            throw new NotImplementedException();
        }

        public static bool Intersects(this Rect3D rect, Tri3D tri)
        {
            throw new NotImplementedException();
        }

        public static bool Intersects(this Rect3D rect, Sphere sphere)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region Tri2D

        public static bool Contains(this Tri2D tri, IPrimitive primitive)
        {
            switch (primitive)
            {
                case Point2D point:
                    return Contains(tri, point);
                case Line2D line:
                    return Contains(tri, line);
                case Rect2D rect:
                    return Contains(tri, rect);
                case Tri2D other:
                    return Contains(tri, other);
                case Circle circle:
                    return Contains(tri, circle);
                default:
                    throw new NotSupportedException($"Unsupported containable primitive {primitive.GetType()}");
            }
        }

        public static bool Intersects(this Tri2D tri, IPrimitive primitive)
        {
            switch (primitive)
            {
                case Line2D line:
                    return Intersects(tri, line);
                case Rect2D rect:
                    return Intersects(tri, rect);
                case Tri2D other:
                    return Intersects(tri, other);
                case Circle circle:
                    return Intersects(tri, circle);
                default:
                    throw new NotImplementedException($"Unsupported intersectable primitive {primitive.GetType()}");
            }
        }

        public static bool Contains(this Tri2D tri, Point2D point)
        {
            throw new NotImplementedException();
        }

        public static bool Contains(this Tri2D tri, Line2D line)
        {
            throw new NotImplementedException();
        }

        public static bool Contains(this Tri2D tri, Rect2D rect)
        {
            throw new NotImplementedException();
        }

        public static bool Contains(this Tri2D tri, Tri2D other)
        {
            throw new NotImplementedException();
        }

        public static bool Contains(this Tri2D tri, Circle circle)
        {
            throw new NotImplementedException();
        }

        public static bool Intersects(this Tri2D tri, Line2D line)
        {
            throw new NotImplementedException();
        }

        public static bool Intersects(this Tri2D tri, Rect2D rect)
        {
            throw new NotImplementedException();
        }

        public static bool Intersects(this Tri2D tri, Tri2D other)
        {
            throw new NotImplementedException();
        }

        public static bool Intersects(this Tri2D tri, Circle circle)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region Tri3D

        public static bool Intersects(this Tri3D tri, IPrimitive primitive)
        {
            switch (primitive)
            {
                case Line3D line:
                    return Intersects(tri, line);
                case Rect3D rect:
                    return Intersects(tri, rect);
                case Tri3D other:
                    return Intersects(tri, other);
                case Sphere sphere:
                    return Intersects(tri, sphere);
                default:
                    throw new NotImplementedException($"Unsupported intersectable primitive {primitive.GetType()}");
            }
        }

        public static bool Intersects(this Tri3D tri, Line3D line)
        {
            throw new NotImplementedException();
        }

        public static bool Intersects(this Tri3D tri, Rect3D rect)
        {
            throw new NotImplementedException();
        }

        public static bool Intersects(this Tri3D tri, Tri3D other)
        {
            throw new NotImplementedException();
        }

        public static bool Intersects(this Tri3D tri, Sphere sphere)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region Circle

        public static bool Contains(this Circle circle, IPrimitive primitive)
        {
            switch (primitive)
            {
                case Point2D point:
                    return Contains(circle, point);
                case Line2D line:
                    return Contains(circle, line);
                case Rect2D rect:
                    return Contains(circle, rect);
                case Tri2D tri:
                    return Contains(circle, tri);
                case Circle other:
                    return Contains(circle, other);
                default:
                    throw new NotSupportedException($"Unsupported containable primitive {primitive.GetType()}");
            }
        }

        public static bool Intersects(this Circle circle, IPrimitive primitive)
        {
            switch (primitive)
            {
                case Line2D line:
                    return Intersects(circle, line);
                case Rect2D rect:
                    return Intersects(circle, rect);
                case Tri2D tri:
                    return Intersects(circle, tri);
                case Circle other:
                    return Intersects(circle, other);
                default:
                    throw new NotImplementedException($"Unsupported intersectable primitive {primitive.GetType()}");
            }
        }

        public static bool Contains(this Circle circle, Point2D point)
        {
            throw new NotImplementedException();
        }

        public static bool Contains(this Circle circle, Line2D line)
        {
            throw new NotImplementedException();
        }

        public static bool Contains(this Circle circle, Rect2D rect)
        {
            throw new NotImplementedException();
        }

        public static bool Contains(this Circle circle, Tri2D tri)
        {
            throw new NotImplementedException();
        }

        public static bool Contains(this Circle circle, Circle other)
        {
            throw new NotImplementedException();
        }

        public static bool Intersects(this Circle circle, Line2D line)
        {
            throw new NotImplementedException();
        }

        public static bool Intersects(this Circle circle, Rect2D rect)
        {
            throw new NotImplementedException();
        }

        public static bool Intersects(this Circle circle, Tri2D tri)
        {
            throw new NotImplementedException();
        }

        public static bool Intersects(this Circle circle, Circle other)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region Sphere

        public static bool Contains(this Sphere sphere, IPrimitive primitive)
        {
            switch (primitive)
            {
                case Point3D point:
                    return Contains(sphere, point);
                case Line3D line:
                    return Contains(sphere, line);
                case Rect3D rect:
                    return Contains(sphere, rect);
                case Tri3D tri:
                    return Contains(sphere, tri);
                case Sphere other:
                    return Contains(sphere, other);
                default:
                    throw new NotSupportedException($"Unsupported containable primitive {primitive.GetType()}");
            }
        }

        public static bool Intersects(this Sphere sphere, IPrimitive primitive)
        {
            switch (primitive)
            {
                case Line3D line:
                    return Intersects(sphere, line);
                case Rect3D rect:
                    return Intersects(sphere, rect);
                case Tri3D tri:
                    return Intersects(sphere, tri);
                case Sphere other:
                    return Intersects(sphere, other);
                default:
                    throw new NotImplementedException($"Unsupported intersectable primitive {primitive.GetType()}");
            }
        }

        public static bool Contains(this Sphere sphere, Point3D point)
        {
            throw new NotImplementedException();
        }

        public static bool Contains(this Sphere sphere, Line3D line)
        {
            throw new NotImplementedException();
        }

        public static bool Contains(this Sphere sphere, Rect3D rect)
        {
            throw new NotImplementedException();
        }

        public static bool Contains(this Sphere sphere, Tri3D tri)
        {
            throw new NotImplementedException();
        }

        public static bool Contains(this Sphere sphere, Sphere other)
        {
            throw new NotImplementedException();
        }

        public static bool Intersects(this Sphere sphere, Line3D line)
        {
            throw new NotImplementedException();
        }

        public static bool Intersects(this Sphere sphere, Rect3D rect)
        {
            throw new NotImplementedException();
        }

        public static bool Intersects(this Sphere sphere, Tri3D tri)
        {
            throw new NotImplementedException();
        }

        public static bool Intersects(this Sphere sphere, Sphere other)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}