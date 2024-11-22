namespace ElevenHomework
{
    public class Counter
    {
        private static int Count = 0;

        public Counter()
        {
            Count++;
        }

        public static int GetCount()
        {
            return Count;
        }

        public static void ResetCount()
        {
            Count = 0;
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            Counter counter1 = new Counter();
            Console.WriteLine($"Count: {Counter.GetCount()}");

            Counter counter2 = new Counter();
            Console.WriteLine($"Count: {Counter.GetCount()}");

            Counter counter3 = new Counter();
            Console.WriteLine($"Count: {Counter.GetCount()}");

            Counter.ResetCount();
            Console.WriteLine($"Count after reset: {Counter.GetCount()}");

            Counter counter4 = new Counter();
            Console.WriteLine($"Count after new object: {Counter.GetCount()}");
        }
    }
}
