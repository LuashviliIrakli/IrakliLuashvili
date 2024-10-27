using System;

namespace HomeWorkRandomizer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int importedNumber = int.Parse(Console.ReadLine());

            Random random = new Random();
            int randomNumber = random.Next(1, 10);
            if (importedNumber == randomNumber)
            {
                Console.WriteLine("Cifri gamoicanit");
            }
            else
            {
                Console.WriteLine("gtxovt scadot tavivad");
                importedNumber = int.Parse(Console.ReadLine());
                if (importedNumber == randomNumber)
                {
                    Console.WriteLine("Cifri gamoicanit");
                }
                else
                {
                    Console.WriteLine("gtxovt scadot tavivad");
                    importedNumber = int.Parse(Console.ReadLine());
                    if (importedNumber == randomNumber)
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

