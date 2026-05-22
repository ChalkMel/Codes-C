namespace _5_Исключения;

public class EmptyCartException : Exception 
{
  public EmptyCartException() { }
  public EmptyCartException(string message) : base(message) { }
}