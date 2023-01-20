/*
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/
internal class Program
{
    private static void Main(string[] args)
    {
        int[] array = GetArray();
        PrintArray(array);
        Console.WriteLine($"Количество элементов больше 0: {CountNumbersGreaterZero(array)}");

        int[] GetArray()
        {
            Console.Clear();
            Console.WriteLine("Введите M (1-20):");
            int number = InputNumberTryParse();
            while (number < 1 || number > 20)
            {
                Console.WriteLine("Допустимы положительные числа числа от 1 до 20! Введите еще раз:");
                number = InputNumberTryParse();
            }
            int[] arr = new int[number];
            Console.WriteLine("Введите {0} чисел:", number);
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = InputNumberTryParse();
            }
            return arr;
        }

        static int InputNumberTryParse()
        {
            while (true)
            {
                int number;
                if (int.TryParse(Console.ReadLine(), out number))
                    return number;
                else
                    Console.WriteLine("Ошибка ввода! Введите еще раз: ");
            }
        }

        static int InputNumberTryCatch()
        {
            string value = "";
            int outValue=0;
            while (true)
            {
                try
                {
                    value = Console.ReadLine();
                    outValue = Convert.ToInt32(value);
                    break;
                }
                catch (OverflowException)
                {
                    Console.WriteLine("{0} Число вне допустимого значения. Ошибка ввода! Введите еще раз:", value);
                }
                catch (FormatException)
                {
                    Console.WriteLine("The {0} value '{1}' Не распознан формат числа. Ошибка ввода! Введите еще раз:",
                                      value.GetType().Name, value);
                }
            }
            return outValue;
        }

        int CountNumbersGreaterZero(int[] arr)
        {
            int count = 0;
            foreach (var value in arr)
            {
                if (value > 0)
                {
                    count++;
                }
            }
            return count;
        }

        void PrintArray(int[] arr)
        {
            Console.WriteLine($" [ {String.Join(", ", arr)} ]");
        }
    }
}