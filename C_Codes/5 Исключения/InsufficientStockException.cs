namespace _5_Исключения;

public class InsufficientStockException : Exception 
{
  public InsufficientStockException() { }
  public InsufficientStockException(string message) : base(message) { }
}