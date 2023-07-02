using System.Collections.Immutable;
using Guard;

namespace Geometry.Area.Figure;

public class Triangle : IFigure
{
    public Triangle(double sideA, double sideB, double sideC)
    {
        Argument.Positive(sideA, nameof(sideA));
        Argument.Positive(sideB, nameof(sideB));
        Argument.Positive(sideC, nameof(sideC));
        Guard.Figure.TriangleExists(sideA, sideB, sideC);

        sides = ImmutableArray.Create(sideA, sideB, sideC);
    }

    public double Area
    {
        get
        {
            var semiPerimeter = (sides[0] + sides[1] + sides[2]) / 2.0;
            return Math.Sqrt(semiPerimeter * (semiPerimeter - sides[0]) * (semiPerimeter - sides[1]) * (semiPerimeter - sides[2]));
        }
    }

    public bool IsRight
    {
        get
        {
            for (int i = 0; i < sides.Length; i++)
            {
                var sideA2 = sides[i] * sides[i];
                var sideB2 = sides[(i + 1) % 3] * sides[(i + 1) % 3];
                var sideC2 = sides[(i + 2) % 3] * sides[(i + 2) % 3];
                if (Math.Abs(sideA2 + sideB2 - sideC2) < Tolerance)
                {
                    return true;
                }
            }

            return false;
        }
    }

    private readonly ImmutableArray<double> sides;
    private const double Tolerance = 1e-5;
}