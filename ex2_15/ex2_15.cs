/*
Семинар 2.
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/
Console.Clear();
Console.WriteLine("Введите день недели числом (1-7):");
int number = Convert.ToInt32(Console.ReadLine());
switch (number){
    case 1:
    case 2:
    case 3:
    case 4:
    case 5:
        Console.WriteLine("Нет, рабочий день");
    break;
    
    case 6:
    case 7:
        Console.WriteLine("Да, выходной");
    break;

    default:
        Console.WriteLine("Что-то не то с числом!");
        Console.WriteLine("Допустимы числа от 1 до 7!");
        Console.WriteLine("Перезапустите программу...");
    break;    
}
