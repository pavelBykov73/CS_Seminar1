/* Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4

17 -> такого числа в массиве нет

Особенности программы:
1. Массив целочисленный и инициализирован непосредственно в коде
2. Программа позволяет пользоватедю ввести номер элемента в 2 форматах: строка, столбец и по порядковому номеру
 */
internal class Program
{
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

    void PrintArray(int[,] arr)
    {
        Console.WriteLine("Массив:");
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
        Console.WriteLine("Массив:");
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            Console.Write("{0}\t", arr[i]);
        }
        Console.WriteLine("");
    }
    private static void Main(string[] args)
    {
        Program p = new Program(); // для доступа к полиморфным фукциям печати массивов

        // Создадим целочисленный массив и инициализируем его явно. 
        // При необходимости можно ввести пользователю или сгенерировать 
        int[,] array = new int[,] {
            {0,1,2,3},
            {10,11,12,13},
            {20,21,22,23},
            {30,31,32,33}
        };

        p.PrintArray(array);
        int[] positionArr = InputPosition();

        // Разделим обработку двух возможных вариантов ввода позиции
        switch (positionArr.Length)
        {
            case 1: // введен порядковый номер
                ProcessingBySerialNumber();
                break;

            case 2: // введен индекс строка, столбец
                ProcessingByRowCol();
                break;
        }

        void ProcessingBySerialNumber()
        {
            int inputSerialNumber = positionArr[0];
            int inputRow = GetRowFromSerialNumber(array.GetLength(0), positionArr[0]);
            int inputColumn = GetColumnFromSerialNumber(array.GetLength(0), positionArr[0]);
            if (inputSerialNumber >= 0
                && inputSerialNumber < array.Length)
            {
                Console.WriteLine("Элемент с порядковым номером {0} в массиве = {1}",
                    inputSerialNumber, array[inputRow, inputColumn]);
            }
            else
            {
                Console.WriteLine("Элемента с порядковым номером {0} в массиве не существует!",
                    inputSerialNumber);
            }

        }

        void ProcessingByRowCol()
        {
            int inputRow = positionArr[0];
            int inputColumn = positionArr[1];
            if (inputRow >= 0
                && inputRow < array.GetLength(0)
                && inputColumn >= 0
                && inputColumn < array.GetLength(1))
            {
                Console.WriteLine("Элемент с индексом {0}, {1} в массиве = {2}",
                    inputRow, inputColumn, array[inputRow, inputColumn]);
            }
            else
            {
                Console.WriteLine("Элемента с индексом {0}, {1} в массиве не существует!",
                    inputRow, inputColumn);
            }

        }

        // Ввод позиции в 2D массиве в 2 форматах. Результат - в целочисленном массиве
        int[] InputPosition()
        {
            int[] resultArr;
            Console.WriteLine("Введите в строке позицию элемента в формате i,j или порядковый номер:");
            while (true)
            {
                string? str = Console.ReadLine();
                if (str == null)
                {
                    Console.WriteLine("Ошибка ввода! Попробуйте еще раз: ");
                    continue;
                }
                resultArr = GetNumberArrayFromString(str);
                if (resultArr.Length == 1 || resultArr.Length == 2)
                {
                    return resultArr;
                }
                else
                {
                    Console.WriteLine("Ошибка ввода! Попробуйте еще раз: ");
                }
            }
        }

        int GetRowFromSerialNumber(int rowLength, int serialNum)
        {
            return serialNum / rowLength;
        }

        int GetColumnFromSerialNumber(int rowLength, int serialNum)
        {
            return serialNum % rowLength;
        }

        int GetSerialNumberFromRowCol(int rowLength, int row, int col)
        {
            return rowLength * row + col;
        }

        // Разберем строку с разделителями на числа и сформируем массив.
        // некорректные данные пропускаем
        int[] GetNumberArrayFromString(string str)
        {
            char[] charSeparator = new char[] { ' ', ',', '\t' };
            string[] arrStr = str.Split(charSeparator, StringSplitOptions.RemoveEmptyEntries);
            int number;
            int[] arr = new int[arrStr.Length];
            int succesCnt = 0;
            for (int i = 0; i < arrStr.Length; i++)
            {
                if (int.TryParse(arrStr[i], out number))
                {
                    arr[succesCnt] = number;
                    succesCnt++;
                }
            }
            // Resize the array to real numbers
            Array.Resize(ref arr, succesCnt);
            return arr;
        }
    }
}
