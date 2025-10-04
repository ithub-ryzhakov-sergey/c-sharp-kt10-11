namespace App.Tasks.Task2_Loggers;

public class ObjectLogger<T> where T : class
{
    public void Log(T data)
    {
        if (data == null)
        {
            System.Console.WriteLine("Объект пуст (null)");
        }
        else
        {
            System.Console.WriteLine(data.ToString());
        }
    }
}

public class ValueLogger<T> where T : struct
{
    public void Log(T data)
    {
        System.Console.WriteLine(data.ToString());
    }
}