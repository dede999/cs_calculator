using System.Numerics;

namespace Calculator;

public class IntegerCalculator: BasicArithmetic<int>
{
    public override int Power(int a, int b)
    {
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
        return Enumerable.Range(1, a).Aggregate(1, (x, y) => x * y);
    }
}