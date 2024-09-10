using System.Numerics;

namespace Calculator;

public abstract class BasicArithmetic<T> where T : INumber<T>
{
    public T Add(params T[] a) => a.Aggregate((x, y) => x + y);
    
    public T Subtract(params T[] a) => a.Aggregate((x, y) => x - y);
    
    public T Multiply(params T[] a) => a.Aggregate((x, y) => x * y);

    public T Divide(T a, T b)
    {
        if (b.Equals(default(T)))
        {
            throw new DivideByZeroException();
        }
        
        return a / b;
    }
    
    public (T result, T remainig) DivideRemainder(T a, T b)
    {
        if (b.Equals(default(T)))
        {
            throw new DivideByZeroException();
        }

        return (a / b, a % b);
    }

    public abstract T Power(T a, T b);

    public abstract T Tetration(T a, int b);

    public abstract T Factorial(T a);
}