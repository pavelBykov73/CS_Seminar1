/* Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
 */

internal class Program
{
    private static void Main(string[] args)
    {
        Program p = new Program(); // для доступа к полиморфным фукциям печати массивов

        Console.WriteLine("Введите количество строк в массиве:");
        int rows = InputPositiveNumberTryParse();
        Console.WriteLine("Введите количество столбцов в массиве:");
        int columns = InputPositiveNumberTryParse();
        int[,] array = GenerateArray(rows, columns, -20, 20);
        Console.WriteLine("Массив:");
        p.PrintArray(array);
        double[] avg = ColumnAverage(array);
        Console.WriteLine("Среднее по столбцам:");
        p.PrintArray(avg);

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

        int[,] GenerateArray(int row, int col, int minVal, int maxVal)
        {
            int[,] arr = new int[row, col];
            Random rnd = new Random();
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = rnd.Next(minVal, maxVal);
                }
            }
            return arr;
        }

        double[] ColumnAverage(int[,] arr)
        {
            double[] outArr = new double[arr.GetLength(1)];
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                for (int i = 0; i < arr.GetLength(0); i++)
                {
                    outArr[j] += arr[i, j];
                }
            }
            int rowCnt = arr.GetLength(0);
            for (int i = 0; i < outArr.Length; i++)
            {
                outArr[i] /= rowCnt;
            }
            return outArr;
        }
    }
    void PrintArray(double[,] arr)
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                Console.Write("{0:0.0}\t", arr[i, j]);
            }
            Console.WriteLine("");
        }
    }

    void PrintArray(int[,] arr)
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                Console.Write("{0}\t", arr[i, j]);
            }
            Console.WriteLine("");
        }
    }
    void PrintArray(int[] arr)
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            Console.Write("{0}\t", arr[i]);
        }
        Console.WriteLine("");
    }
    void PrintArray(double[] arr)
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            Console.Write("{0:0.00}\t", arr[i]);
        }
        Console.WriteLine("");
    }
}
