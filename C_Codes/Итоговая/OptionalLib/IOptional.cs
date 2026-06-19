namespace Итоговая.OptionalLib
{
  public interface IOptional<T> where T : struct
  {
    T Value { get; set; }
    void SetValue(T? value);
    T GetValueOrDefault();
    bool Empty { get; }
  }
}