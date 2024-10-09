namespace BlazingPizza;

public class Topping
{
    private static int IdSeqTest = 0; // marek test

    public int Id { get; set; }

    public string Name { get; set; } = string.Empty;

    public decimal Price { get; set; }

    public Topping() // marek test
    {
        Id = ++IdSeqTest;
    }

    public string GetFormattedPrice() => Price.ToString("0.00");

}