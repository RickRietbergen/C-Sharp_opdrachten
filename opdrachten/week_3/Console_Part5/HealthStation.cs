using System;

namespace Console_Part5
{
    public class HealthStation
    {
        public int weighings { get; private set; } = 0;

        public int Weigh(Person person)
        {
            weighings++;

            return person.weight;
        }

        public void Feed(Person person)
        {
            person.weight++;
        }
    }

    public class Person
    {
        public string name { get; }
        public int age { get; }
        public int height { get; }
        public int weight { get; set; }

        public Person(string name, int age, int height, int weight)
        {
            this.name = name;
            this.age = age;
            this.height = height;
            this.weight = weight;
        }
    }
}