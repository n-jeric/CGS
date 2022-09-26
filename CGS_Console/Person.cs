using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGS_Console
{
    abstract class Person
    {
        string firstName;
        string lastName;

        public Person(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public void Update(string _fn, string _ln)
        {
            this.firstName = _fn;
            this.lastName = _ln;
        }

        public virtual string toString()
        {
            return $"{this.firstName} {this.lastName}";
        }
    }
}
