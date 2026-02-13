namespace Перегрузка_Обобщение;

internal class Program
{
  public static void Main(string[] args)
  {
    Stack<string> stack = new Stack<string>();

    stack.Push("1");
    stack.Push("z");
    stack.Push("d");
    
    Cycle();
    Cycle();
    Console.WriteLine($"Стек пуст? {stack.IsEmpty()}");
    Cycle();
    Console.WriteLine($"Стек пуст? {stack.IsEmpty()}");
    void TryToPeek()
    {
      if (!stack.IsEmpty())
      {
        Console.WriteLine($"Верхний элемент: {stack.Peek()}");
      }
      else
      {
        Console.WriteLine("Стек пуст");
      }
    }
    void TryToPop()
    {
      if (!stack.IsEmpty())
      {
        Console.WriteLine($"Извлекли: {stack.Pop()}");
      }
      else
      {
        Console.WriteLine("Стек пуст");
      }
    }

    void Cycle()
    {
      if (!stack.IsEmpty())
      {
        TryToPop();
        TryToPeek();
      }
    }
  }
}