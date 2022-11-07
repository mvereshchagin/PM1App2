namespace MathLibrary.Delegates;

public class Broadcaster2
{
    public int Sleep { get; init; } = 3;

    public delegate void Notify(string message, int count);

    private Notify? _listener;

    public void AddListener(Notify listener) => _listener += listener;

    public void RemoveListener(Notify listener) => _listener -= listener;

    public void Run()
    {
        int count = 0;
        while (true)
        {
            Thread.Sleep(Sleep * 1000);
            _listener?.Invoke(message: $"New message {count}", count: count);
            count++;
        }
    }
}
