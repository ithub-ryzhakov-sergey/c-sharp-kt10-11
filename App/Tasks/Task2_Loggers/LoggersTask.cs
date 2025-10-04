namespace App.Tasks.Task2_Loggers;

using System;

// ������ ��� ��������� �����
public class ObjectLogger<T> where T : class
{
    public void Log(T data)
    {
        if (data == null)
        {
            Console.WriteLine("������ ���� (null)");
        }
        else
        {
            Console.WriteLine(data.ToString());
        }
    }
}

// ������ ��� �����-��������
public class ValueLogger<T> where T : struct
{
    public void Log(T data)
    {
        // �������� �� null �� �����, ��� ��� ����-�������� �� ����� ���� null
        Console.WriteLine(data.ToString());
    }
}

// ������������ ������
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== ������������ ObjectLogger (��������� ����) ===");

        // ������ �� ������� (��������� ���)
        var stringLogger = new ObjectLogger<string>();
        stringLogger.Log("hello");
        stringLogger.Log(null);

        // ������ � ��������
        var objectLogger = new ObjectLogger<object>();
        objectLogger.Log(new { Name = "Test", Value = 123 });
        objectLogger.Log(null);

        Console.WriteLine("\n=== ������������ ValueLogger (����-��������) ===");

        // ������ � DateTime (���-��������)
        var dateLogger = new ValueLogger<DateTime>();
        dateLogger.Log(DateTime.Now);

        // ������ � int (���-��������)
        var intLogger = new ValueLogger<int>();
        intLogger.Log(42);

        // ������ � double (���-��������)
        var doubleLogger = new ValueLogger<double>();
        doubleLogger.Log(3.14159);

        // ������ � ���������������� ����������
        var pointLogger = new ValueLogger<Point>();
        pointLogger.Log(new Point(10, 20));

        // ������� ������� ������������ ������� (����������������� ��� �������� ������ ����������)
        // var invalid1 = new ObjectLogger<int>(); // ������: int - ���-��������
        // var invalid2 = new ValueLogger<string>(); // ������: string - ��������� ���

        Console.ReadLine();
    }
}

// ���������������� ��������� ��� ������������
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
