namespace _5_Исключения;
public class Product
{
  public string Name { get; set; }
    
  private decimal price;
  public decimal Price 
  { 
    get => price;
    set
    {
      if (value < 0) throw new Exception("Цена не может быть отрицательной");
      price = value;
    }
  }
    
  private int stock;
  public int Stock
  {
    get => stock;
    set
    {
      if (value < 0) throw new Exception("Количество не может быть отрицательным");
      stock = value;
    }
  }
    
  public Product(string name, decimal price, int stock)
  {
    Name = name;
    Price = price;
    Stock = stock;
  }
}