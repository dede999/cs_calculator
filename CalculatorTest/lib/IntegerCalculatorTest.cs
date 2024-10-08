using Calculator;
using Calculator.Exceptions;

namespace CalculatorTest.lib;

public class IntegerCalculatorTest
{
    private IntegerCalculator _calculator = new();
    
    [Theory]
    [InlineData(1, 1, 2)]
    [InlineData(81, 3, 4)]
    [InlineData(1, 0, 0)]
    public void PowerTest(int expected, int a, int b)
    {
        Assert.Equal(expected, _calculator.Power(a, b));
    }

    [Fact]
    public void PowerTest_ThrowsOperationDomainException()
    {
        Assert.Throws<OperationDomainException>(() => _calculator.Power(1, -1));
    }
    
    [Theory]
    [InlineData(1, 0, 0)]
    [InlineData(1, 1, 1)]
    [InlineData(1, 2, 0)]
    [InlineData(0, 0, 4)]
    [InlineData(3, 3, 1)]
    [InlineData(256, 4, 2)]
    [InlineData(3125, 5, 2)]
    public void TetrationTest(int expected, int a, int b)
    {
        Assert.Equal(expected, _calculator.Tetration(a, b));
    }
    
    [Theory]
    [InlineData(1, 0)]
    [InlineData(1, 1)]
    [InlineData(2, 2)]
    [InlineData(6, 3)]
    [InlineData(24, 4)]
    [InlineData(120, 5)]
    public void FactorialTest(int expected, int a)
    {
        Assert.Equal(expected, _calculator.Factorial(a));
    }
    
    [Fact]
    public void FactorialTest_ThrowsOperationDomainException()
    {
        Assert.Throws<OperationDomainException>(() => _calculator.Factorial(-1));
    }

    [Theory]
    [InlineData(1, 0, 0)]
    [InlineData(1, 1, 1)]
    [InlineData(1, 2, 0)]
    [InlineData(3, 3, 1)]
    [InlineData(3, 3, 2)]
    [InlineData(6, 4, 2)]
    public void BinomialCoefficientTest(int expected, int n, int k)
    {
        Assert.Equal(expected, _calculator.BinomialCoefficient(n, k));
    }

    [Fact]
    public void BinomialCoefficientTestException()
    {
        Assert.Throws<OperationDomainException>(() => _calculator.BinomialCoefficient(1, 2));
    }
}