using System;
using System.Collections.Generic;
using System.Text;

namespace casting.Models
{
    abstract class Person
    {
        private static int _id;
        private string _name;
        private string _surname;
        private int _age;
        private int id;
   public int ID
        {
            get { return id; }
        }
        public string Name { get=>_name; set=>_name=value; }
        public string Surname { get=>_surname; set=>_surname=value; }
        public int Age { get=>_age; set=>_age=value; }
        public Person(string Name, string Surname, int Age)
        {
            id = ++_id;
            this.Name = Name;
            this.Surname = Surname;
            this.Age = Age;
        }

        public abstract string ShowInfo();
        


    }
}
