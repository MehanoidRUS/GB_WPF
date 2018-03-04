using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace homework
{
    /// <summary>
    /// Логика взаимодействия для winAddDepart.xaml
    /// </summary>
    public partial class WinAddDepart : Window,IView
    {
        public WinAddDepart(Model model)
        {
            InitializeComponent();
            btnOk.Click += (s, e) => { model.AddDepartments(new Departments(NameField)); this.Close(); };
            btnCancel.Click += (s, e) => { this.Close(); };
        }

        public string NameField
        {
            get => txtName.Text;
            set => txtName.Text=value;
        }
        public string SurenameField { get; set; }
        public int SalaryField { get; set; }
    }
}
