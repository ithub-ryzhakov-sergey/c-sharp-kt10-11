using System;

namespace App.Tasks.Task2_Loggers
{
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
            Console.WriteLine(data.ToString());
        }
    }
}