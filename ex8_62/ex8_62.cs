/* Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
 */

internal class Program
{
    private static void Main(string[] args)
    {
        Program p = new Program(); // для доступа к полиморфным фукциям печати массивов

        int?[,] matrix1 = Generate2DMatrixWithParam(0, 10, "Введите параметры матрицы");
        p.PrintArray(matrix1, "Матрица 1:");

        int?[,] Generate2DMatrixWithParam(int minVal, int maxVal, string msg = "")
        {
            Console.WriteLine(msg);
            int rows = InputPositiveNumber("Введите количество строк:");
            int columns = InputPositiveNumber("Введите количество столбцов:");
            int?[,] arr = GenerateArraySpirale(rows, columns);
            return arr;
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

        int?[,] GenerateArraySpirale(int row, int col)
        {
            int?[,] arr = new int?[row, col];
            int val = 1;
            int i = 0;
            int j = 0;
            int dir = 0;
            arr[i, j] = val++;
            while (val < row * col)
            {
                switch (dir)
                {
                    case 0:
                        if (j + 1 >= col || arr[i, j + 1] != null)
                        {
                            dir = 1;
                        }
                        else
                        {
                            j++;
                            arr[i, j] = val++;
                        }
                        break;
                    case 1:
                        if (i + 1 >= row || arr[i + 1, j] != null)
                        {
                            dir = 2;
                        }
                        else
                        {
                            i++;
                            arr[i, j] = val++;
                        }
                        break;
                    case 2:
                        if (j - 1 <= 0 || arr[i, j - 1] != null)
                        {
                            dir = 3;
                        }
                        else
                        {
                            j--;
                            arr[i, j] = val++;
                        }
                        break;
                    case 3:
                        if (i - 1 <= 0 || arr[i - 1, j] != null)
                        {
                            dir = 0;
                        }
                        else
                        {
                            i--;
                            arr[i, j] = val++;
                        }
                        break;
                }
            }
            return arr;
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

    void PrintArray(int?[,] arr, string msg = "")
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
