using System;

namespace App.Tasks.Task1_CharacterFactory
{
    // Интерфейс персонажа
    public interface ICharacter
    {
        string Name { get; set; }
        void Attack();
    }

    // Класс Воина
    public class Warrior : ICharacter
    {
        public string Name { get; set; } = string.Empty;

        public void Attack()
        {
            Console.WriteLine("Воин наносит удар мечом!");
        }
    }

    // Класс Мага
    public class Mage : ICharacter
    {
        public string Name { get; set; } = string.Empty;

        public void Attack()
        {
            Console.WriteLine("Маг кастует огненный шар!");
        }
    }

    // Обобщенная фабрика персонажей
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