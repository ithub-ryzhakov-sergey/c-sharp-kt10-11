namespace App.Tasks.Task1_CharacterFactory; using System;

// Enum ��� ����� ������
public enum WariorType
{
    Warrior,
    Mage
}

// ��������� ���������
public interface ICharacter
{
    WariorType Type { get; set; }
    string Name { get; set; }
    void Attack();
}

// ����� �����
public class Warrior : ICharacter
{
    public WariorType Type { get; set; }
    public string Name { get; set; }

    public void Attack()
    {
        Console.WriteLine("���� ������� ���� �����!");
    }
}

// ����� ����
public class Mage : ICharacter
{
    public WariorType Type { get; set; }
    public string Name { get; set; }

    public void Attack()
    {
        Console.WriteLine("��� ������� �������� ���!");
    }
}

// ���������� ������� ����������
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

// ������������ ������
class Program
{
    static void Main(string[] args)
    {
        // ������� ������� ��� ������
        var warriorFactory = new CharacterFactory<Warrior>();
        ICharacter warrior = warriorFactory.Create(WariorType.Warrior, "�����");

        // ������� ������� ��� �����
        var mageFactory = new CharacterFactory<Mage>();
        ICharacter mage = mageFactory.Create(WariorType.Mage, "������");

        // ������������� �����
        Console.WriteLine($"{warrior.Name} ({warrior.Type}):");
        warrior.Attack();

        Console.WriteLine($"\n{mage.Name} ({mage.Type}):");
        mage.Attack();

        Console.ReadLine();
    }
}