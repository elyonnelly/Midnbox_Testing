using Guard;

namespace Geometry.Area.Figure;

public class Circle : IFigure
{
    public Circle(double radius)
    {
        this.radius = Argument.Positive(radius, nameof(radius));
    }

    public double Area => Math.PI * radius * radius;

    private readonly double radius;
}