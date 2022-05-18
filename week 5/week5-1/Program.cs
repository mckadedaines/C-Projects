VendingMachine v = new VendingMachine();
v.populate();
v.getList();

public class Item {

    private string name;
    private double price;
    private string location;
    private int quantity;

    public Item(string name, double price, string location, int quantity = 1){
        this.name = name;
        this.price = price;
        this.location = location;
        this.quantity = quantity;
    }

    public void showItem(){
        Console.WriteLine($"{name} - {price} - {location} - QTY:{quantity}");
        Console.WriteLine($"Total Value:{totalValue()}");
    }

    private double totalValue(){
        return quantity * price;
    }
}

public class VendingMachine {

    private List<Item> items = new List<Item>();

    public VendingMachine(){
        Console.WriteLine("I'm a vending machine");
    }

    public void populate(){
        items.Add(new Item("Doritos",  2.5, "A1"));
        items.Add(new Item("Reeses", .75, "A2"));
        items.Add(new Item("Crystal Light", 5.00, "A3"));
    }

    public void getList(){
        Console.WriteLine("Items in the vending machine: ");
        foreach(Item item in items){
            item.showItem();
        }
        // return items;
    }
}