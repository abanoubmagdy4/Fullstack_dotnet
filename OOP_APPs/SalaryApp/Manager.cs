using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SalaryApp
{
    public class Manager : Employees 
    {
        
        public const decimal allowance = 0.05m;

        public Manager(int id, string? name, int workHours, decimal wagge) : base(id, name, workHours, wagge)
        {
             Console.WriteLine("Manager salary calculates\n===============================================");
                
        }

        public override decimal TotalSalary()
        {
            return base.TotalSalary() + (allowance * base.TotalSalary());

        }

        public override string ToString()
        {
            return base.ToString() +      
             $"\ntotal salary after allowance: ${this.TotalSalary():N0}"+
             $"\n===============================================";

        }

    }
}
  