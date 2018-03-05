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
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class WinAddDepart : Window,IDataChange
    {
        DataChange tmp;
        public WinAddDepart(DataChange data)
        {
            InitializeComponent();
            tmp = data;
        }

        public string NameField
        {
            get => txtName.Text;
            set => txtName.Text = value;
        }


        private void btnOk_Click(object sender, RoutedEventArgs e)
        {
            tmp.AddDepartments(new Departments(NameField));
            this.Close();
        }
    }
}
