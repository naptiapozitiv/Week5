using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5
{

    public class Person
    {
        public string Name { get; set; }
        public string Email { get; set; }

        public Person()
        {
            // Конструктор без аргументов
        }

        public Person(string name, string email)
        {
            Name = name;
            Email = email;
        }

        public void SayHello()
        {
            Console.WriteLine($"Hello, my name is {Name}.");
        }

        public void CheckIn()
        {
            Console.WriteLine($"{Name} has checked in.");
        }
    }
}
