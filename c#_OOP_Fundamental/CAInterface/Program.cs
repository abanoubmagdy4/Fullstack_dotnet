using System;
namespace InterFace
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle V1 = new Honda("honda", "Civil", 2021);
            Honda V2 = new Honda("honda", "Accord", 2021);
            Cashier c1 = new Cashier(new Cash());
            c1.Checkout(100.5m);
            Cashier c2 = new Cashier(new debit());
            c2.Checkout(200);
        }

    }

    /////////////////////////////
    class Cashier
    {
        private Ipayment _Ipayment;

        public Cashier(Ipayment ipayment)
        {
            _Ipayment = ipayment;
        }
        public void Checkout(decimal amount)
        {

            _Ipayment.Pay(amount);
        }

    }

    interface Ipayment
    {
        void Pay(decimal amount);

    }
    ////////////////////////////////////
    class Cash :Ipayment 
    {

        public void Pay(decimal amount)
        {
            Console.WriteLine("pay by cash");
        }

        
    }
    class Visa : Ipayment   
    {

        public void Pay(decimal amount)
        {
            Console.WriteLine("pay by Visa");
        }
    }

    class debit : Ipayment
    {

        public void Pay(decimal amount)
        {
            Console.WriteLine($"pay by debit {amount}");
        }
    }

}
