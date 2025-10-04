//using System;
//using System.IO;
//using System.Text;
//using System.Collections.Generic;
//using App.Tasks.Task3_Extensions;
//using NUnit.Framework;

//namespace App.Tests.Tasks.Task3_Extensions;

//[TestFixture]
//public class ExtensionTests
//{
//    [Test]
//    public void PrintToConsole_Employee_PrintsFormattedLine()
//    {
//        // Arrange
//        var employees = new List<Employee>
//        {
//            new Employee { Id = 1, FullName = "Иван Петров", Position = "Разработчик" },
//            new Employee { Id = 2, FullName = "Анна Сидорова", Position = "Тестировщик" }
//        };

//        using var sw = new StringWriter();
//        Console.SetOut(sw);

//        // Act
//        employees.PrintToConsole();

//        // Assert
//        var lines = sw.ToString().Trim().Split(new[] { Environment.NewLine }, StringSplitOptions.None);
//        Assert.That(lines.Length, Is.EqualTo(2));
//        Assert.That(lines[0], Is.EqualTo("ID: 1, Имя: Иван Петров, Должность: Разработчик"));
//        Assert.That(lines[1], Is.EqualTo("ID: 2, Имя: Анна Сидорова, Должность: Тестировщик"));
//    }

//    [Test]
//    public void PrintToConsole_Product_PrintsFormattedLine()
//    {
//        // Arrange
//        var products = new[] {
//            new Product { Sku = "A123", Name = "Чайник", Price = 1500.00m },
//            new Product { Sku = "B456", Name = "Тостер", Price = 899.99m }
//        };

//        using var sw = new StringWriter();
//        Console.SetOut(sw);

//        // Act
//        products.PrintToConsole();

//        // Assert
//        var lines = sw.ToString().Trim().Split(new[] { Environment.NewLine }, StringSplitOptions.None);
//        Assert.That(lines.Length, Is.EqualTo(2));
//        Assert.That(lines[0], Is.EqualTo("Артикул: A123, Название: Чайник, Цена: 1500.00"));
//        Assert.That(lines[1], Is.EqualTo("Артикул: B456, Название: Тостер, Цена: 899.99"));
//    }

//    [Test]
//    public void PrintToConsole_EmptyCollection_PrintsNothing()
//    {
//        // Arrange
//        var products = Array.Empty<Product>();
//        using var sw = new StringWriter();
//        Console.SetOut(sw);

//        // Act
//        products.PrintToConsole();

//        // Assert
//        var output = sw.ToString();
//        Assert.That(output, Is.EqualTo(string.Empty));
//    }

//    [Test]
//    public void PrintToConsole_Null_ThrowsArgumentNullException()
//    {
//        // Arrange
//        List<Employee>? employees = null;

//        // Act & Assert
//        Assert.Throws<ArgumentNullException>(() => employees!.PrintToConsole());
//    }
//}