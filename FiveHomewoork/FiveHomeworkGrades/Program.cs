namespace FiveHomeworkGrades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] students = new string[3];
            int[,] grades = new int[3, 2];

            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine("sheiyvanet studentis saxeli");
                students[i] = Console.ReadLine();

                Console.WriteLine("sheiyvanet qulebi");

                for (int j = 0; j < 2; j++)
                {
                    Console.Write($"sagani {j + 1}: ");
                    grades[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("studentis qulebi: ");
            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine($"{students[i]}: qulebi - {grades[i, 0]}, {grades[i, 1]}");
            }
        }
    }
}
