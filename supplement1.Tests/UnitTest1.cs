namespace supplement1.Tests;

public class UnitTest1
{
    [Fact]
    public void AreaOfARectangleCalculation()
    {
        Assert.True(50.0 == supplement1.AreaOfRectangle(5.0, 10.0));
        
    }
}