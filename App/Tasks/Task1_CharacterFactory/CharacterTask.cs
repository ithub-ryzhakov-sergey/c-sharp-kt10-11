namespace App.Tasks.Task1_CharacterFactory;

public interface ICharacter
{
    string Name { get; set; }
    void Attack();
}

public class CharacterFactory<T> where T : ICharacter, new()
{
    public T Create(string name) {
        return new T()
        {
            Name = name
        };
    }
}
public class Warrior : ICharacter
{
    public string Name{ get; set; }
    public void Attack()
    {
        System.Console.WriteLine("Воин наносит удар мечом!");
    }
}
public class Mage : ICharacter
{
    public string Name{ get; set; }
    public void Attack()
    {
        System.Console.WriteLine("Маг кастует огненный шар!");
    }
}