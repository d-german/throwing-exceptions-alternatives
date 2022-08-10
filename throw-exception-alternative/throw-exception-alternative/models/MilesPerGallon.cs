namespace throw_exception_alternative.models;

public record MilesPerGallon
{
    public double Miles { get; init; } = 0;
    public double Gallons { get; init; } = 1;
    public double? Mpg { get; init; } = null;
}
