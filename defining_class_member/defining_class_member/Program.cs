using System;

namespace defining_class_member
{
    class Program
    {
        static void Main(string[] args)
        {
            // Person Object
            Person person1 = new Person();

            person1.familyName = "Bloggs";
            person1.givenName = "Jane";
            person1.dateOfBirth = "01032013";
        }
    }
}