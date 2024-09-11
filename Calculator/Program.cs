// See https://aka.ms/new-console-template for more information

using Calculator;
using Calculator.lib;

Console.WriteLine("Hello, World!");

Session session = new(new IntegerCalculator(), new DoubleCalculator());

// Integer operations
session.AddLine("I", "Power", 2, 3);
session.AddLine("I", "Tetration", 2, 3);
session.AddLine("I", "Factorial", 5);
session.AddLine("I", "BinomialCoefficient", 5, 2);
// Double operations
session.AddLine("D", "Power", 2.0, 3.0);
session.AddLine("D", "Power", 1.1, 3.0);
session.AddLine("D", "Root", 8.0, 3);
session.AddLine("D", "Root", .125, 3);
session.AddLine("D", "Tetration", 2.0, 3);
// Error
session.AddLine("I", "Power", 2, -3);
session.AddLine("I", "Factorial", -5);
session.AddLine("D", "Factorial", 5.0);
session.AddLine("D", "DivideRemainder", 5.0, 0.0);

var history = session.GetHistory();
foreach (var line in history)
{
    Console.WriteLine(line);
}
