using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Person
    {
        //field
        private string firstName;
        private string lastName;
        private int age;

        //property
        public string FirstName
        {
            get { return firstName; }
            set
            {
                if (value.Length < 3) throw new ArgumentException("First name cannot contain fewer than 3 symbols!");
                firstName = value;
            }
        }
        public string LastName
        {
            get { return lastName; }
            set
            {
                if (value.Length < 3) throw new ArgumentException("Last name cannot contain fewer than 3 symbols!");
                lastName = value;
            }
        }
        public int Age
        {
            get { return age; }
            set
            {
                if (value > 0) age = value;
                else Console.WriteLine("Please re-enter age! ");
            }
        }

        //auto property sử dụng khi không cần kiểm soát dữ liệu trong đó. 
        //contrucstor
        public Person()
        { }

        public Person(string firstName, string lastName, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
        }

        public override string ToString()
        {
            return $"First Name: {firstName}, Last Name: {lastName}, Age: {Age}";
        }

    }
}
