using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Family
{
    internal class Person
    {
        private string name;
        private int age;

        public string Name { get { return name; } set { this.name = value; } }



        public int Age
        {
            get { return age; }
            set
            {
                if (value < 0 || value > 117)
                {
                    Console.WriteLine("nevalidni godini");
                    this.age = 0;
                }
                else
                {
                    this.age = value;
                }

            }
        }

        public void Intruduce()
        {
            Console.WriteLine($"Az sum {this.name} i sum na {this.age}.");
        }
        public void PrintOldestAndYoungest()
        {
            Console.WriteLine($"ime: {Name}, godini: {Age}");
        }
    }
}
