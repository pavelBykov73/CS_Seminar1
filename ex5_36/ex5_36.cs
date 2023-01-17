/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/
int[] arr = GenerateArray(10, -1000, 1000);

Console.Clear();
Console.WriteLine($" [ {String.Join(", ",arr) } ]");
Console.Write($" Сумма элементов, стоящих на нечетных позициях = ");
Console.WriteLine(EvenPositionSum(arr));

int [] GenerateArray(int count, int minVal, int maxVal)
{
    int[] arr = new int[count];
    Random rnd = new Random();
    for(int i=0; i<arr.Length; i++){
        arr[i] = rnd.Next(minVal, maxVal);
    }
    return arr;
}    

int EvenPositionSum(int[] array)
{
    int sum=0;
    for(int i=1; i<array.Length; i+=2){
        sum+=arr[i];
    }
    return sum;
}