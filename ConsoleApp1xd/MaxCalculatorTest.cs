using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

public class MaxCalculatorTests
{
    [Fact]
    public void FindMax_ReturnsCorrectMaxValue()
    {
        int[] numbers = { 2, 4, 6, 8, 10 };
        int result = MaxCalculator.FindMax(numbers);
        Assert.Equal(10, result);
    }

    [Fact]
    public void FindMax_ThrowsExceptionForEmptyArray()
    {
        Assert.Throws<ArgumentException>(() => MaxCalculator.FindMax(new int[] { }));
    }
}
