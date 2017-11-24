namespace Crystalline.Geometry
{
    /// <summary>
    /// Attributes common to all primitives.
    /// </summary>
    public interface IPrimitive
    {
        PrimitiveType Type { get; }
    }
}