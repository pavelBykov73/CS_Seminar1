/*
Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8
*/
Console.Clear();
Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());
int step=2;
if(number < 0){
    step = -step;
}
int value=step;
Console.WriteLine("Четные числа от 0 до введенного числа:");
while(Math.Abs(value) <= Math.Abs(number)){
    Console.Write($"{value} ");
    value+=step;
}
