namespace Crystalline.Geometry
{
    /// <summary>
    /// The various types of primitives.
    /// </summary>
    public enum PrimitiveType
    {
        /// <summary>
        /// A single point in space.
        /// </summary>
        Point,
        
        /// <summary>
        /// A connection between two points.
        /// </summary>
        Line,
        
        /// <summary>
        /// Rectangular shape with only parallel and perpendicular lines.
        /// </summary>
        Rect,
        
        /// <summary>
        /// Triangle formed from three connected points.
        /// </summary>
        Tri
    }
}