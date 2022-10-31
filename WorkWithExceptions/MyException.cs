namespace WorkWithExceptions;

internal class MyException : Exception
{
    public ExceptionPriority Priority { get; }

    public MyException(ExceptionPriority priority, string message) : base(message)
    {
        Priority = priority;
    }
}

public enum ExceptionPriority
{
    Low,
    Average,
    High,
}
