/* 
Задача 64: Задайте значение N. Напишите программу, 
которая выведет все натуральные числа в промежутке от N до 1. 
Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1" 
*/
internal class Program
{
    private static void Main(string[] args)
    {
        int num = InputPositiveNumber("Введите натуральное число N:");
        PrintN(num);

        void PrintN(int n)
        {
            if (n > 0)
            {
                Console.Write($"{n} ");
                PrintN(n - 1);
            }

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



