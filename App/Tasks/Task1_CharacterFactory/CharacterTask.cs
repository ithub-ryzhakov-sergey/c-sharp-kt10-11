using System.Xml.Linq;

namespace App.Tasks.Task1_CharacterFactory;

public enum WariorType
{
    Warrior, Mage
}

public interface ICharacter
{
    public string Name { get; set; }

    public void Attack();
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
    public T Create(string name)
    {
        T character = new T();
        character.Name = name;
        return character;
    }
}