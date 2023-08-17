
using System.Reflection.Metadata.Ecma335;

namespace Exercicio025.Entities
{
    internal class Person
    {
        public String Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}
