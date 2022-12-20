/*
Семинар 2.
Задача 13: Напишите программу, которая выводит третью цифру заданного числа (слева направо) или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6
*/
Console.Clear();
Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 0){
    number = -number;
}
int devider=1;
int result=1;
// Найдем количество цифр в числе
while((number / devider) > 0){
    devider *= 10;
}
if(devider < 1000){
    Console.WriteLine("третьей цифры нет");
    return;
}
devider /= 1000; // Скорректируем делитель для доступа к нужной цифре
number /= devider; // Нужная цифра будет крайней справа в полученном числе
Console.WriteLine($"Третья слева цифра = {number%10}");
