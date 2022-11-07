namespace MathLibrary.Delegates;

public class Broadcaster3
{
    public int Sleep { get; init; } = 3;

    private Action<string, int>? _listener; // Action - делегат с любым количеством парамтров без возвращемого значения

    public void AddListener(Action<string, int>? listener) => _listener += listener;

    public void RemoveListener(Action<string, int>? listener) => _listener -= listener;

    public void Run()
    {
        int count = 0;
        while (true)
        {
            Thread.Sleep(Sleep * 1000);
                _listener?.Invoke($"New message {count}", count);
            count++;
        }
    }
}
