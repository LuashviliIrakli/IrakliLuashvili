namespace EightHomework
{
    class Program
    {
        public class Person
        {
            public string Name;
            public int Age;
        }

        static void Main(string[] args)
        {
            string personName = "Irakli";
            int personAge = 35;

            Person person1 = new Person();
            person1.Name = personName;
            person1.Age = personAge;

            Person person2 = person1;

            person2.Name = "Giorgi";
            person2.Age = 30;
        }
    }
}
