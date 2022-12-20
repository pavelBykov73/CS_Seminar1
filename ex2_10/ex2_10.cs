/*
Семинар 2.
ЗЗадача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/
Console.Clear();
Console.WriteLine("Введите трехзначное положительное число:");
int number = Convert.ToInt32(Console.ReadLine());
if(number > 999 || number <100){
    Console.WriteLine("Допустимы числа от 100 до 999!");
    Console.WriteLine("Перезапустите программу...");
    return;
}
int digit2=(number/10)%10;
Console.WriteLine($"Вторая цифра = {digit2}");

