using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryApp
{
    public class Maintenance : Employees
    {
        public const decimal hardship = 100m;

        public Maintenance(int id, string? name, int workHours, decimal wagge) : base(id, name, workHours, wagge)
        {
            Console.WriteLine("Maintenance salary calculates\n===============================================");

        }

        public override decimal TotalSalary()
        {
            return base.TotalSalary() + hardship ;

        }

        public override string ToString()
        {
            return base.ToString() +
             $"\ntotal salary after hardship: ${this.TotalSalary():N0}" +
             $"\n===============================================";

        }

    }
}
