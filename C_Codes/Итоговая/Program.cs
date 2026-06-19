using System;
using Итоговая.OptionalLib;

namespace OptionalService
{
    class Program
    {
        static void OnOptionalFilledHandler(int value)
        {
            Console.WriteLine($"ExtendedOptional заполнен значением: {value}");
        }
        
        static void OnOptionalEmptiedHandler()
        {
            Console.WriteLine("ExtendedOptional стал пустым");
        }
        
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Введите количество создаваемых Optional<int> объектов: ");
                string input = Console.ReadLine();
                
                if (!int.TryParse(input, out int count) || count < 0)
                {
                    Console.WriteLine("Некорректное количество объектов");
                    return;
                }
                
                Optional<int>[] optionalArray = new Optional<int>[count];
                
                for (int i = 0; i < count; i++)
                {
                    Console.Write($"Введите значение для Optional #{i + 1}: ");
                    string valueInput = Console.ReadLine();
                    
                    if (int.TryParse(valueInput, out int intValue))
                    {
                        optionalArray[i] = new Optional<int>(intValue);
                    }
                    else
                    {
                        optionalArray[i] = new Optional<int>();
                        Console.WriteLine($"Optional #{i + 1} создан пустым (некорректное значение)");
                    }
                }
                
                ExtendedOptional<int> extendedOptional = new ExtendedOptional<int>();
                extendedOptional.OnOptionalFilled += OnOptionalFilledHandler;
                extendedOptional.OnOptionalEmptied += OnOptionalEmptiedHandler;
                
                Console.WriteLine("\nВсе Optional-объекты:");
                for (int i = 0; i < optionalArray.Length; i++)
                {
                    Console.WriteLine($"Optional #{i + 1}: {optionalArray[i]}");
                }
                
                Console.WriteLine($"ExtendedOptional: {extendedOptional}");
    
                Console.WriteLine("\n--- Проверка работы событий ExtendedOptional ---");
                Console.WriteLine("Установка значения 42:");
                extendedOptional.SetValue(42);
                Console.WriteLine($"ExtendedOptional после установки: {extendedOptional}");
                
                Console.WriteLine("Установка значения null:");
                extendedOptional.SetValue(null);
                Console.WriteLine($"ExtendedOptional после установки null: {extendedOptional}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Произошла ошибка: {ex.Message}");
            }
        }
    }
}