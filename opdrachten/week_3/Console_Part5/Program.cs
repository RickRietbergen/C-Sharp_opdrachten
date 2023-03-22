using System;

namespace Console_Part5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {

                Console.WriteLine("");
                Console.WriteLine("==========");
                Console.WriteLine("Menu:");
                Console.WriteLine("Select An Option: ");
                Console.WriteLine("0. exit");
                Console.WriteLine("1. 5-7");
                Console.WriteLine("2. 5-8");
                Console.WriteLine("3. 5-9");
                Console.WriteLine("4. 5-11");
                Console.WriteLine("5. 5-14");
                Console.WriteLine("6. 5-15");
                var choice = int.Parse(Console.ReadLine());
                Console.WriteLine("==========");

                switch (choice)
                {
                    case 0:
                        Console.WriteLine("exit");
                        Environment.Exit(0);
                        break;
                    case 1:
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    case 6:
                        break;
                }
            }
            Console.Read();
        }
    }
}