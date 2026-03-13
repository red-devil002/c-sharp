using System;

namespace ConsoleApp_Input_output
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter your age: ");
            string age = Console.ReadLine();
            // Console.Write("I believe you are ");
            // Console.Write(age);
            // Console.WriteLine(" years old.");

            Console.WriteLine("I believe you are {0} years old.", age);
        }
    }
}