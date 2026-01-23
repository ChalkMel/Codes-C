namespace ConsoleApp1;

public class Task3_GuessGame
{
    private bool _retry;

    private string _name;

    private int _right;
    private int _guess;
    private int _tries;

    public void Third()
    {
        Console.WriteLine("Ваше имя:");
        _name = Console.ReadLine();
        Console.WriteLine($"Приветствую, {_name}");
        Console.WriteLine("Правила:\nВы должны угадать загаданное число от 1 до 100 за минимальное количество попыток");
        do
        {
            Random random = new Random();
            _right = random.Next(1, 101);
            Console.WriteLine("Введите от 1 до 100:");
            _guess = int.Parse(Console.ReadLine());
            _tries = 0;
            while (_right != _guess)
            {
                if (_right < _guess)
                {
                    Console.WriteLine("Меньше");
                    _guess = int.Parse(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine("Больше");
                    _guess = int.Parse(Console.ReadLine());
                }

                _tries++;
            }

            if (_right == _guess)
            {
                Console.WriteLine($"Угадали! Это было {_right}. У вас ушло {_tries} попыток\nХотите повторить? Y/N");
                string input = Console.ReadLine();
                if (input.Contains("Y"))
                {
                    _retry = true;
                    Console.WriteLine("Повторяем!");
                    Console.WriteLine();
                }
                else
                    _retry = false;
            }
        } while (_retry);
    }
}