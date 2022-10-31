namespace MathLibrary.InOut;

public interface IOut
{
    void WriteLine(string message, params object[] args);
    void Write(string message, params object[] args);
}
