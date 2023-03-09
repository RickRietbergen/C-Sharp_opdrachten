using System.ComponentModel;

namespace ConsoleAppTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("");
                Console.WriteLine("1 - 1-10");
                Console.WriteLine("2 - 1-15");
                Console.WriteLine("3 - 1-16");
                Console.WriteLine("4 - 1-23");
                Console.WriteLine("5 - 1-33");
                Console.WriteLine("6 - 1-40");
                Console.WriteLine("7 - 2-4");
                Console.WriteLine("8 - 2-8");
                Console.WriteLine("9 - 2-11");
                Console.WriteLine("10 - 2-17");
                Console.WriteLine("11 - 2-20");
                Console.WriteLine("12 - 2-21");
                Console.WriteLine("Select your choice: ");
                var choice = int.Parse(Console.ReadLine());

                switch (choice){
                    case 1:
                        //exercise 1 - 10
                        Console.WriteLine("I will tell a story, but I need some information.");
                        Console.WriteLine("Give a name for main character:");
                        string name = Console.ReadLine();
                        Console.WriteLine("Give the character a profession:");
                        string profession = Console.ReadLine();

                        Console.WriteLine("Here is the story:");
                        Console.WriteLine("Once upon a time there was a " + profession + " called " + name + ".");
                        Console.WriteLine("On his way to work, " + name + " often pondered what being " + profession + " meant to them.");
                        Console.WriteLine("When you work as a " + profession + " you meet interesting people.");
                        Console.WriteLine(name + " enjoys their work as " + profession + ", The end.");
                        break;
                    case 2:
                        //exercise 1 - 15
                        Console.WriteLine("Give a string:");
                        string str = Console.ReadLine();
                        Console.WriteLine("Give an integer:");
                        int integer = int.Parse(Console.ReadLine());
                        Console.WriteLine("Give a double:");
                        double dble = double.Parse(Console.ReadLine());
                        Console.WriteLine("Give a boolean:");
                        bool boolean = bool.Parse(Console.ReadLine());

                        Console.WriteLine($"Your string: " + str);
                        Console.WriteLine("Your integer: " + integer);
                        Console.WriteLine("Your double: " + dble);
                        Console.WriteLine("Your boolean: " + boolean);
                        break;
                    case 3:
                        //exercise 1-16 calculations
                        int daytimeSeconds = 86400;
                        Console.WriteLine("How many days?");
                        int amountDays = int.Parse(Console.ReadLine());
                        int totalSeconds = daytimeSeconds * amountDays;
                        Console.WriteLine(amountDays + " days has " + totalSeconds + " seconds");
                        break;
                    case 4:
                        //exercise 1-23
                        Console.WriteLine("Give the first number!");
                        int firstNumber = int.Parse(Console.ReadLine());
                        Console.WriteLine("Give the second number!");
                        int secondNumber = int.Parse(Console.ReadLine());

                        Console.WriteLine($"{firstNumber} + {secondNumber} = " + (firstNumber + secondNumber));
                        Console.WriteLine($"{firstNumber} - {secondNumber} = " + (firstNumber - secondNumber));
                        Console.WriteLine($"{firstNumber} * {secondNumber} = " + (firstNumber * secondNumber));
                        Console.WriteLine($"{firstNumber} / {secondNumber} = " + (firstNumber / secondNumber));
                        break;
                    case 5:
                        //exercise 1-33
                        Console.WriteLine("Give the first string:");
                        string firstString = Console.ReadLine();
                        Console.WriteLine("Give the second string:");
                        string secondString = Console.ReadLine();

                        //var result = firstString == secondString ? "Echo!" : "Nope!";
                        //Console.WriteLine(result);
                        if (firstString == secondString)
                        {
                            Console.WriteLine("Echo!");
                        }
                        else
                        {
                            Console.WriteLine("Nope!");
                        }
                        break;
                    case 6:
                        //exerise 1-40
                        var totalNumbers = 0;
                        Console.WriteLine("Give a number:");
                        int number1 = int.Parse(Console.ReadLine());
                        totalNumbers++;
                        Console.WriteLine("Give a number:");
                        int number2 = int.Parse(Console.ReadLine());
                        totalNumbers++;
                        Console.WriteLine("Give a number:");
                        int number3 = int.Parse(Console.ReadLine());
                        totalNumbers++;
                        Console.WriteLine("Give a number:");
                        int number4 = int.Parse(Console.ReadLine());
                        totalNumbers++;

                        Console.WriteLine("Total sum of numbers: " + (number1 + number2 + number3 + number4));
                        Console.WriteLine("Total amount of numbers: " + totalNumbers);
                        break;
                    case 7:
                        //exercise 2-4
                        Console.WriteLine("give a number:");
                        var first = int.Parse(Console.ReadLine());
                        Console.WriteLine("give a number:");
                        var second = int.Parse(Console.ReadLine());

                        if (first > second)
                        {
                            Console.WriteLine($"{first} is greater than {second}");
                        }
                        else if (first < second)
                        {
                            Console.WriteLine($"{first} is less than {second}");
                        }
                        else
                        {
                            Console.WriteLine($"{first} is equal to {second}");
                        }
                        break;
                    case 8:
                        //exercise 2-8
                        Console.WriteLine("give numbers:");
                        var number = int.Parse(Console.ReadLine());
                        var sum = number;
                        var amountOfNumbers = 0;
                        var amountOfEvenNumbers = 0;
                        var amountOfUnevenNumbers = 0;

                        while (number != -1)
                        {
                            Console.WriteLine("give numbers:");
                            number = int.Parse(Console.ReadLine());
                            amountOfNumbers++;

                            if (number != -1)
                            {
                                sum += number;
                            }

                            if (number%2 == 0)
                            {
                                amountOfEvenNumbers++;
                            }
                            else
                            {
                                amountOfUnevenNumbers++;
                            }

                            if (number == -1)
                            {
                                var average = sum / amountOfNumbers;

                                Console.WriteLine("thx! bye!");
                                Console.WriteLine("Sum: " + sum);
                                Console.WriteLine("amount of numbers: " + amountOfNumbers);
                                Console.WriteLine("Average: " + average);
                                Console.WriteLine("Amount of even numbers: " + amountOfEvenNumbers);
                                Console.WriteLine("Amount of uneven numbers: " + amountOfUnevenNumbers);
                                break;
                            }
                        }
                        break;
                    case 9:
                        //exercise 2-11,
                        PrintUntilNumber(10);
                        break;
                    case 10:
                        //exercise 2-17
                        int answer = Sum(6, 4, 6, 1);
                        Console.WriteLine("Sum: " + answer);
                        break;
                    case 11:
                        //exercise 2-20
                        PrintStars(5);
                        Console.WriteLine("");
                        PrintSquare(4);
                        Console.WriteLine("");
                        PrintRectangle(17, 3);
                        Console.WriteLine("");
                        PrintTriangle(4);
                        break;
                    case 12:
                        //exercise 2-21
                        ChristmasTree(11);
                        break;
                }
            }

            ////exercise 1-1
            //Console.WriteLine("Hello, World!");

            ////exercise 1-2
            //Console.WriteLine($"{Environment.NewLine}Once upon a time");
            //Console.WriteLine("I was falling in love");
            //Console.WriteLine("Now I’m only falling apart");

            ////exercise 1-3
            //Console.WriteLine($"{Environment.NewLine}Once upon a time {Environment.NewLine}I was falling in love {Environment.NewLine}Now I’m only falling apart");

            ////exercise 1-4
            //string message = "Passport and a toothbrush!";
            //Console.WriteLine(message);

            ////exercise 1-5
            //string name = "Ada Lovelace";
            //name = "Hello Ada LoveLace!";
            //Console.WriteLine(name);

            ////exercise 1-6
            //string input = Console.ReadLine();
            //Console.WriteLine(input);

            ////exercise 1-7
            //string input = Console.ReadLine();
            //Console.WriteLine(input);
            //Console.WriteLine(input);
            //Console.WriteLine(input);

            ////exercise 1-8
            //string input = Console.ReadLine();
            //Console.WriteLine($"Hello {input}!");

            ////exercise 1-9
            //Console.WriteLine("Hello, how are you?");
            //Console.ReadLine();
            //Console.WriteLine("That's interesting, tell me more");
            //Console.ReadLine();
            //Console.WriteLine("Thank you for sharing!");

            Console.ReadLine();
        }

        private static void PrintUntilNumber(int number)
        {
            for (int i = 1; i <= number; i++)
            {
                Console.WriteLine(i);
            }
        }

        public static int Sum(int number1, int number2, int number3, int number4)
        {
            return number1 + number2 + number3 + number4;
        }

        public static void PrintStars(int number)
        {
            string starsRow = "";

            for(int i = 0; i < number; i++) 
            {
                starsRow +=  "*";
            }
            Console.WriteLine(starsRow);
        }

        public static void PrintSquare(int size)
        {
            for (int i = 0; i < size; i++)
            {
                PrintStars(size);
            }
        }

        public static void PrintRectangle(int width, int height)
        {
            for (int i = 0; i < height; i++)
            {
                PrintStars(width);
            }
        }

        public static void PrintTriangle(int size)
        {
            for (int i = 0; i < size; i++)
            {
                PrintStars(i + 1);
            }
        }

        private static void PrintSpaces(int number)
        {
            string spaces = "";
            for (int i = 0; i < number; i++)
            {
                spaces += " ";
            }
            Console.Write(spaces);
        }

        private static void ChristmasTree(int number)
        {
            for (int i = 1; i <= number; i++)
            {
                PrintSpaces(number - i);
                PrintStars(i * 2 - 1);
            }

            for (int i = 0; i < 2; i++)
            {
                PrintSpaces(number - 1);
                PrintStars(2);
            }
        }
    }
}