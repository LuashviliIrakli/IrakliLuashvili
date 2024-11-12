namespace NineHomework
{
    public interface IAnimal
    {
        string MakeSound();
    }

    public abstract class Animal : IAnimal
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Animal(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public abstract string MakeSound();
    }

    public class Dog : Animal
    {
        public Dog(string name, int age)

        public override string MakeSound()
        {
            return "Woof";
        }
    }

    public class Cat : Animal
    {
        public Cat(string name, int age)

        public override string MakeSound()
        {
            return "Meow";
        }
    }

    public class Cow : Animal
    {
        public Cow(string name, int age)

        public override string MakeSound()
        {
            return "Moo";
        }
    }

    class Program
    {
        static void Main()
        {
            IAnimal[] animals = new IAnimal[]
            {
            new Dog("Jesi", 3),
            new Cat("L", 2),
            new Cow("Nikora", 5)
            };

            foreach (var animal in animals)
            {
                Console.WriteLine($"{animal.GetType().Name} says: {animal.MakeSound()}");
            }
        }
    }

}
