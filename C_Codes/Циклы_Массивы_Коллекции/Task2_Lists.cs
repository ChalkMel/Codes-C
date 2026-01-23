
namespace ConsoleApp1;

public class Task2_Lists
{
    List<int> list = new List<int>();
    public void Second()
    {
        for (int i = 1; i <= 10; i++)
            list.Add(i);
        PrintList();
        Console.WriteLine("Домножаем на 2");
        for (int i = 0; i < 10; i++)
        {
            list[i] *= 2;
        }

        PrintList();
    }
    private void PrintList()
    {
        Console.WriteLine($"Ваш список:");
        foreach (var item in list)
        {
            Console.Write(item + " ");
        }

        Console.WriteLine();
    }
}