/* Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)

 */

internal class Program
{
    private static void Main(string[] args)
    {
        Program p = new Program();

        int[,,] array = Generate3DMatrixWithParam(11, 99, "Введите 3D матрицу");
        p.PrintArray(array);

        int[,,] Generate3DMatrixWithParam(int minVal, int maxVal, string msg = "")
        {
            Console.WriteLine(msg);
            int dim1 = InputPositiveNumber("Введите размерность 1:");
            int dim2 = InputPositiveNumber("Введите размерность 2:");
            int dim3 = InputPositiveNumber("Введите размерность 3:");
            int[,,] arr = GenerateArrayUnique(dim1, dim2, dim3, minVal, maxVal);
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

        int[,,] GenerateArrayUnique(int x, int y, int z, int minVal, int maxVal)
        {
            int[,,] arr = new int[x, y, z];
            int newVal;
            Random rnd = new Random();
            maxVal++; // Коррекция верхней границы
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    for (int k = 0; k < arr.GetLength(2); k++)
                    {
                        // Если размер массива больше доступного количества доступных 
                        // разных значений, то допустим повторяющиеся элементы. ИНаче зависнем.
                        if (x * y * z < maxVal - minVal)
                        {
                            do
                            {
                                newVal = rnd.Next(minVal, maxVal);
                            } while (FindInArray(arr, newVal));
                        }
                        else
                        {
                            newVal = rnd.Next(minVal, maxVal);
                        }
                        arr[i, j, k] = newVal;
                    }
                }
            }
            return arr;
        }

        bool FindInArray(int[,,] arr, int val)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    for (int k = 0; k < arr.GetLength(2); k++)
                    {
                        if (arr[i, j, k] == val)
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
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

    void PrintArray(int[,,] arr, string msg = "")
    {
        Console.WriteLine(msg);
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                for (int k = 0; k < arr.GetLength(2); k++)
                {
                    Console.Write($"{arr[i, j, k]} ({i},{j},{k})\t");
                }
                Console.WriteLine("");
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
