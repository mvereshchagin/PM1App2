using System.IO;
using WorkWithExceptions;

string filePath = "test.txt";
try
{
    string text = File.ReadAllText(filePath);

    Console.WriteLine(text);
}
// Обработка всех исключений без получения информации о них
//catch
//{
//    Console.WriteLine("Не фартонуло!");
//}
// Обработка всех исключений без получения информации о них
//catch (Exception)
//{
//    Console.WriteLine("Не фартонуло!");
//}
// Обработка всех исключений c полученем информации о них (переменная "e")
//catch (Exception e)
//{
//    Console.WriteLine(e.Message);
//}
catch (ArgumentNullException)
{
    Console.WriteLine("Пустой аргумент");
}
catch(ArgumentException)
{
    Console.WriteLine("Неправильный аргумент");
}
catch(PathTooLongException)
{
    Console.WriteLine("Слишком длинный путь");
}
catch(FileNotFoundException e)
{
    Console.WriteLine($"Файл не найден: {e.FileName}");
}
catch(Exception e)
{
    Console.WriteLine(e.Message);
}
finally
{
    // выполняется в любом случае. Назависимо от того, произошло исключение или нет
    Console.WriteLine("Я тут буду всегда");
}

try
{
    throw new MyException(ExceptionPriority.High, "Что-то пошло не так");
}
catch(MyException e)
{
    Console.WriteLine($"Мы поймали наше исключение: {e.Priority} {e.Message}");
    // throw;
}

Console.WriteLine("Введите свое имя");
var name = Console.ReadLine();

string convertedName = String.Empty;

if(!String.IsNullOrEmpty(name) && name.Length > 0)
    convertedName = name.Substring(0, 1).ToUpper() + name.Substring(1);

Console.WriteLine(convertedName);

Console.WriteLine("End of app");