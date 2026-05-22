namespace Работа_с_событиями;
class Program
{
  static void Main()
  {
    Counter counter = new Counter(5);
    
    counter.ThresholdReached += ThresholdReached;
        
    Console.WriteLine("Введите любое значение для увеличения счетчика или 'end' для выхода:");
        
    while (true)
    {
      string? input = Console.ReadLine();
            
      if (input?.ToLower() == "end")
      {
        Console.WriteLine("Заершаем...");
        break;
      }
            
      counter.Increment();
    }
  }

  private static void ThresholdReached()
  {
    Console.WriteLine("Порог достигнут!");
  }
}