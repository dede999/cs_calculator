using System.Diagnostics.CodeAnalysis;
using Calculator;

namespace CalculatorTest.helper;

[ExcludeFromCodeCoverage]
public class MyIntCalculator: BasicArithmetic<int>
{
    public override int Power(int a, int b)
    {
        throw new NotImplementedException();
    }

    public override int Tetration(int a, int b)
    {
        throw new NotImplementedException();
    }

    public override int Factorial(int a)
    {
        throw new NotImplementedException();
    }
}