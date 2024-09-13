using System;

namespace events
{
     class Program
    {
        static void Main(string[] args)
        {
            var stock = new Stock("Amazon");
            stock.Price = 150;
            Console.WriteLine($"stock before changing :  $ {stock.Price}");
            stock.changeStockPriceBy(0.05m);
            Console.WriteLine($"stock after changing : ${stock.Price}");
            Console.ReadKey();
        }
    }

    public class Stock
    {
        //fields
        private string name;
        private decimal price;


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
            this.price += Math.Round(this.price*percent , 2  );
        
        }
        
        
    }
}
