using System.Diagnostics.CodeAnalysis;
using Calculator;

namespace CalculatorTest.helper;

[ExcludeFromCodeCoverage]
class MyDoubleCalculatorClass : BasicArithmetic<double>
{
    public MyDoubleCalculatorClass() {}

    public override double Power(double a, double b)
    {
        throw new NotImplementedException();
    }

    public override double Tetration(double a, int b)
    {
        throw new NotImplementedException();
    }

    public override double Factorial(double a)
    {
        throw new NotImplementedException();
    }
}
