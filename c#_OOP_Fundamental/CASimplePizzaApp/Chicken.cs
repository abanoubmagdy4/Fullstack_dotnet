namespace CASimplePizzaApp
{
    partial class Program
    {
        class Chicken : Pizza
        {

            public override string Title => $" {base.Title}{nameof(Chicken)}";
            public override decimal Price => base.Price + 10m;

        }


    }
}
