using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5
{
    public class Student : Person
    {
        public int StudentId { get; set; }

        public void DoHomework()
        {
            Console.WriteLine($"{Name} is doing homework.");
        }
    }
}
