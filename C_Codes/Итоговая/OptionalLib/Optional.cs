namespace Итоговая.OptionalLib
{
  public class Optional<T> : IOptional<T> where T : struct
  {
    private T? _value;
        
    public Optional()
    {
      _value = null;
    }
        
    public Optional(T value)
    {
      _value = value;
    }
        
    public T Value
    {
      get
      {
        if (!_value.HasValue)
          throw new IncorrectOptionalAccessException("Optional object is empty");
        return _value.Value;
      }
      set
      {
        _value = value;
      }
    }
        
    public void SetValue(T? value)
    {
      _value = value;
    }
        
    public T GetValueOrDefault()
    {
      return _value ?? default(T);
    }
        
    public bool Empty
    {
      get { return !_value.HasValue; }
    }
        
    public override string ToString()
    {
      return _value.HasValue ? _value.Value.ToString() : "empty";
    }
  }
}