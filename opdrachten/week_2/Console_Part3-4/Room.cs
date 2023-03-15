using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace exercise_96
{
    internal class Room
    {
        private string code;
        private int seats;

        public Room(string classCode, int numberOfSeats)
        {
            this.code = classCode;
            this.seats = numberOfSeats;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Code of room: {code}");
            Console.WriteLine($"Amount of seats: {seats}");
        }
    }
}
