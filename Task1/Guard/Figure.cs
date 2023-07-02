namespace Guard;

public static class Figure
{
    public static void TriangleExists(double sideA, double sideB, double sideC)
    {
        if (!(sideA + sideB > sideC && sideB + sideC > sideA && sideA + sideC > sideB))
        {
            throw new ArgumentException($"Triangle with sides {sideA}, {sideB}, {sideC} does not exist.");
        }
    }
}