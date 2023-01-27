/* Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
 */

internal class Program
{
    private static void Main(string[] args)
    {
        Program p = new Program(); // для доступа к полиморфным фукциям печати массивов

        int rows = InputPositiveNumber("Введите количество строк в массиве:");
        int columns = InputPositiveNumber("Введите количество столбцов в массиве:");
        int[,] array = GenerateArray(rows, columns, -20, 20);
        p.PrintArray(array, "Исходный Массив:");
        int[] arrSumByRow = SumByRows(array);
        p.PrintArray(arrSumByRow, "Массив сумм построчно:");
        int result = GetIdxOfMinimum(arrSumByRow);
        Console.WriteLine($"Строка с минимальной суммой: {result}. Значение = {arrSumByRow[result]}");

        static int InputPositiveNumber(string msg="")
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

        int[] SumByRows(int[,] arr)
        {
            int[] outArr = new int[arr.GetLength(0)];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    outArr[i] += arr[i, j];
                }
            }
            return outArr;
        }

        int GetIdxOfMinimum(int[] arr)
        {
            int min = 0;
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    min = i;
                }
            }
            return min;
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
