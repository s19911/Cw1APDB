using Xunit;

public class AverageCalculatorTests
{
    [Fact]
    public void CalculateAverage_ReturnsCorrectAverage()
    {
        int[] numbers = { 2, 4, 6, 8, 10 };
        double result = AverageCalculator.CalculateAverage(numbers);
        Assert.Equal(6.0, result);
    }

    [Fact]
    public void CalculateAverage_ThrowsExceptionForEmptyArray()
    {
        Assert.Throws<ArgumentException>(() => AverageCalculator.CalculateAverage(new int[] { }));
    }
}
