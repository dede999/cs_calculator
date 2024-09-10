using System.Numerics;
using Calculator.Exceptions;

namespace Calculator;

public class IntegerCalculator: BasicArithmetic<int>
{
    public override int Power(int a, int b)
    {
        if (b < 0)
            throw new OperationDomainException(
                "Exponent must be greater than or equal to 0, or the result will be a" +
                " decimal value below 1 and will be represented as 0.");
        return (int)BigInteger.Pow(a, b);
    }

    public override int Tetration(int a, int b)
    {
        if (b == 0)
            return 1;

        if (b == 1)
            return a;

        if (a == 0)
            return 0;

        int result = 1;

        for (int i = 0; i < b; i++)
        {
            result = Power(a, result);
        }

        return result;
    }

    public override int Factorial(int a)
    {
        if (a < 0)
            throw new OperationDomainException("Factorial of a negative number is undefined.");

        if (a == 0)
            return 1;

        return Enumerable.Range(1, a).Aggregate(1, (x, y) => x * y);
    }
}