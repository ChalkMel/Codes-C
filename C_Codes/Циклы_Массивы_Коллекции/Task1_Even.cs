namespace ConsoleApp1;

public class Task1_Even
{
    private int _num; 
    public void First()
    {
        Console.WriteLine("Введите число:");
        _num = int.Parse(Console.ReadLine());

        if (_num % 2 == 0)
            Console.WriteLine($"{_num} четное!");
        else
            Console.WriteLine($"{_num} нечетное!");
    }
}