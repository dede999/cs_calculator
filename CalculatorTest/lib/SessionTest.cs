using Calculator;
using Calculator.lib;
using JetBrains.Annotations;

namespace CalculatorTest.lib;

[TestSubject(typeof(Session))]
public class SessionTest
{
    private Session _session;
    private SessionLine[] _history;
    
    public SessionTest()
    {
        _session = new();
        _session.AddLine("I", "Tetration", 2, 3);
        _session.AddLine("I", "BinomialCoefficient", 5, 2);
        _session.AddLine("D", "Power", 1.5, 2);
        _session.AddLine("D", "Root", .125, 3);
        _session.AddLine("I", "Power", 2, -3);
        _session.AddLine("I", "Factorial", -5);
        _history = _session.GetHistory();
    }

    [Fact]
    public void GetHistoryTest()
    {
        Assert.Equal(6, _history.Length);
    }

    [Theory]
    [InlineData("I.Tetration(2;3)", 0, "16")]
    [InlineData("I.BinomialCoefficient(5;2)", 1, "10")]
    [InlineData("D.Power(1,5;2)", 2, "2,25")]
    [InlineData("D.Root(0,125;3)", 3, "0,5")]
    public void AddLineTestKeysAndResultsAreStored(string key, int index, string result)
    {
        Assert.Equal(key, _history[index].Command);
        Assert.Equal(result, _history[index].Result);
    }
    
    [Theory]
    [InlineData("I.Power(2;-3)", 4)]
    [InlineData("I.Factorial(-5)", 5)]
    public void AddLineTestErrorsAreStored(string key, int index)
    {
        Assert.Equal(key, _history[index].Command);
        Assert.NotNull(_history[index].Error);
    }

    [Fact]
    public void HasIntegerCalculator()
    {
        Assert.NotNull(_session.I);
        Assert.IsType<IntegerCalculator>(_session.I);
    }
    
    [Fact]
    public void HasDoubleCalculator()
    {
        Assert.NotNull(_session.D);
        Assert.IsType<DoubleCalculator>(_session.D);
    }
}