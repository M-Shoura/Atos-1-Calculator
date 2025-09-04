using Atos_Task_1.Operations;
using System.Threading.Channels;

namespace Atos_Task_1
{
    internal class Program
    {
        public static void MenuPrinter()
        {
            Console.WriteLine("********************************************");
            Console.WriteLine("Choose the wanted Operation : ");
            Console.WriteLine("0 - Exit");
            Console.WriteLine("1 - Addition");
            Console.WriteLine("2 - Subtraction");
            Console.WriteLine("3 - Multiplication");
            Console.WriteLine("4 - Division");
            Console.WriteLine("5 - Power");
            Console.WriteLine("6 - Modulo");
            Console.WriteLine("7 - Square Root");
            Console.WriteLine("8 - History");
            Console.WriteLine("********************************************\n");
        }
        public static void TakeTwoNumbers(ref decimal a, ref decimal b) 
        {
            Console.Write("First Number: ");
            decimal.TryParse(Console.ReadLine(), out a);

            Console.Write("Second Number: ");
            decimal.TryParse(Console.ReadLine(), out b);
        }
        public static void TakeOneNumber(ref decimal a)
        {
            Console.Write("The Number: ");
            decimal.TryParse(Console.ReadLine(), out a);
        }

        static void Main(string[] args)
        {
            Calculator calculator = Calculator.GetCalculator();
            Logger logger = new Logger();
            decimal a = 0, b = 0;
            int choice = 0;
            do
            {
                MenuPrinter();
                Console.Write("Your Choice: ");
                int.TryParse(Console.ReadLine(), out choice);

                if (choice == 1)
                {
                    TakeTwoNumbers(ref a, ref b);
                    decimal ans = calculator.Apply(new Addition(logger), a, b);
                    Console.WriteLine(logger.Logs.LastOrDefault());
                }
                else if (choice == 2)
                {
                    TakeTwoNumbers(ref a, ref b);
                    decimal ans = calculator.Apply(new Subtraction(logger), a, b);
                    Console.WriteLine(logger.Logs.LastOrDefault());
                }
                else if (choice == 3)
                {
                    TakeTwoNumbers(ref a, ref b);
                    decimal ans = calculator.Apply(new Multiplication(logger), a, b);
                    Console.WriteLine(logger.Logs.LastOrDefault());
                }
                else if (choice == 4)
                {
                    TakeTwoNumbers(ref a, ref b);

                    try
                    {
                        decimal ans = calculator.Apply(new Division(logger), a, b);
                    }
                    catch (DivideByZeroException ex)
                    {
                        Console.WriteLine($"Error : {ex.Message}");
                    }

                    Console.WriteLine(logger.Logs.LastOrDefault());
                }
                else if (choice == 5)
                {
                    TakeTwoNumbers(ref a, ref b);
                    decimal ans = calculator.Apply(new Power(logger), a, b);
                    Console.WriteLine(logger.Logs.LastOrDefault());
                }
                else if (choice == 6)
                {
                    TakeTwoNumbers(ref a, ref b);
                    decimal ans = calculator.Apply(new Modulo(logger), a, b);
                    Console.WriteLine(logger.Logs.LastOrDefault());
                }
                else if (choice == 7)
                {
                    TakeOneNumber(ref a);
                    decimal ans = calculator.Apply(new SquareRoot(logger), a);
                    Console.WriteLine(logger.Logs.LastOrDefault());
                }
                else if (choice == 8)
                {
                    Console.Clear();
                
                    if (logger.Logs.Count == 0)
                        Console.WriteLine("No History !!");
                    else
                    {
                        foreach (var n in logger.Logs)
                        {
                            Console.WriteLine(n);
                        }
                    }
                
                    Console.WriteLine("Press any key to continue");
                    Console.ReadKey();
                    Console.Clear();
                }
                
                Console.WriteLine();
            }
            while (choice != 0);
        }
    }
}