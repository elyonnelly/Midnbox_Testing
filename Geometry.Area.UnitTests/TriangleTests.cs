using Geometry.Area.Figure;

namespace Geometry.Area.UnitTests;

public class TriangleTests
{
    [TestCase(3, 4, 5, true)]
    [TestCase(85, 77, 36, true)]
    [TestCase(68, 293, 285, true)]
    [TestCase(4, 7, 4, false)]
    [TestCase(734, 925, 890, false)]
    [TestCase(1e9, 1e9, 1e9, false)]
    public void Triangle_RightAsExpected(double sideA, double sideB, double sideC, bool isRight)
    {
        // assert
        var triangle = new Triangle(sideA, sideB, sideC);
        
        // act & assert
        Assert.That(triangle.IsRight, Is.EqualTo(isRight));
    }
}