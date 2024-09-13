using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace InterFace
{
    abstract class Vehicle
    { 
        protected string Brand { get; set; }
        protected string Model { get; set; }
        protected int Year { get; set; }
   
        public Vehicle(string brand , string model , int year) {
            Brand = brand;
            Model = model;
            Year = year;
        }
    }
}
