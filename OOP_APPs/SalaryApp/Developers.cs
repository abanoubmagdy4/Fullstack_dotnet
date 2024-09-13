using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryApp
{
    public class Developers : Employees 
    {
        protected bool taskCompleted {  get; set; }
        protected const decimal commision = 0.03m;
        public Developers(int id, string? name, int workHours, decimal wagge, bool CompletedTask) : base(id, name, workHours, wagge)
        {
            Console.WriteLine("Developers salary calculates\n===============================================");
            taskCompleted = CompletedTask;

        }


        public override decimal TotalSalary()
        {
            return base.TotalSalary() + CalculateBonus();
        }
        private decimal CalculateBonus()
        {
            if (taskCompleted)
            {
                return base.TotalSalary() * commision;
            }
            else
            {

                return 0;
            }

        }

        public override string ToString()
        {
            return base.ToString() +
                $"\n Commission : $ {Math.Round(commision,2)}" +
                $"\nBonus: $ {Math.Round(CalculateBonus(),2)}" +
                $"\nNet salary : ${Math.Round(this.TotalSalary(),2)}";
        }
    }
}
