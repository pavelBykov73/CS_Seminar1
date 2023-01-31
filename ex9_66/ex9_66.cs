/* 
Задача 66: Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
 */
internal class Program
{
    private static void Main(string[] args)
    {
        int m = InputPositiveNumber("Введите натуральное число M:");
        int n = InputPositiveNumber("Введите натуральное число N:");
        if (m < n)
        {
            Console.WriteLine($"Сумма от {m} до {n} = {SummFromTo(m, n)}");
        }
        else{
            Console.WriteLine($"Сумма от {n} до {m} = {SummFromTo(n, m)}");
        }

        // Сумма натуральных чисел от from до to, включительно.
        // from должен быть не больше to. Иначе возвращаем -1.
        int SummFromTo(int from, int to)
        {
            if (from > to) return -1;
            if (from < to)
            {
                from += SummFromTo(from + 1, to);
            }
            return from;
        }

        static int InputPositiveNumber(string msg = "")
        {
            Console.WriteLine(msg);
            while (true)
            {
                int number;
                bool result = int.TryParse(Console.ReadLine(), out number);
                if (result && number > 0)
                    return number;
                else
                    Console.WriteLine("Ошибка ввода! Введите еще раз: ");
            }
        }
    }
}
