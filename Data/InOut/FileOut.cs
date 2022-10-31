using System.IO;

namespace MathLibrary.InOut;

public class FileOut : IOut
{
    private readonly string _filePath;

    public FileOut(string filePath)
    {
        _filePath = filePath;
        if (!File.Exists(filePath))
            File.Create(_filePath);
    }


    public void Write(string message, params object[] args)
    {
        File.AppendAllText(_filePath, message);
    }

    public void WriteLine(string message, params object[] args)
    {
        File.AppendAllText(_filePath, message + "\r\n");
    }
}
