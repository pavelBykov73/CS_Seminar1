/*
Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76
*/
float[] arr = GenerateArray(10);
int idxMin=0;
int idxMax=0;

Console.Clear();
Console.WriteLine($" [ {String.Join(" ",arr) } ]");
MinMaxIdxFound(ref arr, ref idxMin, ref idxMax);
Console.WriteLine($" Максимальный элемент ({idxMax})= {arr[idxMax]}");
Console.WriteLine($" Минимальный элемент ({idxMin})= {arr[idxMin]}");
Console.WriteLine($" Разность максимального и минимального элементов = {arr[idxMax] - arr[idxMin]}");

float [] GenerateArray(int count)
{
    float[] arr = new float[count];
    Random rnd = new Random();
    for(int i=0; i<arr.Length; i++){
        arr[i] = rnd.NextSingle();
    }
    return arr;
}    

void MinMaxIdxFound(ref float[] array, ref int minIdx, ref int maxIdx)
{
    minIdx=maxIdx=0;
    for(int i=0; i<array.Length; i++){
        if(arr[i] < array[minIdx]){
            minIdx=i;
        }
        if(arr[i] > array[maxIdx]){
            maxIdx=i;
        }
    }
}
