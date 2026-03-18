using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // Here it stores the value of the Array.
            int[] Numbers = new int[5];

            for (int i = 0; i < 5; i++)
            {
                Numbers[i] = i;
            }

            foreach (int num in Numbers)
            {
                Console.WriteLine(num);
            }

            // Here it stores the reference to the Array, not the value which we give.
            Person[] people = new Person[5];

            // Create the object to store the reference of the Array.
            for (int i = 0; i < 5; i++)
            {
                people[i] = new Person("unknown");
            }

            people[0].Name = "Alice";
            people[1].Name = "Bob";
            people[2].Name = "Charlie";
            people[3].Name = "David";
            people[4].Name = "Eve";

            foreach (Person per in people)
            {
                Console.WriteLine(per.Name);
            }
        }
    }
}