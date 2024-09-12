namespace Calculator.lib;

public class Session()
{
    private readonly IntegerCalculator _intCalculator = new();
    private readonly DoubleCalculator _doubleCalculator = new();
    private readonly Dictionary<string, SessionLine> _history = new();
    
    public IntegerCalculator I => _intCalculator;
    public DoubleCalculator D => _doubleCalculator;
    
    public void AddLine(string scope, string method, params object?[]? args)
    {
        var historyKey = $"{scope}.{method}({string.Join(";", args ?? [])})";
        try
        {
            var result = scope switch
            {
                "I" => typeof(IntegerCalculator).GetMethod(method)?.Invoke(_intCalculator, args),
                "D" => typeof(DoubleCalculator).GetMethod(method)?.Invoke(_doubleCalculator, args),
                _ => throw new ArgumentException("Invalid scope.")
            };

            var resultString = result?.ToString();
            _history.Add(historyKey, new SessionLine(historyKey, resultString, null));
        }
        catch (Exception e)
        {
            _history.Add(historyKey, new SessionLine(historyKey, null, e.InnerException?.Message));
        }
    }
    
    public SessionLine[] GetHistory()
    {
        return _history.Values.ToArray();
    }
}