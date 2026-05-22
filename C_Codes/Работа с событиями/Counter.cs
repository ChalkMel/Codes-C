namespace Работа_с_событиями;

public class Counter
{
  private int _count;
  private int _threshold;
  
  public event Action ThresholdReached;
    
  public Counter(int threshold)
  {
    _threshold = threshold;
    _count = 0;
  }
    
  public void Increment()
  {
    _count++;
    Console.WriteLine($"Текущее значение: {_count}");
    
    if (_count >= _threshold)
    {
      OnThresholdReached();
    }
  }

  public void OnThresholdReached()
  {
    ThresholdReached?.Invoke();
  }
}