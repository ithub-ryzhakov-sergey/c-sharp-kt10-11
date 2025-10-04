namespace App.Tests.Tasks.Task1_CharacterFactory;

public enum WariorType
{
    Warrior,
    Mage
}

public interface ICharacter
{
    WariorType Type { get; set; }
    void Attack();
}

public class Warrior : ICharacter
{
    public WariorType Type { get; set; }

    public void Attack()
    {
        Console.WriteLine("Воин наносит удар мечом!");
    }
}

public class Mage : ICharacter
{
    public WariorType Type { get; set; }

    public void Attack()
    {
        Console.WriteLine("Маг кастует огненный шар!");
    }
}

// Обобщённая фабрика персонажей
public class CharacterFactory<T> where T : ICharacter, new()
{
    public T Create(WariorType type)
    {
        var character = new T();
        character.Type = type;
        return character;
    }
}

public class Program
{
    public static void Main()
    {
        // Создание фабрики для воинов
        var warriorFactory = new CharacterFactory<Warrior>();
        var warrior = warriorFactory.Create(WariorType.Warrior);

        // Создание фабрики для магов
        var mageFactory = new CharacterFactory<Mage>();
        var mage = mageFactory.Create(WariorType.Mage);

        // Демонстрация атак
        Console.WriteLine("Демонстрация атак:");
        warrior.Attack();
        mage.Attack();

        Console.WriteLine($"\nТип warrior: {warrior.Type}");
        Console.WriteLine($"Тип mage: {mage.Type}");
    }
}