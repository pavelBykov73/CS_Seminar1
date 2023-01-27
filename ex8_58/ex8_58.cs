/* Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
 */

internal class Program
{
    private static void Main(string[] args)
    {
        Program p = new Program(); // для доступа к полиморфным фукциям печати массивов

        int[,] matrix1 = Generate2DMatrixWithParam(0, 10, "Введите параметры матрицы 1");
        int[,] matrix2 = Generate2DMatrixWithParam(0, 10, "Введите параметры матрицы 2");
        p.PrintArray(matrix1, "Матрица 1:");
        p.PrintArray(matrix2, "Матрица 2:");
        if (matrix1.GetLength(1) != matrix2.GetLength(0))
        {
            Console.WriteLine("Умножение матриц невозможно. Число строк матрицы 2 должно быть равно числу строк матрицы 1!");
        }
        else
        {
            int[,] matrix3 = MatrixMultiply(matrix1, matrix2);
            p.PrintArray(matrix3, "Результат умножения:");
        }

        int[,] Generate2DMatrixWithParam(int minVal, int maxVal, string msg = "")
        {
            Console.WriteLine(msg);
            int rows = InputPositiveNumber("Введите количество строк:");
            int columns = InputPositiveNumber("Введите количество столбцов:");
            int[,] arr = GenerateArray(rows, columns, minVal, maxVal);
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

        int[,] MatrixMultiply(int[,] arr1, int[,] arr2)
        {
            if (arr1.GetLength(1) != arr2.GetLength(0)) throw new Exception("Матрицы не перемножимы");
            int[,] outArr = new int[arr1.GetLength(0), arr2.GetLength(1)];
            for (int i = 0; i < arr1.GetLength(0); i++)
            {
                for (int j = 0; j < arr2.GetLength(1); j++)
                {
                    for (int k = 0; k < arr2.GetLength(0); k++)
                    {
                        outArr[i, j] += arr1[i, k] * arr2[k, j];
                    }
                }
            }
            return outArr;
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
