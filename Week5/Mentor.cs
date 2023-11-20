using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5
{
    public class Mentor : Person
    {
        public string Specialization { get; set; }

        public void CheckHomework()
        {
            Console.WriteLine($"{Name} is checking homework.");
        }
    }
}
