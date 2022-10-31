using MathLibrary;
using MathLibrary.InOut;
using MathLibrary.Interfaces;
using MathLibrary.Math;

void WorkWithVectors()
{
    var a = new Vector3d() { X = 10, Y = 20, Z = 30 };
    var b = new Vector3d() { X = -5, Y = 12, Z = 3 };
    var c = new Vector3d() { X = 23, Y = -6, Z = -4 };

    Console.WriteLine($"{a} * {b} = {Vector3d.DotProduct(a, b)}");
    Console.WriteLine($"{a} x {b} = {Vector3d.CrossProduct(a, b)}");
    Console.WriteLine($"({a}, {b}, {c}) = {Vector3d.MixedProduct(a, b, c)}");

    var d = a + b + 10;
    var e = a - b;

    var res = a * b + 5;

    var a1 = a with { X = 20 };
}

void WorkWithConsole()
{
    // IOut output = new ConsoleInOut();
    IOut output = new FileOut("test.txt");

    output.WriteLine("Hello, World");
    output.WriteLine("Hello, Everybody");
    output.WriteLine("How are you");

    ConsoleInOut console = new ConsoleInOut();
    if (console is IIn)
    {

    }

    using ColoredConsole cc = new ColoredConsole()
    {
        ForegroundColor = ConsoleColor.Magenta,
        BackgroundColor = ConsoleColor.Yellow
    };

    IInOut icc = cc as IInOut;
    icc.WriteLine("Hello, everybody");
    if (cc is IInOut icc2)
    {
        icc.Write("dsadsad");
    }
}

void WorkWithList()
{
    MyList<string> names = new MyList<string>();
    names.Add("Саша");
    names.Add("Паша");
    names.Add("Маша");
    names.Add("Глаша");
    names.Add("Аркаша");

    string name1 = names[0];

    foreach (var name in names)
    {

    }
}

void Minipigs()
{
    Minipig[] pigs =
    {
        new Minipig() 
        { 
            Name = "Шарик", 
            Breed = "Калининградский", 
            DateOfBirth = new DateTime(year: 2020, month: 11, day: 5),
            Description = "Очень добрый. Любит хрюкать, когда гладишь пузико",
        },
        new Minipig() 
        { 
            Name = "Билл", 
            Breed = "Американский",
            DateOfBirth = new DateTime(year: 2021, month: 6, day: 11),
            Description = "Злоюный и агресивный",
        },
        new Minipig() 
        { 
            Name = "Ред Батлер", 
            Breed = "Карапузик",
            DateOfBirth = new DateTime(year: 2018, month: 1, day: 20),
            Description = "Много спит. Во сне хрюкает",
        },
    };

    IComparer<Minipig> comparer = new MinipigDateOfBirthComparer();

    Array.Sort(pigs, comparer);

    foreach (var pig in pigs)
        Console.WriteLine(pig);
}

void CoContrVariant()
{
    IReceiver<Message> receiver = new SmsReceiver(); // IReceiver<SmsMessage> imposible without "out" 
    // IReceiver<SmsMessage> -> IReceiver<Message>
    var message = receiver.Receive();
    message.ToString();

    var messageToSend = new SmsMessage() { Text = "Hello, everybody" };
    ISender<SmsMessage> sender = new Sender(); // ISender<Message> -> ISender<SmsMessage>
    sender.Send(messageToSend);
    
}

//WorkWithVectors();
//WorkWithConsole();
//WorkWithList();
//Minipigs();
CoContrVariant();





