namespace App.Tasks.Task1_CharacterFactory; using System;

// Enum для типов воинов
public enum WariorType
{
    Warrior,
    Mage
}

// Интерфейс персонажа
public interface ICharacter
{
    WariorType Type { get; set; }
    string Name { get; set; }
    void Attack();
}

// Класс Воина
public class Warrior : ICharacter
{
    public WariorType Type { get; set; }
    public string Name { get; set; }

    public void Attack()
    {
        Console.WriteLine("Воин наносит удар мечом!");
    }
}

// Класс Мага
public class Mage : ICharacter
{
    public WariorType Type { get; set; }
    public string Name { get; set; }

    public void Attack()
    {
        Console.WriteLine("Маг кастует огненный шар!");
    }
}

// Обобщенная фабрика персонажей
public class CharacterFactory<T> where T : ICharacter, new()
{
    public T Create(WariorType type, string name)
    {
        T character = new T();
        character.Type = type;
        character.Name = name;
        return character;
    }
}

// Демонстрация работы
class Program
{
    static void Main(string[] args)
    {
        // Создаем фабрику для воинов
        var warriorFactory = new CharacterFactory<Warrior>();
        ICharacter warrior = warriorFactory.Create(WariorType.Warrior, "Артур");

        // Создаем фабрику для магов
        var mageFactory = new CharacterFactory<Mage>();
        ICharacter mage = mageFactory.Create(WariorType.Mage, "Мерлин");

        // Демонстрируем атаки
        Console.WriteLine($"{warrior.Name} ({warrior.Type}):");
        warrior.Attack();

        Console.WriteLine($"\n{mage.Name} ({mage.Type}):");
        mage.Attack();

        Console.ReadLine();
    }
}