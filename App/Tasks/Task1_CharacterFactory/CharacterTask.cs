using System.Reflection.Metadata.Ecma335;

namespace App.Tasks.Task1_CharacterFactory;

public interface ICharacter
{
    string Name { get; set; }

    void Attack();
}

public class Warrior : ICharacter
{
    public string Name { get; set; }

    public void Attack()
    {
        Console.WriteLine("Воин наносит удар мечом!");
    }
}

public class Mage : ICharacter
{
    public string Name { get; set; }

    public void Attack()
    {
        Console.WriteLine("Маг кастует огненный шар!");
    }
}

public class CharacterFactory<T> where T : ICharacter, new()
{
    public string Name { get; set; }
    public T Create(string name)
    {
        T character = new T();
        character.Name = name;
        return character;
    }
}

public class Program
{
    static void Main()
    {
        var warriorFactory = new CharacterFactory<Warrior>();
        ICharacter warrior = warriorFactory.Create("Артас");

        var mageFactory = new CharacterFactory<Mage>();
        ICharacter mage = mageFactory.Create("Инструктор Гэлфорд");

        warrior.Attack();
        mage.Attack();

        Console.WriteLine($"Имя воина: {warrior.Name}");
        Console.WriteLine($"Имя мага: {mage.Name}");
    }
}
