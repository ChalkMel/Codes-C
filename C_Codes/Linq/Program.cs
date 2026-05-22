/*Создайте класс Student со свойствами:
Name
  Group
Age
  CSharpScore
SqlScore
  HasPetProject
Создайте коллекцию студентов не менее чем из 8 элементов, а также две отдельные коллекции: участники хакатона и кандидаты на стажировку.
  Выведите студентов старше 20 лет с баллом по C# больше 70.
  Сформируйте новую коллекцию, содержащую имя, группу и средний балл каждого студента.
  Отсортируйте студентов по среднему баллу по убыванию, а при равенстве — по имени.
  Найдите:
количество студентов
средний возраст
максимальный балл по C#
минимальный балл по SQL
Вывести:
трёх лучших студентов по среднему баллу
студентов с 3 по 5 место после сортировки
  Сгруппировать студентов по группам и для каждой группы вывести количество студентов.
  Для двух дополнительных коллекций определить:
объединение
  пересечение
разность*/

namespace Linq;
using System;
using System.Linq;
class Program
{
    static void Main()
    {
        // Создаём студентов
        var students = new List<Student>
        {
            new Student{Name="Зубенко Михаил Петрович", Group="2ЦХ", Age=67, CSharpScore=87, SqlScore=78, HasPetProject=true},
            new Student{Name="Иванушка Дурачок", Group="3ГД1", Age=22, CSharpScore=20, SqlScore=1, HasPetProject=false},
            new Student{Name="Добрый Коля", Group="4ГР", Age=23, CSharpScore=79, SqlScore=99, HasPetProject=false},
            new Student{Name="Дмитрий Нагиев", Group="3ГД1", Age=59, CSharpScore=66, SqlScore=66, HasPetProject=false},
            new Student{Name="Галина Сергеевна", Group="4ГР", Age=16, CSharpScore=100, SqlScore=100, HasPetProject=true},
            new Student{Name="Роза Барбоскина", Group="2ЦХ", Age=20, CSharpScore=36, SqlScore=40, HasPetProject=false},
            new Student{Name="Влад Цепишь", Group="1РИ4", Age=678, CSharpScore=95, SqlScore=91, HasPetProject=true},
            new Student{Name="Эдвард Каллен", Group="1РИ4", Age=17, CSharpScore=55, SqlScore=67, HasPetProject=false},
            new Student{Name="Папай", Group="3ГД1", Age=54, CSharpScore=99, SqlScore=99, HasPetProject=true}
        };
        
        var hackathon = new List<Student> { students[0], students[1], students[4], students[6], students[8] };
        var internship = new List<Student> { students[0], students[2], students[4], students[6], students[7] };
        
        Console.WriteLine("1. Старше 20 лет и C# > 70:");
        students.Where(s => s.Age > 20 && s.CSharpScore > 70)
                .ToList().ForEach(s => Console.WriteLine($"  {s.Name} ({s.Age} лет, C#:{s.CSharpScore})"));
        
        Console.WriteLine("\n2. Имя, группа, средний балл:");
        students.Select(s => new { s.Name, s.Group, Avg = s.Avg })
                .ToList().ForEach(x => Console.WriteLine($"  {x.Name}, {x.Group}, {x.Avg:F2}"));
        
        Console.WriteLine("\n3. Сортировка по среднему баллу (убывание):");
        students.OrderByDescending(s => s.Avg).ThenBy(s => s.Name)
                .ToList().ForEach(s => Console.WriteLine($"  {s.Name}: {s.Avg:F2}"));
        
        Console.WriteLine("\n4. Статистика:");
        Console.WriteLine($"  Количество: {students.Count()}");
        Console.WriteLine($"  Средний возраст: {students.Average(s => s.Age):F2}");
        Console.WriteLine($"  Макс C#: {students.Max(s => s.CSharpScore)}");
        Console.WriteLine($"  Мин SQL: {students.Min(s => s.SqlScore)}");
        
        var sorted = students.OrderByDescending(s => s.Avg).ToList();
        Console.WriteLine("\n5. Три лучших:");
        sorted.Take(3).ToList().ForEach(s => Console.WriteLine($"  {s.Name}: {s.Avg:F2}"));
        
        Console.WriteLine("\n   С 3 по 5 место:");
        sorted.Skip(2).Take(3).ToList().ForEach(s => Console.WriteLine($"  {s.Name}: {s.Avg:F2}"));
        
        Console.WriteLine("\n6. Студенты по группам:");
        students.GroupBy(s => s.Group)
                .ToList().ForEach(g => Console.WriteLine($"  {g.Key}: {g.Count()} чел."));
        
        Console.WriteLine("\n7. Хакатон vs Стажировка:");
        Console.WriteLine($"  Объединение: {hackathon.Union(internship).Count()} чел.");
        Console.WriteLine($"  Пересечение: {hackathon.Intersect(internship).Count()} чел.");
        Console.WriteLine($"  Разность (только хакатон): {hackathon.Except(internship).Count()} чел.");
    }
}