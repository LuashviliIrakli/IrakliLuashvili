namespace SixthHomework
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            Console.WriteLine("Sheiyvanet mteli ricxvebis masivi mdzimit(,) gamoyofili");
            string input = Console.ReadLine();
            string[] stringArray = input.Split(',');
            int[] array = new int[stringArray.Length];

            for (int i = 0; i < stringArray.Length; i++)
            {
                array[i] = int.Parse(stringArray[i].Trim());
            }

            Console.WriteLine("Sheiyvanet indexi");
            int index = int.Parse(Console.ReadLine());

            if (index < 0 || index >= array.Length)
            {
                Console.WriteLine("Agnishnul indexze chanaweri/mnishvneloba ar arsebobs");
                return;
            }

            int result = SumOfDigitsAtIndex(array, index);
            Console.WriteLine($"Sum: {result}");
        }

        static int SumOfDigitsAtIndex(int[] array, int index)
        {
            int number = array[index];
            int sum = 0;
            while (number != 0)
            {
                sum += number % 10;
                number /= 10;
            }

            return sum;
        }
    }
}
