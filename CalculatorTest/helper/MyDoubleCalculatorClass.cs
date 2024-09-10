using Calculator;

namespace CalculatorTest.helper;

class MyDoubleCalculatorClass : BasicArithmetic<double>
{
    public MyDoubleCalculatorClass() {}

    public override double Power(double a, double b)
    {
        throw new NotImplementedException();
    }

    public override double Tetration(double a, double b)
    {
        throw new NotImplementedException();
    }

    public override double Factorial(double a)
    {
        throw new NotImplementedException();
    }
}
