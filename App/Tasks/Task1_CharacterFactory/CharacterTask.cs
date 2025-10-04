namespace App.Tasks.Task1_CharacterFactory
{
    public interface ICharacter
    {
        string Name { get; set; }
        void Attack();
    }

    public class Warrior : ICharacter
    {
        public Warrior() { }
        public string Name { get; set; }
        public void Attack()
        {
            Console.WriteLine("Воин наносит удар мечом!");
        }
    }

    public class Mage : ICharacter
    {
        public Mage() { }
        public string Name { get; set; }
        public void Attack()
        {
            Console.WriteLine("Маг кастует огненный шар!");
        }
    }

    public class CharacterFactory<T> where T : class, ICharacter, new()
    {
        public T Create(string name)
        {
            T character = new T();
            character.Name = name;
            return character;
        }
    }

    class Program
    {
        static void Main()
        {
            var factoryWarrior = new CharacterFactory<Warrior>();
            var factoryMage = new CharacterFactory<Mage>();

            Warrior warrior = factoryWarrior.Create("warrior");
            Mage mage = factoryMage.Create("mage");

            warrior.Attack();
            mage.Attack();
        }
    }
}