namespace HomeWork4Swich_While_For
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int day = int.Parse(Console.ReadLine());
            switch (day)
            {
                case 1:
                    Console.WriteLine("orshabati");
                    break;
                case 2:
                    Console.WriteLine("samshabati");
                    break;
                case 3:
                    Console.WriteLine("otxshabati");
                    break;
                case 4:
                    Console.WriteLine("xutshabati");
                    break;
                case 5:
                    Console.WriteLine("paraskevi");
                    break;
                case 6:
                    Console.WriteLine("shabati");
                    break;
                case 7:
                    Console.WriteLine("kvira");
                    break;
                default:
                    Console.WriteLine("araswori ricxvi");
                    break;
            }

        }
    }
}
