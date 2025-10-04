//namespace App.Tasks.Task3_Extensions;
//using System;
//using System.Collections.Generic;
//using System.Linq;

//// ��������� ��� �������������� ������
//public interface IDataRow
//{
//    string GetFormattedString();
//}

//// ����� Employee
//public class Employee : IDataRow
//{
//    public int Id { get; set; }
//    public string FullName { get; set; }
//    public string Position { get; set; }

//    public string GetFormattedString()
//    {
//        return $"ID: {Id}, ���: {FullName}, ���������: {Position}";
//    }
//}

//// ����� Product
//public class Product : IDataRow
//{
//    public string Sku { get; set; }
//    public string Name { get; set; }
//    public decimal Price { get; set; }

//    public string GetFormattedString()
//    {
//        return $"�������: {Sku}, ��������: {Name}, ����: {Price:F2}";
//    }
//}

//// ����������� ����� � �������� ����������
//public static class CollectionExtensions
//{
//    public static void PrintToConsole<T>(this IEnumerable<T> collection) where T : IDataRow
//    {
//        foreach (var item in collection)
//        {
//            Console.WriteLine(item.GetFormattedString());
//        }
//    }
//}

//// ������������ ������
//class Program
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("=== ������������ ������ � Employee ===");

//        // ������� ��������� �����������
//        var employees = new List<Employee>
//        {
//            new Employee { Id = 1, FullName = "���� ������", Position = "�����������" },
//            new Employee { Id = 2, FullName = "����� ��������", Position = "��������" },
//            new Employee { Id = 3, FullName = "������� ������", Position = "��������" }
//        };

//        // ���������� ����� ����������
//        employees.PrintToConsole();

//        Console.WriteLine("\n=== ������������ ������ � Product ===");

//        // ������� ��������� �������
//        var products = new List<Product>
//        {
//            new Product { Sku = "A123", Name = "������", Price = 1500.00m },
//            new Product { Sku = "B456", Name = "���������", Price = 3200.50m },
//            new Product { Sku = "C789", Name = "������", Price = 899.99m }
//        };

//        // ���������� ����� ����������
//        products.PrintToConsole();

//        Console.WriteLine("\n=== ������������ � ������ ���������� ===");

//        // ������ ��������� - ������ �� ���������
//        var emptyEmployees = new List<Employee>();
//        emptyEmployees.PrintToConsole();
//        Console.WriteLine("(���� ������ �� �������� - ��������� �����)");

//        Console.WriteLine("\n=== ������������ � �������� ===");

//        // ������ � �������� (����� IEnumerable)
//        var productArray = new Product[]
//        {
//            new Product { Sku = "D000", Name = "������", Price = 1200.00m }
//        };

//        productArray.PrintToConsole();

//        Console.ReadLine();
//    }
//}
