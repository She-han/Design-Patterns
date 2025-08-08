using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Factory_Method_Pattern
{
    internal class PersonFactory
    {
        private int count = 0;

        public Person CreatePerson(string name) {

            Person person = new Person();
            person.id = count;
            person.name = name;
            count++;
            return person;
        }
    }
}
