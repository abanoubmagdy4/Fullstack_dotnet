using System;
using System.Collections.Generic;
using System.Security.AccessControl;
using System.Threading.Tasks.Dataflow;
namespace CAHashSet
{
    class Program
    {
        static void Main(string[] args)
        {
            var customers = new List<Customer>
            {
              new Customer {Name = "Issam A" , Telephone = "+20 122 4764 601"},
              new Customer {Name = "Abanoub M", Telephone = "+20 127 3372 124"},
              new Customer {Name = "Keroles S", Telephone ="+20 120 0105 525" },
              new Customer {Name = "Keroles S", Telephone ="+20 120 0105 525" },
            };

            var custHashSet1 = new HashSet<Customer>(customers);
            foreach (var item in custHashSet1)
            {
                Console.WriteLine(item);
            }

        }//end of main


    }//end of class program

    class Customer
    {

        public string Name { get; set; }
        public string Telephone { get; set; }

        public override int GetHashCode()
        {
            var hash = 13;
            hash = (hash * 7) + Telephone.GetHashCode();

            return hash;
        }

        public override bool Equals(object? obj)
        {
            if (obj == null || obj != (obj as Customer))
            {
                return false;
            }

            return  this.Telephone.Equals(obj);

        }

        public override string ToString()
        {
            return $"{Name} ({Telephone})";

        }

    }

}//end of namespace
