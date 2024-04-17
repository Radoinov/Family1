namespace Family
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Family myFamily = new Family();
            myFamily.FamilyName = "Radoinovi";
            Console.Write("kolko choveka e familiqta: ");
            int count = int.Parse(Console.ReadLine());
            int total = 0;

            for (int i = 0; i < count; i++)
            {
                Console.Write($"vavedi {i + 1} chovek: ");
                Person current = new Person();
                Console.Write($"vavedi ime na {i + 1} chovek: ");
                current.Name = Console.ReadLine();
                Console.Write($"vavedi godini na {i + 1} chovek: ");
                current.Age = int.Parse(Console.ReadLine());
                myFamily.Members.Add(current);
            }

            //bubble sort
            for (int i = 0; i < count; i++)
            {
                for (int j = 0; j < count - 1; j++)
                {
                    if (myFamily.Members[j].Age > myFamily.Members[j + 1].Age)
                    {
                        Person temp = myFamily.Members[j];
                        myFamily.Members[j] = myFamily.Members[j + 1];
                        myFamily.Members[j + 1] = temp;
                    }
                }
            }
            Console.WriteLine();

            //A)
            Person oldest = myFamily.Members[count - 1];
            ////Person youngest = myFamily.Members[0];
            ////Console.Write("nai star e: ");
            //oldest.PrintOldestAndYoungest();
            //Console.Write("nai mlad e: ");
            //youngest.PrintOldestAndYoungest();


            ////B)
            //foreach (Person member in myFamily.Members)
            //{
            //    total += member.Age;
            //}

            //Console.WriteLine();

            //Pechatane
            myFamily.PrintAll();
            //Console.WriteLine();
            //Console.WriteLine($"Sumata na godinite e: {total}");
            myFamily.PrintYoungest();
            myFamily.PrintOlder();
            int sum = myFamily.SumOfTheFamilies();
            Console.WriteLine($"sumata na vsi4ki godini e {sum}");
        }
    }
}
