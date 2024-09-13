using System;
using System.Collections.Generic;
namespace HashSet
{
    class Program
    {
        static void Main(string[] args)
        {
            var customers = new List<Customer> {
             new Customer { Name ="Abanoub M" ,Telephone = "+20 122 4764 222"},
             new Customer { Name ="MAkar A" ,  Telephone = "+20 122 4764 478"},
             new Customer { Name ="Mariam S" , Telephone = "+20 122 4764 447"},
             new Customer { Name ="Abanoub M" ,Telephone = "+20 122 4764 544"},

            };
            Console.Clear();
            customers.Add(new Customer { Name = "Abanoub M", Telephone = "+20 122 4764 222" });
            Console.WriteLine("print List of Class ");
            foreach (var custom in customers)
            {
                Console.WriteLine(custom);
            }
            Console.WriteLine("print hasset of  List of Class ");

            var CustHashSet = new HashSet<Customer>(customers);
            CustHashSet.Add(new Customer { Name = "Abanoub M", Telephone = "+20 122 4764 222" });
            CustHashSet.Add(new Customer { Name = "ssss M", Telephone = "+20 122 4764 147" });
            //add 
            foreach (var custom in CustHashSet)
            {
                Console.WriteLine(custom);
            }
        }


        class Customer
        {
            public string Name { get; set; }
            public string Telephone { get; set; }


            public override int GetHashCode()
            {
                var hash = 17;
                hash = (hash * 397) + Telephone.GetHashCode();
                return hash;
            }

            public override bool Equals(object? obj)
            {
                var customer = obj as Customer;
                if (customer == null) return false;
                if (!(customer is Customer)) return false;
                return this.Name.Equals(customer.Name);
            }

        public override string ToString()
            {
                return $"{Name}  ({Telephone})";
            }
        }
    }
}
