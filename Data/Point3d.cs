namespace MathLibrary;

public record struct Point3d(int X, int Y, int Z)
{
    public override string ToString() => $"({X}, {Y}, {Z})";
}
