namespace throw_exception_alternative.models;

public record MilesPerGallon
{
    public double Miles { get; init; }
    public double Gallons { get; init; } = 1;
    public double? Mpg { get; init; }
}
