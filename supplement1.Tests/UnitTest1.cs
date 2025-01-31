namespace supplement1.Tests;

public class UnitTest1
{
    [Fact]
    public void AreaOfARectangleCalculationDifferent()
    {
        Assert.True(50.0 == supplement1.AreaOfRectangle(5.0, 10.0));

    }

     [Fact]
    public void AreaOfARectangleCalculationSame()
    {
        Assert.True(25.0 == supplement1.AreaOfRectangle(5.0, 5.0));
        
    }

     [Fact]
    public void AreaOfACircleCalculation()
    {
        Assert.True(double.Pi == supplement1.AreaOfCircle(1.0));
        
    }
}