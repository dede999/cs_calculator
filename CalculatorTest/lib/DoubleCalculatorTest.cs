using Calculator;
using Calculator.Exceptions;
using JetBrains.Annotations;

namespace CalculatorTest.lib;

[TestSubject(typeof(DoubleCalculator))]
public class DoubleCalculatorTest
{
    private DoubleCalculator _calculator = new();

    [Theory]
    [InlineData(1, 1, 0)]
    [InlineData(5.6568542494923806, 2.0, 2.5)]
    [InlineData(0.5, 4.0, -0.5)]
    public void PowerTestDouble(double expected, double a, double b)
    {
        Assert.Equal(expected, _calculator.Power(a, b));
    }
    
    [Theory]
    [InlineData(1.4142135623730951, 2, 2)]
    [InlineData(1.7320508075688772, 3, 2)]
    [InlineData(1, 1, 2)]
    [InlineData(1.7099759466766968, 5, 3)]
    public void RootTest(double expected, double a, int b)
    {
        Assert.Equal(expected, _calculator.Root(a, b));
    }
    
    [Theory]
    [InlineData(0)]
    [InlineData(-1)]
    void RootTest_ThrowsOperationDomainExceptionWithNonPositiveRoot(int rootIndex)
    {
        Assert.Throws<OperationDomainException>(() => _calculator.Root(1, rootIndex));
    }
    
    [Theory]
    [InlineData(1, 0, 0)]
    [InlineData(1, 1, 1)]
    [InlineData(1, 2, 0)]
    [InlineData(3, 3, 1)]
    [InlineData(256, 4, 2)]
    public void TetrationTestDouble(double expected, double a, double b)
    {
        Assert.Equal(expected, _calculator.Tetration(a, (int)b));
    }
    
    [Fact]
    public void FactorialTestDouble_ThrowsOperationDomainException()
    {
        Assert.Throws<OperationDomainException>(() => _calculator.Factorial(1.5));
    }
}