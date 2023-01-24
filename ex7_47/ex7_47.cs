/* Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.

0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
 */
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите количество строк в массиве:");
        int rows = InputPositiveNumberTryParse();
        Console.WriteLine("Введите количество столбцов в массиве:");
        int columns = InputPositiveNumberTryParse();
        double[,] array = GenerateArray(rows, columns);
        PrintArray(array);

        static int InputPositiveNumberTryParse()
        {
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

        double[,] GenerateArray(int row, int col)
        {
            double[,] arr = new double[row, col];
            Random rnd = new Random();
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = rnd.NextDouble();
                }
            }
            return arr;
        }

        void PrintArray(double[,] arr)
        {
            Console.WriteLine("Массив:");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write("{0:0.0}\t", arr[i, j]);
                }
                Console.WriteLine("");
            }
        }

    }
}