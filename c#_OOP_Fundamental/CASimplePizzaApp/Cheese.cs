namespace CASimplePizzaApp
{
    partial class Program
    {
        class Cheese : Pizza
        {

            public override string Title => $" {base.Title}{nameof(Cheese)}";
            public override decimal Price => base.Price + 3m;

        }


    }
}
