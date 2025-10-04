namespace App.Tasks.Task1_CharacterFactory;

public enum WariorType
{
    Warrior, Mage
}

public interface ICharacter
{
    public WariorType Type { get; set; }

    public void Attack();
}

public class Warrior : ICharacter
{
    public WariorType Type { get; set; } = WariorType.Warrior;
    public void Attack()
    {
        Console.WriteLine("Воин наносит удар мечом!");
    }
}

public class Mage : ICharacter
{
    public WariorType Type { get; set; } = WariorType.Mage;
    public void Attack()
    {
        Console.WriteLine("Маг кастует огненный шар!");
    }
}

public class CharacterFactory<T> where T : ICharacter, new()
{
    public T Create(WariorType type)
    {
        T character = new T();
        character.Type = type;
        return character;
    }
}