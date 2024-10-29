namespace FiveHomewoorkStudents
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] students = new string[3];
            for (int i = 0; i < students.Length; i++)
            {
                students[i] = Console.ReadLine();
            }
            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine(students[i]);
            }
        }
    }
}
