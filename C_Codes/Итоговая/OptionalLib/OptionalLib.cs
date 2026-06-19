namespace Итоговая.OptionalLib
{
  public class IncorrectOptionalAccessException : InvalidOperationException
  {
    public IncorrectOptionalAccessException() : base() { }
        
    public IncorrectOptionalAccessException(string message) : base(message) { }
        
    public IncorrectOptionalAccessException(string message, Exception innerException) 
      : base(message, innerException) { }
  }
}