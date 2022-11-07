namespace MathLibrary.Delegates;

public class Broadcaster
{
    public int Sleep { get; init; } = 3;

    public delegate void Notify(string message, int count);

    private List<Notify> _listeners = new();

    public void AddListener(Notify listener) => _listeners.Add(listener);

    public void RemoveListener(Notify listener) => _listeners.Remove(listener);

    public void Run()
    {
        int count = 0;
        while (true)
        {
            Thread.Sleep(Sleep * 1000);
            foreach (var listener in _listeners)
                listener?.Invoke(message: $"New message {count}", count: count);
            count++;
        }
    }
}
