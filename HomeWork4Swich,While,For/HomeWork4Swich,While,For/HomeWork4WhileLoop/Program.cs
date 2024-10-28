using static System.Runtime.InteropServices.JavaScript.JSType;

namespace HomeWork4WhileLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            while (true)
            {
                int number = int.Parse(Console.ReadLine());

                if (number >= 0)
                {
                    sum += number;
                }
                else
                {
                    Console.WriteLine("Jami: " + sum);
                    break;
                }
            }

        }
    }
}
