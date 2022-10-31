namespace MathLibrary.InOut;

public class ColoredConsole : IInOut, IDisposable
{
    private readonly ConsoleColor _initialForegroundColor;
    private readonly ConsoleColor _initialBackgroundColor;
    private bool disposedValue;

    public ColoredConsole()
    {
        _initialForegroundColor = Console.ForegroundColor;
        _initialBackgroundColor = Console.BackgroundColor;
    }

    public ConsoleColor ForegroundColor
    {
        get => Console.ForegroundColor;
        set => Console.ForegroundColor = value;
    }
    public ConsoleColor BackgroundColor
    {
        get => Console.BackgroundColor;
        set => Console.BackgroundColor = value;
    }

    public void ResetColor()
    {
        Console.BackgroundColor = _initialBackgroundColor;
        Console.ForegroundColor = _initialForegroundColor;
    }

    string? IIn.ReadLine() => Console.ReadLine();

    void IOut.Write(string message, params object[] args) => Console.Write(message, args);

    void IOut.WriteLine(string message, params object[] args) => Console.WriteLine(message, args);

    protected virtual void Dispose(bool disposing)
    {
        if (!disposedValue)
        {
            if (disposing)
            {
                // TODO: освободить управляемое состояние (управляемые объекты)
                ResetColor();
            }

            // TODO: освободить неуправляемые ресурсы (неуправляемые объекты) и переопределить метод завершения
            // TODO: установить значение NULL для больших полей
            disposedValue = true;
        }
    }

    // // TODO: переопределить метод завершения, только если "Dispose(bool disposing)" содержит код для освобождения неуправляемых ресурсов
    // ~ColoredConsole()
    // {
    //     // Не изменяйте этот код. Разместите код очистки в методе "Dispose(bool disposing)".
    //     Dispose(disposing: false);
    // }

    void IDisposable.Dispose()
    {
        // Не изменяйте этот код. Разместите код очистки в методе "Dispose(bool disposing)".
        Dispose(disposing: true);
        GC.SuppressFinalize(this);
    }
}
