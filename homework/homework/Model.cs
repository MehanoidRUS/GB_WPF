using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework
{
    public class Model
    {
        ObservableCollection<Departments> departments;
        public ObservableCollection<Departments> GetDepartments { get { return this.departments; } }
        public Model()
        {
            departments = new ObservableCollection<Departments>();
        }

        public void AddDepartments(Departments departments)
        {
            this.departments.Add(departments);
        }

    }
}
