 // Ненужные импорты ?

namespace DebugTraining
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Анализ оценок студентов ===");
            Console.Write("Введите количество студентов: ");
            int studentCount = int.Parse(Console.ReadLine());

            string[] names = new string[studentCount];
            int[][] grades = new int[studentCount][];

            for (int i = 0; i < studentCount; i++)
            {
                Console.WriteLine($"\nСтудент #{i + 1}");
                Console.Write("Имя: ");
                names[i] = Console.ReadLine();

                Console.Write("Количество оценок: ");
                int gradeCount = int.Parse(Console.ReadLine());

                grades[i] = new int[gradeCount];

                Console.WriteLine("Введите оценки:");
                for (int j = 0; j < gradeCount; j++)   // заменяем <= на < чтобы не выходить за границу массива
                {
                    Console.Write($"Оценка {j + 1}: ");
                    grades[i][j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("\n=== Результаты ===");
            PrintStudents(names, grades);

            Console.WriteLine("\nПоиск студента с максимальным средним баллом...");
            string bestStudent = GetBestStudent(names, grades);
            Console.WriteLine($"Лучший студент: {bestStudent}");

            Console.WriteLine("\nВведите номер студента для подробного просмотра:");
            int index = int.Parse(Console.ReadLine());
            ShowStudentReport(names, grades, index);

            Console.WriteLine("\nПрограмма завершена.");
        }

        static void PrintStudents(string[] names, int[][] grades)
        {
            for (int i = 0; i < names.Length; i++)
            {
                double avg = CalculateAverage(grades[i]);
                Console.WriteLine($"{i + 1}. {names[i].ToUpper()} - средний балл: {avg:F2}");
            }
        }

        static double CalculateAverage(int[] marks)
        {
            int sum = 0;

            for (int i = 0; i < marks.Length; i++)
            {
                sum += marks[i];
            }

            return (double)sum / marks.Length; // выводим double вместо целостного
        }

        static string GetBestStudent(string[] names, int[][] grades)
        {
            double bestAverage = 0;
            int bestIndex = -1;

            for (int i = 0; i < names.Length; i++)
            {
                double avg = CalculateAverage(grades[i]);

                if (avg >= bestAverage) 
                {
                    bestAverage = avg;
                    bestIndex = i; // меняем i+1 на просто i, чтобы выводился правельный ученик
                }
            }
            return names[bestIndex];
        }

        static void ShowStudentReport(string[] names, int[][] grades, int index)
        {
            Console.WriteLine($"\nОтчёт по студенту: {names[index]}");

            int[] studentGrades = grades[index];
            Array.Sort(studentGrades);

            Console.WriteLine("Оценки:");
            for (int i = 0; i < studentGrades.Length; i++)
            {
                Console.Write(studentGrades[i] + " ");
            }

            Console.WriteLine();
            Console.WriteLine($"Минимальная оценка: {studentGrades[0]}");
            Console.WriteLine($"Максимальная оценка: {studentGrades[studentGrades.Length - 1]}"); // дбавляем -1, чтобы не вылезать за рамки массива
            Console.WriteLine($"Средний балл: {CalculateAverage(studentGrades):F2}");
            Console.WriteLine("Последняя буква имени студента: " + names[index].Substring(names[index].Length - 1, 1)); // дбавляем -1, чтобы не вылезать за рамки массива букв слова
        }
    }
}