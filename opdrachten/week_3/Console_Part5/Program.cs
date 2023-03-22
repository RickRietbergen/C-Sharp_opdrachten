using System;
using System.Xml.Linq;

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
                        HealthStation childrensHospital = new HealthStation();

                        Person ethan = new Person("Ethan", 1, 110, 7);
                        Person peter = new Person("Peter", 33, 176, 85);

                        Console.WriteLine(ethan.name + " weight: " + childrensHospital.Weigh(ethan) + " kilos");
                        Console.WriteLine(peter.name + " weight: " + childrensHospital.Weigh(peter) + " kilos");

                        childrensHospital.Feed(ethan);
                        childrensHospital.Feed(peter);

                        Console.WriteLine(ethan.name + " weight: " + childrensHospital.Weigh(ethan) + " kilos");
                        Console.WriteLine(peter.name + " weight: " + childrensHospital.Weigh(peter) + " kilos");

                        childrensHospital.Weigh(ethan);
                        childrensHospital.Weigh(ethan);
                        childrensHospital.Weigh(ethan);
                        childrensHospital.Weigh(ethan);

                        Console.WriteLine("weighings performed: " + childrensHospital.weighings);
                        break;
                    case 2:
                        PaymentCard petesCard = new PaymentCard(10);

                        Console.WriteLine("money " + petesCard.balance);
                        bool wasSuccessful = petesCard.TakeMoney(8);
                        Console.WriteLine("successfully withdrew: " + wasSuccessful);
                        Console.WriteLine("money " + petesCard.balance);

                        wasSuccessful = petesCard.TakeMoney(4);
                        Console.WriteLine("successfully withdrew: " + wasSuccessful);
                        Console.WriteLine("money " + petesCard.balance);
                        break;
                    case 3:
                        Pet lucy = new Pet("Lucy", "golden retriever");
                        Person_pet leo = new Person_pet("Leo", lucy);
                        Console.WriteLine(leo);

                        Person_pet mike = new Person_pet("Mike");
                        Console.WriteLine(mike);

                        Person_pet lilo = new Person_pet();
                        Console.WriteLine(lilo);
                        break;
                    case 4:
                        Song jackSparrow = new Song("The Lonely Island", "Jack Sparrow", 196);
                        Song anotherSparrow = new Song("The Lonely Island", "Jack Sparrow", 196);

                        if (jackSparrow.Equals(anotherSparrow))
                        {
                            Console.WriteLine("Songs are equal.");
                        }

                        if (jackSparrow.Equals("Another object"))
                        {
                            Console.WriteLine("Strange things are afoot.");
                        }
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