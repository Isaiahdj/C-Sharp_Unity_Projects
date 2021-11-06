using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    public abstract class Person
    {
        //properties
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public abstract void SayName();

    }
}