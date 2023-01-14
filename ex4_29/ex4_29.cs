/*
Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33]
*/

int[] arr = generateArray(8, -10, 10);

Console.Clear();
Console.WriteLine($" [ {String.Join(", ",arr) } ]");


int [] generateArray(int count, int minVal, int maxVal)
{
    int[] arr = new int[count];
    Random rnd = new Random();
    for(int i=0; i<arr.Length; i++){
        arr[i] = rnd.Next(minVal, maxVal);
    }
    return arr;
}    