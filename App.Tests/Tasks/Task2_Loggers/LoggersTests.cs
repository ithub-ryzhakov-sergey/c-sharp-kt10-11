using System;
using System.IO;
using System.Text;
using App.Tasks.Task2_Loggers;
using NUnit.Framework;

namespace App.Tests.Tasks.Task2_Loggers;

[TestFixture]
public class LoggersTests
{
    [Test]
    public void ObjectLogger_WithNonNullString_PrintsValue()
    {
        // Arrange
        var logger = new ObjectLogger<string>();
        using var sw = new StringWriter(new StringBuilder());
        Console.SetOut(sw);

        // Act
        logger.Log("Hello, world!");

        // Assert
        var output = sw.ToString().TrimEnd();
        Assert.That(output, Is.EqualTo("Hello, world!"));
    }

    [Test]
    public void ObjectLogger_WithNull_PrintsNullMessage()
    {
        // Arrange
        var logger = new ObjectLogger<string>();
        using var sw = new StringWriter(new StringBuilder());
        Console.SetOut(sw);

        // Act
        logger.Log(null);

        // Assert
        var output = sw.ToString().Trim();
        Assert.That(output, Is.EqualTo("Объект пуст (null)"));
    }

    private sealed class User
    {
        public string Name { get; init; } = string.Empty;
        public override string ToString() => $"User: {Name}";
    }

    [Test]
    public void ObjectLogger_WithCustomReferenceType_PrintsToString()
    {
        // Arrange
        var logger = new ObjectLogger<User>();
        using var sw = new StringWriter(new StringBuilder());
        Console.SetOut(sw);
        var user = new User { Name = "Alice" };

        // Act
        logger.Log(user);

        // Assert
        var output = sw.ToString().TrimEnd();
        Assert.That(output, Is.EqualTo("User: Alice"));
    }

    [Test]
    public void ValueLogger_WithDateTime_PrintsToString()
    {
        // Arrange
        var logger = new ValueLogger<DateTime>();
        using var sw = new StringWriter(new StringBuilder());
        Console.SetOut(sw);
        var dt = new DateTime(2024, 1, 2, 3, 4, 5, 6, DateTimeKind.Unspecified);

        // Act
        logger.Log(dt);

        // Assert
        var output = sw.ToString().TrimEnd();
        Assert.That(output, Is.EqualTo(dt.ToString()));
    }

    [Test]
    public void ValueLogger_WithDefaultStructValue_PrintsToString()
    {
        // Arrange
        var logger = new ValueLogger<int>();
        using var sw = new StringWriter(new StringBuilder());
        Console.SetOut(sw);
        var value = default(int);

        // Act
        logger.Log(value);

        // Assert
        var output = sw.ToString().TrimEnd();
        Assert.That(output, Is.EqualTo(value.ToString()));
    }

    // Компилятор должен запретить следующие конструкты из-за ограничений обобщений:
    // - ObjectLogger<int> (int — тип-значение, нужен ссылочный тип)
    // - ValueLogger<string> (string — ссылочный тип, нужен тип-значение)
    // Эти случаи не проверяются рантайм-тестами, так как ожидаются на этапе компиляции.
}
