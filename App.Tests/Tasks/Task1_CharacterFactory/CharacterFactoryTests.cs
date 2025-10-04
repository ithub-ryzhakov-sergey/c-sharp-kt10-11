using System;
using System.IO;
using App.Tasks.Task1_CharacterFactory;
using NUnit.Framework;

namespace App.Tests.Tasks.Task1_CharacterFactory;

[TestFixture]
public class CharacterFactoryTests
{
    [Test]
    public void Warrior_Attack_PrintsExpectedMessage_AndNameFromEnum()
    {
        // Arrange
        var factory = new CharacterFactory<Warrior>();
        var warrior = factory.Create("warior");
        using var sw = new StringWriter();
        Console.SetOut(sw);

        // Act
        warrior.Attack();

        // Assert
        var output = sw.ToString().Trim();
        Assert.That(output, Is.EqualTo("Воин наносит удар мечом!"));
        Assert.That(warrior.Name, Is.EqualTo("warior"));
    }

    [Test]
    public void Mage_Attack_PrintsExpectedMessage_AndType()
    {
        // Arrange
        var factory = new CharacterFactory<Mage>();
        var mage = factory.Create("mage");
        using var sw = new StringWriter();
        Console.SetOut(sw);

        // Act
        mage.Attack();

        // Assert
        var output = sw.ToString().Trim();
        Assert.That(output, Is.EqualTo("Маг кастует огненный шар!"));
        Assert.That(mage.Type, Is.EqualTo("mage"));
    }

    [Test]
    public void Factory_CreatesDistinctTypes_WithCorrectType()
    {
        // Arrange
        var warriorFactory = new CharacterFactory<Warrior>();
        var mageFactory = new CharacterFactory<Mage>();

        // Act
        var warrior = warriorFactory.Create("warior");
        var mage = mageFactory.Create("mage");

        // Assert
        Assert.That(warrior, Is.Not.Null);
        Assert.That(mage, Is.Not.Null);
        Assert.That(warrior.Name, Is.EqualTo("warior"));
        Assert.That(mage.Type, Is.EqualTo("mage"));
        Assert.That(warrior, Is.InstanceOf<ICharacter>());
        Assert.That(mage, Is.InstanceOf<ICharacter>());
    }

    // Примечание: ограничения обобщения (ICharacter, new()) проверяются компилятором.
    // Создание CharacterFactory<НесоответствующийТип> должно давать ошибку компиляции, поэтому это не тестируется в runtime.
}
