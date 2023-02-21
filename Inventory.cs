public class Inventory {
    public ItemType[] Stocks {get;set;}

    public Inventory( ItemType[] stocks) {
        Stocks = stocks;
    }

    public void StockReport() {
        int sumOfQuantities = 0;

        Console.WriteLine("Stock Report!!");
        foreach(ItemType Item in Stocks) {
            Console.WriteLine($"We have {Item.Quantity} of {Item.Name}");
            sumOfQuantities += Item.Quantity;
        }
        Console.WriteLine($"We have {sumOfQuantities} items in total");
    }
}