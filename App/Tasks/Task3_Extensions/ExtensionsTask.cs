//namespace App.Tasks.Task3_Extensions;
//using System;
//using System.Collections.Generic;
//using System.Linq;

//// Интерфейс для форматирования данных
//public interface IDataRow
//{
//    string GetFormattedString();
//}

//// Класс Employee
//public class Employee : IDataRow
//{
//    public int Id { get; set; }
//    public string FullName { get; set; }
//    public string Position { get; set; }

//    public string GetFormattedString()
//    {
//        return $"ID: {Id}, Имя: {FullName}, Должность: {Position}";
//    }
//}

//// Класс Product
//public class Product : IDataRow
//{
//    public string Sku { get; set; }
//    public string Name { get; set; }
//    public decimal Price { get; set; }

//    public string GetFormattedString()
//    {
//        return $"Артикул: {Sku}, Название: {Name}, Цена: {Price:F2}";
//    }
//}

//// Статический класс с методами расширения
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

//// Демонстрация работы
//class Program
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("=== Демонстрация работы с Employee ===");

//        // Создаем коллекцию сотрудников
//        var employees = new List<Employee>
//        {
//            new Employee { Id = 1, FullName = "Иван Петров", Position = "Разработчик" },
//            new Employee { Id = 2, FullName = "Мария Сидорова", Position = "Дизайнер" },
//            new Employee { Id = 3, FullName = "Алексей Иванов", Position = "Менеджер" }
//        };

//        // Используем метод расширения
//        employees.PrintToConsole();

//        Console.WriteLine("\n=== Демонстрация работы с Product ===");

//        // Создаем коллекцию товаров
//        var products = new List<Product>
//        {
//            new Product { Sku = "A123", Name = "Чайник", Price = 1500.00m },
//            new Product { Sku = "B456", Name = "Кофеварка", Price = 3200.50m },
//            new Product { Sku = "C789", Name = "Тостер", Price = 899.99m }
//        };

//        // Используем метод расширения
//        products.PrintToConsole();

//        Console.WriteLine("\n=== Демонстрация с пустой коллекцией ===");

//        // Пустая коллекция - ничего не выводится
//        var emptyEmployees = new List<Employee>();
//        emptyEmployees.PrintToConsole();
//        Console.WriteLine("(Выше ничего не вывелось - коллекция пуста)");

//        Console.WriteLine("\n=== Демонстрация с массивом ===");

//        // Работа с массивом (также IEnumerable)
//        var productArray = new Product[]
//        {
//            new Product { Sku = "D000", Name = "Миксер", Price = 1200.00m }
//        };

//        productArray.PrintToConsole();

//        Console.ReadLine();
//    }
//}
