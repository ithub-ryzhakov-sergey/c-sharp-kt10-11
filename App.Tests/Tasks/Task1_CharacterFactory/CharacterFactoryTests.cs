using System;
using System.IO;
using NUnit.Framework;
using CharacterFactory;

namespace CharacterFactory.Tests
{
    [TestFixture]
    public class CharacterFactoryTests
    {
        [Test]
        public void Warrior_Attack_PrintsCorrectMessage_AndNameFromFactory()
        {
            // Arrange
            var factory = new CharacterFactory<CharacterFactory.Warrior>();
            var warrior = factory.Create(WariorType.Warrior, "Тестовый Воин");
            using var sw = new StringWriter();
            Console.SetOut(sw);

            // Act
            warrior.Attack();

            // Assert
            var output = sw.ToString().Trim();
            Assert.That(output, Is.EqualTo("Воин наносит удар мечом!"));
            Assert.That(warrior.Type, Is.EqualTo(WariorType.Warrior));
            Assert.That(warrior.Name, Is.EqualTo("Тестовый Воин"));
        }

        [Test]
        public void Mage_Attack_PrintsCorrectMessage_AndType()
        {
            // Arrange
            var factory = new CharacterFactory<CharacterFactory.Mage>();
            var mage = factory.Create(WariorType.Mage, "Тестовый Маг");
            using var sw = new StringWriter();
            Console.SetOut(sw);

            // Act
            mage.Attack();

            // Assert
            var output = sw.ToString().Trim();
            Assert.That(output, Is.EqualTo("Маг кастует огненный шар!"));
            Assert.That(mage.Type, Is.EqualTo(WariorType.Mage));
            Assert.That(mage.Name, Is.EqualTo("Тестовый Маг"));
        }

        [Test]
        public void Factory_CreatesDifferentTypes_WithCorrectType()
        {
            // Arrange
            var warriorFactory = new CharacterFactory<CharacterFactory.Warrior>();
            var mageFactory = new CharacterFactory<CharacterFactory.Mage>();

            // Act
            var warrior = warriorFactory.Create(WariorType.Warrior, "Воин");
            var mage = mageFactory.Create(WariorType.Mage, "Маг");

            // Assert
            Assert.That(warrior, Is.Not.Null);
            Assert.That(mage, Is.Not.Null);
            Assert.That(warrior.Type, Is.EqualTo(WariorType.Warrior));
            Assert.That(mage.Type, Is.EqualTo(WariorType.Mage));
            Assert.That(warrior, Is.InstanceOf<Warrior>());
            Assert.That(mage, Is.InstanceOf<Mage>());
        }
    }
}