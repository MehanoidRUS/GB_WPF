using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework
{
    public class Employee
    {
        private string name;
        private string surname;
        private int salary;

        public string Name { get { return this.name; } set { this.name = value; } }
        public string Surname { get { return this.surname; } set { this.surname = value; } }
        public int Salary { get { return this.salary; } set { this.salary = value; } }

        public Employee(string name, string surname, int salary)
        {
            Name = name;
            Surname = surname;
            Salary = salary;
        }
    }
}
