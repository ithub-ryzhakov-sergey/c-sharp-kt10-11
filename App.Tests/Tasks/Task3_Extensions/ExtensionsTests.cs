//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;
//using System.Text;
//using App.Tasks.Task3_Extensions;
//using NUnit.Framework;

//namespace App.Tests.Tasks.Task3_Extensions
//{
//    [TestFixture]
//    public class ExtensionsTests
//    {
//        [Test]
//        public void PrintToConsole_Employees_PrintsFormattedLines()
//        {
//            // Arrange
//            var employees = new List<Employee>
//            {
//                new Employee { Id = 1, FullName = "Иван Петров", Position = "Разработчик" },
//                new Employee { Id = 2, FullName = "Анна Смирнова", Position = "Тестировщик" },
//            };
//            using var sw = new StringWriter(new StringBuilder());
//            Console.SetOut(sw);

//            // Act
//            employees.PrintToConsole();

//            // Assert
//            var lines = sw.ToString().Trim().Split(new[] { Environment.NewLine }, StringSplitOptions.None);
//            Assert.That(lines.Length, Is.EqualTo(2));
//            Assert.That(lines[0], Is.EqualTo("ID: 1, Имя: Иван Петров, Должность: Разработчик"));
//            Assert.That(lines[1], Is.EqualTo("ID: 2, Имя: Анна Смирнова, Должность: Тестировщик"));
//        }

//        [Test]
//        public void PrintToConsole_ProductsArray_PrintsFormattedLines()
//        {
//            // Arrange
//            var products = new[] {
//                new Product { Sku = "A123", Name = "Чайник", Price = 1500.00m },
//                new Product { Sku = "B456", Name = "Tostor", Price = 3499.99m },
//            };

//            using var sw = new StringWriter(new StringBuilder());
//            Console.SetOut(sw);

//            // Act
//            products.PrintToConsole();

//            // Assert
//            var lines = sw.ToString().Trim().Split(new[] { Environment.NewLine }, StringSplitOptions.None);
//            Assert.That(lines.Length, Is.EqualTo(2));
//            Assert.That(lines[0], Is.EqualTo("Артикул: A123, Название: Чайник, Цена: 1500.00"));
//            Assert.That(lines[1], Is.EqualTo("Артикул: B456, Название: Tostor, Цена: 3499.99"));
//        }

//        [Test]
//        public void PrintToConsole_EmptyCollection_PrintsNothing()
//        {
//            // Arrange
//            var products = Array.Empty<Product>();
//            using var sw = new StringWriter(new StringBuilder());
//            Console.SetOut(sw);

//            // Act
//            products.PrintToConsole();

//            // Assert
//            var output = sw.ToString();
//            Assert.That(output, Is.EqualTo(string.Empty));
//        }

//        [Test]
//        public void PrintToConsole_Null_ThrowsArgumentNullException()
//        {
//            // Arrange
//            List<Employee>? employees = null;

//            // Act & Assert
//            Assert.Throws<ArgumentNullException>(() => employees!.PrintToConsole());
//        }
//    }
//}