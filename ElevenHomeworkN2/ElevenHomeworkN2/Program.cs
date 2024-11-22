namespace ElevenHomeworkN2
{
    public static class MathHelper
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static int Subtract(int a, int b)
        {
            return a - b;
        }

        public static int Multiply(int a, int b)
        {
            return a * b;
        }

        public static double Divide(int a, int b)
        {
            if (b == 0)
            {
                throw new ArgumentException("nulze gayofa daushvebelia.");
            }
            return (double)a / b;
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            int a = 10;
            int b = 5;


            Console.WriteLine($"Add({a}, {b}) = {MathHelper.Add(a, b)}");
            Console.WriteLine($"Subtract({a}, {b}) = {MathHelper.Subtract(a, b)}");
            Console.WriteLine($"Multiply({a}, {b}) = {MathHelper.Multiply(a, b)}");
            try
            {
                Console.WriteLine($"Divide({a}, {b}) = {MathHelper.Divide(a, b)}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                Console.WriteLine($"Divide({a}, 0) = {MathHelper.Divide(a, 0)}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
