namespace MathLibrary.Math;

/// <summary>
/// Структура 3d вектор
/// </summary>
/// <param name="X">Проекуция на ось X</param>
/// <param name="Y">Проекуция на ось Y</param>
/// <param name="Z">Проекуция на ось Z</param>
public record struct Vector3d(int X, int Y, int Z)
{
    #region ctor
    /// <summary>
    /// ctor Vector3d
    /// </summary>
    /// <param name="pointA">start point</param>
    /// <param name="pointB">end point</param>
    public Vector3d(Point3d pointA, Point3d pointB) :
        this(pointB.X - pointA.X, pointB.Y - pointA.Y, pointB.Z - pointA.Z)
    { }
    #endregion

    #region properties
    /// <summary>
    /// Длина вектора
    /// </summary>
    public float Length => MathF.Sqrt(X * X + Y * Y + Z * Z);
    #endregion

    #region static methods
    /// <summary>
    /// Скалярное произведение
    /// </summary>
    /// <param name="a">Вектор 1</param>
    /// <param name="b">Вектор 2</param>
    /// <returns>Результат скалярного произвдения</returns>
    public static int DotProduct(Vector3d a, Vector3d b) => a.X * b.X + a.Y * b.Y + a.Z * b.Z;

    /// <summary>
    /// Векторное произведение
    /// </summary>
    /// <param name="a">Вектор 1</param>
    /// <param name="b">Вектор 2</param>
    /// <returns>Результат векторного произвдения</returns>
    public static Vector3d CrossProduct(Vector3d a, Vector3d b)
    {
        return new Vector3d()
        {
            X = a.Y * b.Z - a.Z * b.Y,
            Y = a.Z * b.X - a.X * b.Z,
            Z = a.X * b.Y - a.Y * b.X
        };
    }

    /// <summary>
    /// Смешанное произведение
    /// </summary>
    /// <param name="a">Вектор 1</param>
    /// <param name="b">Вектор 2</param>
    /// <param name="c">Вектор 3</param>
    /// <returns>Результат смешанного произвдения</returns>
    public static int MixedProduct(Vector3d a, Vector3d b, Vector3d c)
    {
        return
            a.X * b.Y * c.Z +
            a.Y * b.Z * c.X +
            a.Z * b.X * c.Y -
            a.Z * b.Y * c.X -
            a.Y * b.X * c.Z -
            a.X * b.Z * c.Y;
    }
    #endregion

    #region overriden
    public override string ToString() => $"({X}, {Y}, {Z})";
    #endregion

    #region operators
    public static Vector3d operator +(Vector3d a, Vector3d b) => new Vector3d(a.X + b.X, a.Y + b.Y, a.Z + b.Z);
    public static Vector3d operator -(Vector3d a, Vector3d b) => new Vector3d(a.X - b.X, a.Y - b.Y, a.Z - b.Z);

    public static int operator *(Vector3d a, Vector3d b) => DotProduct(a, b);

    public static Vector3d operator +(Vector3d a, int num) => new Vector3d(a.X + num, a.Y + num, a.Z + num);
    public static Vector3d operator -(Vector3d a, int num) => a + -num;

    public int this[int index]
    {
        get => index switch
        {
            0 => X,
            1 => Y,
            2 => Z,
            _ => throw new IndexOutOfRangeException()
        };
        set
        {
            switch (index)
            {
                case 0:
                    X = value;
                    break;
                case 1:
                    Y = value;
                    break;
                case 2:
                    Z = value;
                    break;
                default:
                    throw new IndexOutOfRangeException();
            }
        }
    }
    #endregion
}
