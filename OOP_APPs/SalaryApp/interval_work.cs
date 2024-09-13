using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryApp
{
    internal interface interval_work
    {
        int start_date { get; set; }
        int end_date { get; set; }
        int interval();
    }
}
