/* 
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
 */

internal class Program
{
    private static void Main(string[] args)
    {
        int m = InputPositiveNumber("Введите натуральное число M:");
        int n = InputPositiveNumber("Введите натуральное число N:");
        Console.WriteLine($"Функция Аккермана от {m}, {n} = {Akkerman(m, n)}");

        // https://ru.wikipedia.org/wiki/%D0%A4%D1%83%D0%BD%D0%BA%D1%86%D0%B8%D1%8F_%D0%90%D0%BA%D0%BA%D0%B5%D1%80%D0%BC%D0%B0%D0%BD%D0%B0
        int Akkerman(int n, int m)
        {
            /*  если n = 0
                 вернуть m + 1
               иначе, если m = 0
                 вернуть ack (n - 1, 1)
               еще
                 вернуть ack(n - 1, ack (n, m - 1))
             */
            if (n == 0) return m + 1;
            else
            {
                if (m == 0)
                {
                    return Akkerman(n - 1, 1);
                }
                else
                {
                    return Akkerman(n - 1, Akkerman(n, m - 1));
                }
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
