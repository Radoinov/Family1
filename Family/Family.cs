using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Family
{
    internal class Family
    {
        private string familyName;
        public string FamilyName
        {
            get
            {
                return familyName;
            }
            set
            {
                familyName = value;
            }
        }

        private List<Person> members = new List<Person>();
        public List<Person> Members
        {
            get
            {
                return members;
            }
            set
            {
                members = value;
            }
        }

        public void PrintAll()
        {
            Console.WriteLine($"Family: {this.FamilyName}");
            foreach (Person item in this.Members)
            {
                item.Intruduce();
            }
        }

        public void PrintYoungest()
        {
            Person younger = new Person();
            int minage = int.MaxValue;

            foreach (Person item in this.Members)
            {
                if (item.Age < minage)
                {
                    minage = item.Age;
                    younger = item;
                }

            }
            Console.WriteLine("Nai mladiq chlen na semejstvoto e");
            younger.Intruduce();
        }
        public void PrintOlder()
        {
            Person younger = new Person();
            int minage = int.MinValue;

            foreach (Person item in this.Members)
            {
                if (item.Age > minage)
                {
                    minage = item.Age;
                    younger = item;
                }

            }
            Console.WriteLine("Nai stariq chlen na semejstvoto e");
            younger.Intruduce();

        }
        public int SumOfTheFamilies() 
        {
            int sum = 0;
            foreach (Person item in this.Members) 
            { 
                sum = sum + item.Age;
            }
            return sum;
        }
    }
}
