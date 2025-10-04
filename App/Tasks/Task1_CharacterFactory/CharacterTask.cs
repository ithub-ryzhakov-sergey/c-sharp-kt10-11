namespace App.Tasks.Task1_CharacterFactory;



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
        var charecter = new T();
        charecter.Name = name;
        return charecter;

    }
}