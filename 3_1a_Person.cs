using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpLab03
{
    internal class Person
    {
        private string firstName; // 3_1e
        public string FirstName
        { 
            get => firstName;
            set { firstName = value; }
        }
        private string lastName; // 3_1e
        public string LastName 
        { 
            get => lastName;
            set { lastName = value; }
        }
        private int age;
        public int Age // 3_1e
        {
            get => age;
            set { age = value; } 
        }

        public Person(string firstName, string lastName, int age)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
        }
        public virtual string View() //3_1c
        {
            return ($"Imie: {FirstName}\tNazwisko: {LastName}\tWiek: {Age}");
        }
    }
}
