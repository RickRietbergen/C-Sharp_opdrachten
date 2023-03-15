﻿using System;
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
                Console.WriteLine("1. 3-16 Remove Last Method");
                Console.WriteLine("2. 3-21 Array in Stars");
                Console.WriteLine("3. 3-28 Last Part Split");
                Console.WriteLine("4. 3-29 CSV Age");
                Console.WriteLine("5. 3-30 CSV Name");
                Console.WriteLine("6. 3-31 Maximum Name and Age");
                Console.WriteLine("7. 4-3 First Class");
                Console.WriteLine("8. 4-4 Classroom");
                Console.WriteLine("9. 4-21 Book Class");
                Console.WriteLine("10. 4-22 Reading Strings");
                Console.WriteLine("11. 4-23 Reading Integers");
                Console.WriteLine("12. 4-24 Reading File");
                Console.WriteLine("13. 4-26 Guestlist Txt");
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
                        Console.WriteLine($"de oudste leeftijd is: {highest_age}");
                        break;
                    case 5:
                        Console.WriteLine("enter a name,age: ");
                        Console.WriteLine("example: John,20");
                        Console.WriteLine("to exit, press 'enter'");

                        var list_name_and_age1 = new List<string>();
                        string name_and_age1 = Console.ReadLine();
                        var name_highest_age1 = "";
                        var highest_age1 = 0;

                        while (name_and_age1 != "")
                        {
                            list_name_and_age1.Add(name_and_age1);
                            name_and_age1 = Console.ReadLine();
                        }

                        foreach (var item in list_name_and_age1)
                        {
                            var splitted1 = item.Split(',');
                            var name1 = splitted1.First();
                            var age1 = int.Parse(splitted1.Last());

                            if (age1 > highest_age1)
                            {
                                name_highest_age1 = name1;
                                highest_age1 = age1;
                            }
                        }
                        if (name_highest_age1 == "")
                        {
                            name_highest_age1 = "Unkown";
                        }
                        Console.WriteLine($"Name of the oldest: {name_highest_age1}");
                        break;
                    case 6:
                        Console.WriteLine("enter a name,age: ");
                        Console.WriteLine("example: John,2005");
                        Console.WriteLine("to exit, press 'enter'");
                        
                        var input_list = new List<string>();
                        string word = Console.ReadLine();
                        var word_longest_name = "Unkown";
                        var word_highest_age = 0;
                        var current_year = 2023;
                        
                        while (word != "")
                        {
                            input_list.Add(word);
                            word = Console.ReadLine();
                        }

                        foreach (var item in input_list)
                        {
                            var splitted_word = item.Split(',');
                            var longest_name = splitted_word.First();
                            var splitted_highest_age = int.Parse(splitted_word.Last());

                            if (splitted_highest_age > word_highest_age)
                            {
                                word_highest_age = current_year - splitted_highest_age;
                                word_longest_name = longest_name;
                            }
                        }
                        Console.WriteLine($"Longest name: {word_longest_name}");
                        Console.WriteLine($"Highest age: {word_highest_age}");
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