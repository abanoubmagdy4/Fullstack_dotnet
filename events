using System;

namespace events
{
    // SUBSCRIBER
    class Program
    {
        static void Main(string[] args)
        {
            var stock = new Stock("Amazon");
            stock.Price = 150;
            stock.changedPrice += Stock_changedPrice;
            stock.changeStockPriceBy(0.05m);
            stock.changeStockPriceBy(-0.05m);
            stock.changeStockPriceBy(0.0m);
            Console.ReadKey();

        }

        // method to perform result of event 
        private static void Stock_changedPrice(Stock stock, decimal oldPrice)
        {
            if (stock.Price > oldPrice)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"{stock.Name} : {stock.Price} => up ");
            }
            else if (stock.Price < oldPrice)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"{stock.Name} : {stock.Price} => Down ");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine($"{stock.Name} : {stock.Price} ");
            }
        }


        public delegate void stockChangeHandler(Stock stockname, decimal oldPrice);

        //Publisher
        public class Stock
        {

            //fields
            private string name;
            private decimal price;

            //event decleration
            public event stockChangeHandler changedPrice;

            //setter and getter
            public string Name => this.name;
            public decimal Price { get => this.price; set => this.price = value; }
            //constractor علشان ابعتله اسم ال stock
            public Stock(string stockName)
            {
                this.name = stockName;
            }

            //method to change price of stock to percent
            public void changeStockPriceBy(decimal percent)
            {
                decimal oldestPrice = this.Price;
                this.price += Math.Round(this.price * percent, 2);
                if (changedPrice != null)
                { // make sure there is subscriber

                    changedPrice(this, oldestPrice);

                }
            }
        }
    }
}

