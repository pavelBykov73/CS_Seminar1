/* Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
 */

internal class Program
{
    private static void Main(string[] args)
    {
        Program p = new Program(); // для доступа к полиморфным фукциям печати массивов

        int rows = InputPositiveNumberTryParse("Введите количество строк в массиве:");
        int columns = InputPositiveNumberTryParse("Введите количество столбцов в массиве:");
        int[,] array = GenerateArray(rows, columns, -20, 20);
        p.PrintArray(array, "Исходный Массив:");
        SortRows(array);
        p.PrintArray(array, "После сортировки строк:");

        static int InputPositiveNumberTryParse(string msg)
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

        void SortRows(int[,] arr)
        {
            for (int row = 0; row < arr.GetLength(0); row++)
            {
                SortRow(arr, row); // массив передается по ссылке (время не тратится на копирование)
            }
        }
        
        void SortRow(int[,] arr, int row)
        {
            int temp;
            for (int i = 0; i < arr.GetLength(1) - 1; i++)
            {
                for (int j = i + 1; j < arr.GetLength(1); j++)
                {
                    if (arr[row, i] < arr[row, j])
                    {
                        temp = arr[row, i];
                        arr[row, i] = arr[row, j];
                        arr[row, j] = temp;
                    }
                }
            }
        }
    }
    void PrintArray(double[,] arr, string msg = "")
    {
        Console.WriteLine(msg);
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                Console.Write("{0:0.0}\t", arr[i, j]);
            }
            Console.WriteLine("");
        }
    }

    void PrintArray(int[,] arr, string msg = "")
    {
        Console.WriteLine(msg);
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                Console.Write("{0}\t", arr[i, j]);
            }
            Console.WriteLine("");
        }
    }
    void PrintArray(int[] arr, string msg = "")
    {
        Console.WriteLine(msg);
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            Console.Write("{0}\t", arr[i]);
        }
        Console.WriteLine("");
    }
    void PrintArray(double[] arr, string msg = "")
    {
        Console.WriteLine(msg);
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            Console.Write("{0:0.00}\t", arr[i]);
        }
        Console.WriteLine("");
    }

}
