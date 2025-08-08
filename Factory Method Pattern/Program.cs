using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method_Pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PersonFactory pfac = new PersonFactory();
            Person p1 = pfac.CreatePerson("shehan");
            Person p2 = pfac.CreatePerson("saman");

            Console.WriteLine("person1 id = " + p1.id + ", name = " + p1.name);
            Console.WriteLine("person2 id = " + p2.id + ", name = " + p2.name);
        }
    }
}
