using Calculator.Exceptions;

namespace Calculator;

public class DoubleCalculator: BasicArithmetic<double>
{
    public new (double result, double remainig) DivideRemainder(double a, double b)
    {
        if (b == 0)
            throw new DivideByZeroException();

        return (Math.Floor(a / b), a % b);
    }

    public override double Power(double a, double b)
    {
        return Math.Pow(a, b);
    }
    
    public double Root(double a, int b)
    {
        if (b <= 0)
            throw new OperationDomainException("Root must be greater than 0.");
        return Math.Pow(a, 1 / (double)b);
    }

    public override double Tetration(double a, int b)
    {
        if (b == 0)
            return 1;

        if (b == 1)
            return a;

        if (a == 0)
            return 0;

        double result = 1;

        for (int i = 0; i < b; i++)
        {
            result = Power(a, result);
        }

        return result;
    }

    public override double Factorial(double a)
    {
        throw new OperationDomainException("Factorial of a decimal number is undefined.");
    }
}