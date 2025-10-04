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
        Console.WriteLine("���� ������� ���� �����!");
    }
}

public class Mage : ICharacter
{
    public WariorType Type { get; set; }

    public void Attack()
    {
        Console.WriteLine("��� ������� �������� ���!");
    }
}

// ���������� ������� ����������
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
        // �������� ������� ��� ������
        var warriorFactory = new CharacterFactory<Warrior>();
        var warrior = warriorFactory.Create(WariorType.Warrior);

        // �������� ������� ��� �����
        var mageFactory = new CharacterFactory<Mage>();
        var mage = mageFactory.Create(WariorType.Mage);

        // ������������ ����
        Console.WriteLine("������������ ����:");
        warrior.Attack();
        mage.Attack();

        Console.WriteLine($"\n��� warrior: {warrior.Type}");
        Console.WriteLine($"��� mage: {mage.Type}");
    }
}