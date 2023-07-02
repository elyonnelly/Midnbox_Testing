namespace Geometry.Area;

public interface IAreaCalculator
{
    /// <summary>
    /// Calculate the area of a circle from its radius.
    /// Throws ArgumentException if the radius less than zero.
    /// </summary>
    double CalculateArea(double radius);

    /// <summary>
    /// Calculate the area of a triangle by its sides.
    /// Throws ArgumentException if any of the passed sides less than zero or the triangle does not exist.
    /// </summary>
    /// <returns>The area of a triangle.</returns>
    double CalculateArea(double sideA, double sideB, double sideC);
}