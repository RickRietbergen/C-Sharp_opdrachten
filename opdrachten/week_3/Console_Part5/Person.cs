using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Part5
{
    public class Person_pet
    {
        public string Name { get; set; }
        public Pet Pet { get; set; }

        public Person_pet(string name, Pet pet)
        {
            Name = name;
            Pet = pet;
        }

        public Person_pet(string name) : this(name, new Pet("Toothless", "dragon"))
        {
        }

        public Person_pet() : this("Lilo", new Pet("Stitch", "blue alien"))
        {
        }

        public override string ToString()
        {
            if (Pet != null)
                return $"{Name}, has a friend called {Pet.Name} ({Pet.Breed})";
            else
                return $"{Name}";
        }
    }

    public class Pet
    {
        public string Name { get; set; }
        public string Breed { get; set; }

        public Pet(string name, string breed)
        {
            Name = name;
            Breed = breed;
        }
    }
}
