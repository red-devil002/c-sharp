using System;

namespace defining_class_member
{
    class Person
    {
        // class memeber in private
        private string _givenName;
        private string _familyName;
        private int _dateOfBirth;

        // Property - working like accosser and mutator
        public string givenName
        {
            get { return _givenName; }
            set { _givenName = value; }
        }
        public string familyName
        {
            get { return _familyName; }
            set { _familyName = value; }
        }
        public string dateOfBirth
        {
            get { return _dateOfBirth.ToString(); }
            set { _dateOfBirth = Convert.ToInt32(value); }
        }
    }   
}
