using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SalaryApp
{
    public class Employees
    {

        public const decimal numberOfhoursrequirse = 176;
        public const decimal overTimeRate = 0.5m;
       
        protected int Id { get; set; }
        protected string? Name { get; set; }
        protected int hourOfwork { get; set; }
        protected decimal wage { get; set; }

        public Employees(int id, string? name, int workHours, decimal wagge) { 
            Id = id;
            Name = name;
            hourOfwork = workHours;
            wage = wagge;
        }
     
        public decimal SalaryByHours()
        {
            if (hourOfwork >= numberOfhoursrequirse)
            {
                return numberOfhoursrequirse * wage;

            }
            else
            {
                Console.WriteLine("the number of hours less than number of work require");
                 return numberOfhoursrequirse * wage;
         
            }

        }
        public decimal additonalSalaryByHours()
        {
            decimal salaryadditionalhours;
            decimal additionalhours;

            if (hourOfwork > numberOfhoursrequirse)
            {

                additionalhours = hourOfwork - numberOfhoursrequirse ;
                salaryadditionalhours = additionalhours * wage;
                return salaryadditionalhours;

            }
            else
            {
                Console.WriteLine("the number of hours less than or equal number of work require");
                return 0;
            }

        }
        public virtual decimal TotalSalary()
        {
            
            return SalaryByHours() + additonalSalaryByHours();

        }
        public override string ToString()
        {
            return $"\nId: {Id}" +
                $"\nName: {Name}" +
                $"\nHours of work: {hourOfwork}"+
                $"\nwage: {wage} "+
                $"\nsalary bt hours : ${SalaryByHours()}"+
                $"\nadditional time salary ${additonalSalaryByHours()}"+
                $"\ntotal salary after additional hours ${SalaryByHours()+additonalSalaryByHours()}";

        }
    }
}
