using Geometry.Area.Figure;
using Guard;

namespace Geometry.Area;

public class AreaCalculator : IAreaCalculator
{
    public double CalculateArea(double radius)
    {
        Argument.Positive(radius, nameof(radius));

        return new Circle(radius).Area;
    }

    public double CalculateArea(double sideA, double sideB, double sideC)
    {
        Argument.Positive(sideA, nameof(sideA));
        Argument.Positive(sideB, nameof(sideB));
        Argument.Positive(sideC, nameof(sideC));

        return new Triangle(sideA, sideB, sideC).Area;
    }
}