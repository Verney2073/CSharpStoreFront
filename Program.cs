// See https://aka.ms/new-console-template for more information

ItemType Broccoli = new ItemType("broccoli", 10);
ItemType Carrot = new ItemType("carrot", 20);
ItemType PakChoy = new ItemType("Pak Choy", 30);

ItemType[] ourInventory = { Broccoli, Carrot, PakChoy };

Inventory MainShop = new Inventory(ourInventory);

MainShop.StockReport();


