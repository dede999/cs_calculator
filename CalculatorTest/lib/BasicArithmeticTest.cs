using System.Numerics;
using Calculator;
using CalculatorTest.helper;

namespace CalculatorTest.lib;

public class BasicArithmeticTest
{
    private readonly MyDoubleCalculatorClass _doubleCalculator;
    private readonly MyIntCalculator _intCalculator;
    
    public BasicArithmeticTest()
    {
        _doubleCalculator = new MyDoubleCalculatorClass();
        _intCalculator = new MyIntCalculator();
    }
    
    [Theory]
    [InlineData(3.0, 1.0, 2.0)]
    [InlineData(6.0, 1.0, 2.0, 3.0)]
    [InlineData(12, 1.5, 2.5, 3.5, 4.5)]
    public void AddTest(double expected, params double[] numbers)
    {
        Assert.Equal(expected, _doubleCalculator.Add(numbers));
    }
    
    [Theory]
    [InlineData(1, 3.0, 2.0)]
    [InlineData(6, 12.0, 1.0, 2.0, 3.0)]
    [InlineData(0, 12.0, 1.5, 2.5, 3.5, 4.5)]
    public void SubtractTest(double expected, params double[] numbers)
    {
        Assert.Equal(expected, _doubleCalculator.Subtract(numbers));
    }
    
    [Theory]
    [InlineData(6, 3.0, 2.0)]
    [InlineData(6, 1.0, 2.0, 3.0)]
    [InlineData(59.0625, 1.5, 2.5, 3.5, 4.5)]
    public void MultiplyTest(double expected, params double[] numbers)
    {
        Assert.Equal(expected, _doubleCalculator.Multiply(numbers));
    }
    
    [Theory]
    [InlineData(3, 6, 2)]
    [InlineData(2.5, 7.5, 3)]
    public void DivideTestDouble(double expected, double a, double b)
    {
        Assert.Equal(expected, _doubleCalculator.Divide(a, b));
    }
    
    [Fact]
    public void DivideByZeroTest()
    {
        Assert.Throws<DivideByZeroException>(() => _doubleCalculator.Divide(1, 0));
    }
    
    [Theory]
    [InlineData(3, 6, 2)]
    [InlineData(2, 7, 3)]
    public void DivideTestInt(int expected, int a, int b)
    {
        Assert.Equal(expected, _intCalculator.Divide(a, b));
    }
    
    [Theory]
    [InlineData(3, 0, 6, 2)]
    [InlineData(2, 1, 7, 3)]
    [InlineData(4, 2, 14, 3)]
    public void DivideRemainderTestInt(
        int expectedResult, int expectedReminder, int a, int b)
    {
        var (result, remainder) = _intCalculator.DivideRemainder(a, b);
        Assert.Equal(expectedResult, result);
        Assert.Equal(expectedReminder, remainder);
    }
    
    [Fact]
    public void DivideByZeroTestInt()
    {
        Assert.Throws<DivideByZeroException>(() => _intCalculator.DivideRemainder(1, 0));
    }
}