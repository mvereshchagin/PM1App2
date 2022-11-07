namespace MathLibrary.Delegates;

public class WorkWithDelegatesKlass
{
    delegate void SendMessage(); // ссылка на метод, котрый ничего не возвращает, и не принимает аргументов

    delegate void PrintMessage(string message); // ссылка на метод, котрый ничего не возвращает, и принимает в качестве аргумента строку

    public void SendHello() => Console.WriteLine("Hello");

    public void SendBye() => Console.WriteLine("Bye");

    public void PrintMessageWithPrefix(string msg) => Console.WriteLine($"Here is your message: {msg}");

    public void PrintMessagePlain(string msg) => Console.WriteLine(msg);

    public void Run()
    {
        SendMessage msg = SendBye; //SendHello;
        msg += SendBye;
        msg += SendHello;
        msg += SendBye;
        msg += SendHello;
        msg += SendHello;
        msg -= SendHello;

        msg();


        PrintMessage printer = PrintMessagePlain;
        printer += PrintMessageWithPrefix;
        printer += (message) => Console.WriteLine($"New message is {message}");

        printer?.Invoke("My super message");
    }
}
