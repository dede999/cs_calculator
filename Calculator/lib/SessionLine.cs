namespace Calculator.lib;

public record SessionLine(
    String Command,
    String? Result,
    String? Error);
