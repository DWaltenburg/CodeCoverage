using techmath;

namespace tests;

public class UnitTestShape
{
    [Fact]
    public void TestCircleConstructor()
    {
        Circle c1 = new(3);
        Assert.NotNull(c1);
    }

    [Fact]
    public void TestCirclePerimeter()
    {
        Circle c1 = new(3);
        // assert reuslt with 2 decimals
        Assert.Equal(18.85, c1.Perimeter(), 2);
    }

    [Fact]
    public void TestRectangleConstructor()
    {
        Rectangle r1 = new(3, 4);
        Assert.NotNull(r1);
    }

    [Fact]
    public void TestRectanglePerimeter()
    {
        Rectangle r1 = new(3, 4);
        Assert.Equal(14, r1.Perimeter());
    }

    [Fact]
    public void TestRectangleArea()
    {
        Rectangle r1 = new(3, 4);
        Assert.Equal(12, r1.Area());
    }

    [Fact]
    public void TestRectangleToString()
    {
        Rectangle r1 = new(3, 4);
        Assert.Equal("techmath.Rectangle(3,4)", r1.ToString());
    }

    [Fact]
    public void TestCirclePerimiter()
    {
        Circle c1 = new(3);
        Assert.Equal(18.85, c1.Perimeter(), 2);
    }

    [Fact]
    public void TestCircleArea()
    {
        Circle c1 = new(3);
        Assert.Equal(28.27, c1.Area(), 2);
    }

    [Fact]
    public void TestCircleToString()
    {
        Circle c1 = new(3);
        Assert.Equal("techmath.Circle(3)", c1.ToString());
    }
}