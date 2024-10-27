using System;

namespace HomeWorkRandomizer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int importedNumber1 = int.Parse(Console.ReadLine());

            Random random = new Random();
            int randomNumber = random.Next(1, 10);
            if (importedNumber1 == randomNumber)
            {
                Console.WriteLine("Cifri gamoicanit");
            }
            else
            {
                Console.WriteLine("gtxovt scadot tavivad");
                int importedNumber2 = int.Parse(Console.ReadLine());
                if (importedNumber2 == randomNumber)
                {
                    Console.WriteLine("Cifri gamoicanit");
                }
                else
                {
                    Console.WriteLine("gtxovt scadot tavivad");
                    int importedNumber3 = int.Parse(Console.ReadLine());
                    if (importedNumber3 == randomNumber)
                    {
                        Console.WriteLine("Cifri gamoicanit");
                    }
                    else
                    {
                        Console.WriteLine("tamashi waaget");
                    }
                }

            }
        }
    }
}

