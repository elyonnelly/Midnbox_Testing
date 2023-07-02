namespace Geometry.Area.UnitTests;

public class AreaCalculatorTests
{
    [SetUp]
    public void Setup()
    {
        cut = new AreaCalculator();
    }

    [TestCase(5)]
    [TestCase(1)]
    [TestCase(1e7)]
    [TestCase(42.21234353)]
    public void AreaCalculator_CalculateCircleArea_RightArea(double radius)
    {
        // arrange
        var expectedArea = Math.PI * radius * radius;
        Console.WriteLine(expectedArea);
        
        // act
        var area = cut.CalculateArea(radius);

        // assert
        Assert.That(Math.Abs(area - expectedArea), Is.LessThan(Tolerance));
    }
    
    [TestCase(0)]
    [TestCase(-1)]
    [TestCase(-1e7)]
    public void AreaCalculator_CalculateCircleAreaWhenArgumentLessThanZero_ThrowArgumentException(double radius)
    {
        // act & assert
        Assert.Throws<ArgumentException>(() => cut.CalculateArea(radius));
    }

    [TestCase(3, 4, 5, 6)]
    [TestCase(4.12, 5.1221233, 8.54561, 7.467947)]
    [TestCase(100000, 2000000, 2000000, 99968745115.66103)]
    public void AreaCalculator_CalculateTriangleArea_RightArea(double sideA, double sideB, double sideC, double expectedArea)
    {
        // act
        var area = cut.CalculateArea(sideA, sideB, sideC);
        
        // assert
        Assert.That(Math.Abs(area - expectedArea), Is.LessThan(Tolerance));
    }

    [TestCase(-1, 4, 10)]
    [TestCase(15, -100, 2)]
    [TestCase(1e7, 1e27, -1e5)]
    public void AreaCalculator_CalculateTriangleAreaWhenArgumentsLessThanZero_ThrowArgumentException(double sideA, double sideB, double sideC)
    {
        // act & assert
        Assert.Throws<ArgumentException>(() => cut.CalculateArea(sideA, sideB, sideC));
    }
    
    [TestCase(3, 4, 10)]
    [TestCase(15, 1, 2)]
    [TestCase(1e7, 1e27, 1e10)]
    public void AreaCalculator_CalculateTriangleAreaWhenTriangleDoesNotExist_ThrowArgumentException(double sideA, double sideB, double sideC)
    {
        // act & assert
        Assert.Throws<ArgumentException>(() => cut.CalculateArea(sideA, sideB, sideC));
    }

    private IAreaCalculator cut;
    private const double Tolerance = 1e-5;
}