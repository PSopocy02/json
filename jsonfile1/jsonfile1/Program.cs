
using System.Text.Json;

public class Order
{
    public string Customer { get; set; }
    public string Pizza { get; set; }

    public int Quantity { get; set; }

}

class Program
{
    static void Main()
    {
        string json = File.ReadAllText("PizzaOrder.json");

        List<Order> orders = JsonSerializer.Deserialize<List<Order>>(json);

        foreach (Order order in orders)
        {
            Console.WriteLine($"{order.Customer} ordered {order.Quantity} {order.Pizza}(s).");
        }
    }
        
}