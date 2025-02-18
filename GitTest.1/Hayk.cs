using System;

namespace GitTest._1
{
    internal class Hayk
    {
        public string Name { get; set; }
        public string Surname { get; set; }

        public Hayk(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }

        public void Print()
        {
            Console.WriteLine($"{Name} - {Surname}");
        }
    }
}
