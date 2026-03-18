using System;

namespace Arrays
{
    class Person
    {
        private string _Name;
        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        public Person(string name)
        {
            _Name = name;
        }
    }
}