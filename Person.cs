using System;
namespace Homework
{
    public class Person
    {
        private string name;

        public Person() : this("")
        { }

        public Person(String name)
        {
            this.name = name;
        }

        public Person(Person other) : this(other.name)
        { }

        public String GetName()
        {
            return name;
        }

        public void SetName(String name)
        {
            this.name = name;
        }

        public override string ToString()
        {
            return $"Person[name={name}]";
        }

        public bool Equals(Person other)
        {
            return other.name.Equals(name);
        }
    }
}
