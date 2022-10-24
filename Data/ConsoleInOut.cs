using System.Collections;
using System.Collections.Generic;

namespace MathLibrary;

public class ConsoleInOut : IInOut
{
    public string? ReadLine() => Console.ReadLine();

    public void Write(string message, params object[] args) => Console.Write(message, args);

    public void WriteLine(string message, params object[] args) => Console.WriteLine(message, args);
}
