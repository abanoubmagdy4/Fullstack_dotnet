using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SalaryApp
{
    public class Sales : Employees
    {
        protected decimal SalesVolum { get; set; }
        protected decimal Commission { get; set; }

        public Sales(int id, string? name, int workHours, decimal wagge , decimal SalesV , decimal CoMmis ) : base(id, name, workHours, wagge) {
            Console.WriteLine("Sales salary calculates\n===============================================");
            SalesVolum = SalesV;
            Commission = CoMmis;
    }

        public override decimal TotalSalary()
        {
            return base.TotalSalary() + CalculateBonus();
        }

        private decimal CalculateBonus() {

            return SalesVolum * Commission;
        }
        public override string ToString()
        {
            return base.ToString() +
             $"\ntotal salary SALES: ${this.TotalSalary()}"+
             $"\n===============================================";

        }

    }
}
