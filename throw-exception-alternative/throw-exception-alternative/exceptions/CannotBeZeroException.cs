namespace throw_exception_alternative.exceptions;

public class CannotBeZeroException : System.ArgumentOutOfRangeException
{
    public CannotBeZeroException(string parameter): base(parameter, "value cannot be 0")
    {
        // empty
    }
}
