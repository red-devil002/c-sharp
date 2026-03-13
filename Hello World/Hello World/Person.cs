using System;

namespace Hello_World
{
    class Person
    {
        public Person(string givenName, string familyName, int dateOfBirth)
        {
            _GivenName = givenName;
            _FamilyName = familyName;
            _DateOfBirth = Convert.ToInt32(dateOfBirth);
        }

        private string _GivenName;
        private string _FamilyName;
        private int _DateOfBirth;
        public string GivenName
        {
            get { return _GivenName; }
            set { _GivenName = value; }
        }

        public string FamilyName
        {
            get { return _FamilyName; }
            set { _FamilyName = value; }
        }

        public string DateOfBirth
        {
            get { return _DateOfBirth.ToString(); }
            set { _DateOfBirth = Convert.ToInt32(value); }
        }
    }
}