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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace homework
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Presenter p;
        public MainWindow()
        {
            InitializeComponent();
            p = new Presenter();
            lbDepartments.ItemsSource = p.CurrentModel.GetDepartments;

            btnAddDepart.Click += delegate { new WinAddDepart(p.CurrentModel).ShowDialog(); };
            lbDepartments.SelectionChanged += (s, e) => { lbEmployees.ItemsSource = p.CurrentModel.GetDepartments[lbDepartments.SelectedIndex].Employees; };
        }
    }
}
