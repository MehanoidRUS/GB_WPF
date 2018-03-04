using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework
{
    public interface IView
    {
        string NameField { get; set; }
        string SurenameField { get; set; }
        int SalaryField { get; set; }
    }
}
