using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace Ex4StudentHashtable
{
    class Student
    {
        private string first, last;

        public Student(string fName, string lName) // constructor
        {
            first = fName;
            last = lName;
        }

        public override string ToString() // return Employee first and last names as string
        {
            return first + " " + last;
        }
    }
}
