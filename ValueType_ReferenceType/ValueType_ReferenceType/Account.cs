using System;

namespace ValueType_ReferenceType
{
    class Account
    {
        private int _Number;

        // property
        public int Number
        {
            get { return _Number; } // getter 
            set { _Number = value; } // setter
        }

        // constructor
        public Account(int accountNumber)
        {
            _Number = accountNumber;
        }

    }   
}
