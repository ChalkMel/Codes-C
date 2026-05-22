namespace _5_Исключения;
public class Cart
{
  private List<Product> products = new List<Product>();
  private List<int> quantities = new List<int>();
  
  public void AddProduct(Product product, int quantity)
  {
    if (quantity > product.Stock)
      throw new InsufficientStockException();
        
    products.Add(product);
    quantities.Add(quantity);
  }
    
  public void Checkout()
  {
    if (products.Count == 0)
      throw new EmptyCartException();
        
    Console.WriteLine("Заказ оформлен!");
    for (int i = 0; i < products.Count; i++)
    {
      products[i].Stock -= quantities[i];
      Console.WriteLine($"{products[i].Name}: {quantities[i]} шт. на сумму {products[i].Price * quantities[i]} руб.");
    }
    products.Clear();
    quantities.Clear();
  }
}