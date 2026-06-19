namespace Итоговая.OptionalLib
{
  public class ExtendedOptional<T> : Optional<T> where T : struct
  {
    public event Action<T> OnOptionalFilled;
    public event Action OnOptionalEmptied;
        
    public ExtendedOptional() : base() { }
        
    public ExtendedOptional(T value) : base(value) 
    {
      OnOptionalFilled?.Invoke(value);
    }
        
    public new T Value
    {
      get { return base.Value; }
      set
      {
        bool wasEmpty = base.Empty;
        base.Value = value;
                
        if (wasEmpty && !base.Empty)
          OnOptionalFilled?.Invoke(value);
      }
    }
        
    public new void SetValue(T? value)
    {
      bool wasEmpty = base.Empty;
      base.SetValue(value);
            
      if (wasEmpty && !base.Empty && value.HasValue)
        OnOptionalFilled?.Invoke(value.Value);
      else if (!wasEmpty && base.Empty)
        OnOptionalEmptied?.Invoke();
    }
  }
}