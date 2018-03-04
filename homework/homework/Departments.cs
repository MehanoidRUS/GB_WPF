using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework
{
    public class Departments
    {
        private string name;
        private ObservableCollection<Employee> employees;

        public string Name { get { return this.name; } set { this.name = value; } }
        public ObservableCollection<Employee> Employees { get { return this.employees; } set { this.employees = value; } }

        public Departments(string name)
        {
            Name = name;
            employees = new ObservableCollection<Employee>();
        }

        /// <summary>
        /// Добавить сотрудника
        /// </summary>
        /// <param name="NewEmployee">Данные нового сотрудника</param>
        public void AddEmployee(Employee NewEmployee)
        {
            employees.Add(NewEmployee);
        }


        public void RemoveEmployee(Employee RemoveEmployee)
        {
            if (employees.IndexOf(RemoveEmployee)!=-1)
            {
                employees.Remove(RemoveEmployee);
            }
        }

    }
}
