namespace MathLibrary.Delegates;

public class ArrayUtils
{
    /// <summary>
    /// Фильтрует массив по условию
    /// </summary>
    /// <typeparam name="T">Тип данных массива</typeparam>
    /// <param name="array">Массив</param>
    /// <param name="condition">Условие</param>
    /// <returns>Отфильтрованный массив</returns>
    public static T[] Filter<T>(T[] array, Predicate<T> condition)
    {
        List<T> list = new();
        foreach(var item in array)
            if(condition(item))
                list.Add(item);
        return list.ToArray();
    }
}
