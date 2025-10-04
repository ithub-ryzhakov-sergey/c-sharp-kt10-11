namespace App.Tasks.Task2_Loggers;

using System;

// Логгер для ссылочных типов
public class ObjectLogger<T> where T : class
{
    public void Log(T data)
    {
        if (data == null)
        {
            Console.WriteLine("Объект пуст (null)");
        }
        else
        {
            Console.WriteLine(data.ToString());
        }
    }
}

// Логгер для типов-значений
public class ValueLogger<T> where T : struct
{
    public void Log(T data)
    {
        // Проверка на null не нужна, так как типы-значения не могут быть null
        Console.WriteLine(data.ToString());
    }
}

// Демонстрация работы
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== Демонстрация ObjectLogger (ссылочные типы) ===");

        // Работа со строкой (ссылочный тип)
        var stringLogger = new ObjectLogger<string>();
        stringLogger.Log("hello");
        stringLogger.Log(null);

        // Работа с объектом
        var objectLogger = new ObjectLogger<object>();
        objectLogger.Log(new { Name = "Test", Value = 123 });
        objectLogger.Log(null);

        Console.WriteLine("\n=== Демонстрация ValueLogger (типы-значения) ===");

        // Работа с DateTime (тип-значение)
        var dateLogger = new ValueLogger<DateTime>();
        dateLogger.Log(DateTime.Now);

        // Работа с int (тип-значение)
        var intLogger = new ValueLogger<int>();
        intLogger.Log(42);

        // Работа с double (тип-значение)
        var doubleLogger = new ValueLogger<double>();
        doubleLogger.Log(3.14159);

        // Работа с пользовательской структурой
        var pointLogger = new ValueLogger<Point>();
        pointLogger.Log(new Point(10, 20));

        // Попытка создать неправильные логгеры (раскомментировать для проверки ошибок компиляции)
        // var invalid1 = new ObjectLogger<int>(); // Ошибка: int - тип-значение
        // var invalid2 = new ValueLogger<string>(); // Ошибка: string - ссылочный тип

        Console.ReadLine();
    }
}

// Пользовательская структура для демонстрации
public struct Point
{
    public int X { get; }
    public int Y { get; }

    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }

    public override string ToString()
    {
        return $"Point({X}, {Y})";
    }
}
