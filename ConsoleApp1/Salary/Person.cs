using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Salary
{
    internal class Person
    {
        private string firstName;
        private string lastName;
        private int age;
        private decimal salary;

        public string FirstName
        {
            get { return firstName; }
            set
            {
                if (value.Length < 3) { 
                    throw new ArgumentException("First name cannot contain fewer than 3 symbols!"); 
                }
                firstName = value;
            }
        }
        public string LastName
        {
            get { return lastName; }
            set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("Last name cannot contain fewer than 3 symbols!");
                }
                lastName = value;
            }
        }
        public int Age
        {
            get { return age; }
            set
            {
                if (value > 0) age = value;
                else Console.WriteLine("Please re-enter age!");
            }
        }
        public decimal Salary
        {
            get {return salary;}
            set
            {
                    if (value < 460)
                    {
                        throw new ArgumentException("Salary cannot be less than 460");
                    }
                    salary = value;
            }
        }
        //auto property sử dụng khi không cần kiểm soát dữ liệu trong đó. 
        //contrucstor
        public Person()
        { }

        public Person(string firstName, string lastName, int age, decimal salary)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.salary = salary;
        }

        public override string ToString()
        {
            return $"First Name: {firstName}, Last Name: {lastName}, Age: {Age}, Salary: {salary}";
        }
        public void IncreaseSalary(decimal percentage)
        {
            if (age > 30)
            {
                salary += salary * percentage / 100;
            }
            else
            {
                salary += salary * percentage / 200;
            }
        }

    }
}
