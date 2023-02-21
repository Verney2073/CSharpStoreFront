public class Basket
{
    List<ItemType> ItemsInBasket;

    public void AddItem(ItemType OurItem)
    {
        foreach (ItemType Item in ItemsInBasket)
        {
            if (Item.Name == OurItem.Name)
            {
                Item.Quantity += OurItem.Quantity;
                return;
            }
        }
        ItemsInBasket.Add(OurItem); 
    }
}