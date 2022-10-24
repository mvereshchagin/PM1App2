using MathLibrary;

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

// IOut output = new ConsoleInOut();
IOut output = new FileOut("test.txt");

output.WriteLine("Hello, World");
output.WriteLine("Hello, Everybody");
output.WriteLine("How are you");

ConsoleInOut console = new ConsoleInOut();
if(console is IIn)
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


