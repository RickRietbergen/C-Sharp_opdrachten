using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise_95
{
    internal class Dog
    {
        private string name;
        private string breed;
        private int age;

        //construstor
        public Dog(string name, string breed, int age)
        {
            this.name = name;
            this.breed = breed;
            this.age = age;
        }

        //getters
        public string GetName()
        {
            return name;
        }
        public string GetBreed()
        {
            return breed;
        }
        public int GetAge()
        {
            return age;
        }

        //setters
        public void SetName(string name)
        {
            this.name = name;
        }
        public void SetBreed(string breed)
        {
            this.breed = breed;
        }
        public void SetAge(int age)
        {
            this.age = age;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Breed: {breed}");
            Console.WriteLine($"Age: {age}");
        }
    }
}
