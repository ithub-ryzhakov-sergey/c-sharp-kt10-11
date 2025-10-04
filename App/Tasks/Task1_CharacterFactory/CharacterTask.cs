using System;

namespace App.Tasks.Task1_CharacterFactory
{
    // ��������� ���������
    public interface ICharacter
    {
        string Name { get; set; }
        void Attack();
    }

    // ����� �����
    public class Warrior : ICharacter
    {
        public string Name { get; set; } = string.Empty;

        public void Attack()
        {
            Console.WriteLine("���� ������� ���� �����!");
        }
    }

    // ����� ����
    public class Mage : ICharacter
    {
        public string Name { get; set; } = string.Empty;

        public void Attack()
        {
            Console.WriteLine("��� ������� �������� ���!");
        }
    }

    // ���������� ������� ����������
    public class CharacterFactory<T> where T : ICharacter, new()
    {
        public T Create(string name)
        {
            var character = new T();
            character.Name = name;
            return character;
        }
    }
}