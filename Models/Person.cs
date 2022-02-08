using System;

namespace SimpSimulator.Models
{
    public abstract class Person
    {
        public Person(string name, DateTime birthDate, string gender) {
            this.name = name;
            this.birthDate = birthDate;
            this.gender = gender;
        }
        public virtual string name { get; }

        public DateTime birthDate { get; }

        public virtual string gender { get; }
    }
}
