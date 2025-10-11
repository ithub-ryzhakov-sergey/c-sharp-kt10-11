using App.Tasks.Task2_Loggers;
using System;

namespace App.Tasks.Task2_Loggers
{
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

    public class ValueLogger<T> where T : struct
    {
        public void Log(T data)
        {
            Console.WriteLine(data.ToString());
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== Демонстрация ObjectLogger ===");

        var stringLogger = new ObjectLogger<string>();
        stringLogger.Log("hello");
        stringLogger.Log(null);

        var objectLogger = new ObjectLogger<object>();
        objectLogger.Log(new { Name = "Test", Value = 123 });
        objectLogger.Log(null);

        Console.WriteLine("\n=== Демонстрация ValueLogger ===");

        var dateTimeLogger = new ValueLogger<DateTime>();
        dateTimeLogger.Log(DateTime.Now);

        var intLogger = new ValueLogger<int>();
        intLogger.Log(42);

        var doubleLogger = new ValueLogger<double>();
        doubleLogger.Log(3.14159);

        var boolLogger = new ValueLogger<bool>();
        boolLogger.Log(true);

        Console.WriteLine("\n=== Попытка создания неправильных логгеров ===");

        Console.WriteLine("Программа завершена успешно!");
    }
}
