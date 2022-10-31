using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLibrary.Interfaces;

public class Message
{
    public string Text { get; set; } = null!;
}

public class EmailMessage : Message
{
    public string Email { get; set; } = null!;
}

public class SmsMessage : Message
{
    public string PhoneNumber { get; set; } = null!;
}

public interface ISender<in T> where T : Message 
{
    public void Send(T message);
}

public interface IReceiver<out T> where T : Message
{
    public T Receive();
}

public class SmsReceiver : IReceiver<SmsMessage>
{
    public SmsMessage Receive()
    {
        throw new NotImplementedException();
    }
}


public class Sender : ISender<Message>
{
    public void Send(Message message)
    {
        throw new NotImplementedException();
    }
}






