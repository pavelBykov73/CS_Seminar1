/*
Задача 23

Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

int power3(int value)
{
    return (int) Math.Pow(value, 3);
}

void printResult(int value)
{
    Console.WriteLine($"{value}^3 = {power3(value)}");
}

Console.Clear();
Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());
if(number >= 1){
    for(int i = 1; i <= number; i++){
        printResult(i);
    }   
}
else{
    for(int i = 1; i >= number; i--){
        printResult(i);
    }   
}
