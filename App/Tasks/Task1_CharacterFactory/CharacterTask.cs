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
        Console.WriteLine("���� ������� ���� �����!");
    }
}

public class Mage : ICharacter
{
    public string Name { get; set; }

    public void Attack()
    {
        Console.WriteLine("��� ������� �������� ���!");
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
        ICharacter warrior = warriorFactory.Create("�����");

        var mageFactory = new CharacterFactory<Mage>();
        ICharacter mage = mageFactory.Create("���������� �������");

        warrior.Attack();
        mage.Attack();

        Console.WriteLine($"��� �����: {warrior.Name}");
        Console.WriteLine($"��� ����: {mage.Name}");
    }
}
