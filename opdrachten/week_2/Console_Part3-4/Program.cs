using System;
using System.Xml.Linq;

namespace Console_Part3_4
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
                Console.WriteLine("1. 3-16");
                Console.WriteLine("2. 3-21");
                Console.WriteLine("3. 3-28");
                Console.WriteLine("4. 3-29");
                Console.WriteLine("5. 3-30");
                Console.WriteLine("6. 3-31");
                Console.WriteLine("7. 4-3");
                Console.WriteLine("8. 4-4");
                Console.WriteLine("9. 4-21");
                Console.WriteLine("10. 4-22");
                Console.WriteLine("11. 4-23");
                Console.WriteLine("12. 4-24");
                Console.WriteLine("13. 4-26");
                var choice = int.Parse(Console.ReadLine());
                Console.WriteLine("==========");

                switch (choice)
                {
                    case 0:
                        Console.WriteLine("exit");
                        Environment.Exit(0);
                        break;
                    case 1:
                        List<string> strings = new List<string>();

                        strings.Add("First");
                        strings.Add("Second");
                        strings.Add("Third");

                        strings.ForEach(Console.WriteLine);
                        Console.WriteLine("==========");
                        Console.WriteLine("Output:");

                        RemoveLast(strings);
                        RemoveLast(strings);

                        strings.ForEach(Console.WriteLine);
                        break;
                    case 2:
                        int[] array = { 5, 1, 3, 4, 2 };
                        PrintArrayInStars(array);
                        break;
                    case 3:
                        Console.WriteLine("Write a sentence: ");
                        string input = Console.ReadLine();
                        while (input != "")
                        {
                            var word_split = input.Split(' ');
                            Console.WriteLine(word_split.Last());
                            input = Console.ReadLine();
                        }
                        break;
                    case 4:
                        Console.WriteLine("enter a name: ");
                        Console.WriteLine("example: John,20");
                        Console.WriteLine("to exit, press 'enter'");

                        var list_name_and_age = new List<string>();
                        string name_and_age = Console.ReadLine();
                        var name_highest_age = "";
                        var highest_age = 0;

                        while (name_and_age != "")
                        {                          
                            list_name_and_age.Add(name_and_age);
                            name_and_age = Console.ReadLine();
                        }

                        foreach (var item in list_name_and_age)
                        {
                            var splitted = item.Split(',');
                            var name = splitted.First();
                            var age = int.Parse(splitted.Last());

                            if (age > highest_age)
                            {
                                name_highest_age = name;
                                highest_age = age;
                            }
                        }
                        if (name_highest_age == "")
                        {
                            name_highest_age = "Unkown";
                        }
                        Console.WriteLine($"{name_highest_age} heeft de oudste leeftijd van: {highest_age}");
                        break;
                    case 5:
                        break;
                    case 6:
                        break;
                    case 7:
                        break;
                    case 8:
                        break;
                    case 9:
                        break;
                    case 10:
                        break;
                    case 11:
                        break;
                    case 12:
                        break;
                    case 13:
                        break;
                }
            }
            Console.Read();
        }

        public static void RemoveLast(List<string> strings)
        {
            if (strings.Count > 0)
            {
                strings.RemoveAt(strings.Count - 1);
            }
        }
        public static void PrintArrayInStars(int[] array)
        {
            foreach (int i in array)
            {
                var star = "";
                for (int x = 0; x < i; x++)
                {
                    star += "*";
                }

                Console.WriteLine(star);
            }
        }
    }
}