namespace _5_Исключения;
class Program
{
  static void Main()
  {
    Product phone = new Product("Телефон", 20000, 3);
    Product laptop = new Product("Ноутбук", 50000, 2);
    
    try
    {
      Cart cart = new Cart();
      cart.AddProduct(phone, 2);
      cart.AddProduct(laptop, 1);
      cart.Checkout();
    }
    catch (Exception ex)
    {
      Console.WriteLine($"Ошибка: {ex.GetType().Name}");
    }
    
    try
    {
      Cart cart2 = new Cart();
      cart2.AddProduct(phone, 10);
      cart2.Checkout();
    }
    catch (InsufficientStockException)
    {
      Console.WriteLine("Ошибка: недостаточно товара на складе");
    }
    
    try
    {
      Cart cart3 = new Cart();
      cart3.Checkout();
    }
    catch (EmptyCartException)
    {
      Console.WriteLine("Ошибка: корзина пуста");
    }
  }
}