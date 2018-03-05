using System;
using System.Collections;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace homework
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window,IDataView
    {
        PDataView p;
        PDataChange p1;  
        public MainWindow()
        {
            InitializeComponent();
            p = new PDataView(this);
            p1 = new PDataChange();          
             
            Departments tmp = new Departments("dfg");
            DataDep.departments.Add(tmp);
            

           btnAddDepart.Click += delegate {p1.Add();};
          
        }

        public IEnumerable DepartItemSource
        {
            get => lbDepartments.ItemsSource;
            set => lbDepartments.ItemsSource=value;
        }
    }
}
