namespace CASimplePizzaApp
{
    partial class Program
    {
        class Vegeterian : Pizza
        {

            public override string Title => $" {base.Title}{nameof(Vegeterian)}";
            public override decimal Price => base.Price + 5m;

        }


    }
}
