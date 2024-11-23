namespace FourteenHomework
{
    using System;

    class Program
    {
        public class InvalidCalculationException : Exception
        {
            public int StatusCode { get; set; }

            public InvalidCalculationException(string message, int statusCode) : base(message)
            {
                StatusCode = statusCode;
            }
        }

        static void Main()
        {
            double firstNumber = 0;
            double secondNumber = 0;
            string operation = "";

            while (true)
            {
                try
                {
                    Console.Write("sheiyvanet pirveli ricxvi: ");
                    firstNumber = Convert.ToDouble(Console.ReadLine());

                    Console.Write("sheiyvanet meore ricxvi: ");
                    secondNumber = Convert.ToDouble(Console.ReadLine());

                    Console.Write("sheiyvanet operacia/simbolo (+, -, *, /): ");
                    operation = Console.ReadLine();

                    if (operation != "+" && operation != "-" && operation != "*" && operation != "/")
                    {
                        throw new InvalidOperationException("araswori operacia/simbolo!");
                    }

                    double result = 0;

                    switch (operation)
                    {
                        case "+":
                            result = firstNumber + secondNumber;
                            break;
                        case "-":
                            result = firstNumber - secondNumber;
                            break;
                        case "*":
                            result = firstNumber * secondNumber;
                            break;
                        case "/":
                            if (secondNumber == 0)
                            {
                                throw new DivideByZeroException("nulze gayofa sheudzlebelia.");
                            }
                            result = firstNumber / secondNumber;
                            break;
                    }

                    Console.WriteLine($"shedegi: {result}");
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("araswori simbolo, sheiyvanet validuri ricxvi.");
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (InvalidOperationException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (InvalidCalculationException ex)
                {
                    Console.WriteLine($"Error: {ex.Message}, Status Code: {ex.StatusCode}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"dafiqsirda shecdoma: {ex.Message}");
                }
            }
        }
    }

}
