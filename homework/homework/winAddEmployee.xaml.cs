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
    /// Логика взаимодействия для winAddEmployee.xaml
    /// </summary>
    public partial class winAddEmployee : Window,IView
    {
        public winAddEmployee()
        {
            InitializeComponent();
        }

        public string NameField { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string SurenameField { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int SalaryField { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
