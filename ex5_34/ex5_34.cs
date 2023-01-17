/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2
*/
int[] arr = GenerateArray(10, 100, 1000);

Console.Clear();
Console.WriteLine($" [ {String.Join(", ",arr) } ]");
Console.Write($" Количество четных элементов = ");
Console.WriteLine(EvenNumberCalculate(arr));

int [] GenerateArray(int count, int minVal, int maxVal)
{
    int[] arr = new int[count];
    Random rnd = new Random();
    for(int i=0; i<arr.Length; i++){
        arr[i] = rnd.Next(minVal, maxVal);
    }
    return arr;
}    

int EvenNumberCalculate(int[] array)
{
    int evenCount=0;
    for(int i=0; i<array.Length; i++){
        if(array[i]%2 == 0){
            evenCount++;
        }
    }
    return evenCount;
}