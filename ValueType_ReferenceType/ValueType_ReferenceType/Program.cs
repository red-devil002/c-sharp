using System;

namespace ValueType_ReferenceType
{
    class Program
    {
        static void Main(string[] args)
        {
            int accountNumber = 12345; // value type
            Account account = new Account(54321); // reference type

            Console.WriteLine("Value Type {0}: " + accountNumber); // Output: 12345
            Console.WriteLine("Reference Type {0}: " + account.Number); // Output: 54321
            Console.WriteLine();

            // copies
            int secondAccount = accountNumber;
            Account secoundAccountObj = account;

            secondAccount = 123456789;
            secoundAccountObj.Number = 987654321;


            Console.WriteLine("After: ");
            Console.WriteLine("Value Type now {0}: " + accountNumber); // Output: 12345
            Console.WriteLine("Reference Type now {0}: " + account.Number); // Output: 54321
            Console.WriteLine("Value Type {0}: " + secondAccount); // Output: 12345
            Console.WriteLine("Reference Type {0}: " + secoundAccountObj.Number); // Output: 987654321
        }
    }
}