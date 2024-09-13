namespace CASimplePizzaApp
{
    partial class Program
    {
        class Pizza
        {
            public virtual string Title => $"{nameof(Pizza)}";
            public virtual decimal Price => 0m;
            
         

            private static Pizza Create(string type) {
                Pizza pizza;
                if (type.Equals(PizzaConstant.CheesePizza))
                {
                    pizza = new Cheese();
                }
                else if (type.Equals(PizzaConstant.VegetrianPizza))
                {
                    pizza = new Vegeterian();

                }
                else if (type.Equals(PizzaConstant.ChickenPizza))
                {

                    pizza = new Chicken();
                }
                else {

                    return null;
                }
                

             return pizza;
            }
            public static Pizza Oreder(string type) {
                Console.WriteLine($"Your order is {type}");
                if (type == PizzaConstant.CheesePizza || type == PizzaConstant.ChickenPizza || type == PizzaConstant.VegetrianPizza)
                {
                    Pizza pizza = Create(type);
                    Prepare();
                    Cock();
                    Cut();
                    return pizza;
                }
                else {
                    Console.WriteLine("Can not implement your order Because it is not in the menu");
                    Console.WriteLine("Please Enter cheese or vegitable or chicken");

                    return null;
                }
            }

            private static void Cock()
            {
                Console.Write("Cooking ...");
                Thread.Sleep(2000);
                Console.WriteLine("Completed");

            }

            private static void Prepare()
            {
                Console.Write("Preparing ...");
                Thread.Sleep(1000);
                Console.WriteLine("Completed");

            }

            private static void Cut()
            {
                Console.Write("Cuting ...");
                Thread.Sleep(700);
                Console.WriteLine("Completed");

            }

            public override string ToString()
            {
                return $"\n{Title}" +
                      $"\n\t Price : {Price.ToString("C")}";
            }
        }


    }
}
