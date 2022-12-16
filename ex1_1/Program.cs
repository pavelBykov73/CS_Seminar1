/*
Задача №1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
a = 25, b = 5 -> да 
a = 2, b = 10 -> нет 
a = 9, b = -3 -> да 
a = -3 b = 9 -> нет
*/
Console.Clear();
Console.WriteLine("Введите первое число:");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int number2 = Convert.ToInt32(Console.ReadLine());
if(number1 == (Math.Pow(number2,2))){
    Console.WriteLine($"Да, квадрат числа {number2} ({number2}^2) = числу {number1}");
}
else{
    Console.WriteLine($"НЕТ, квадрат числа {number2} ({number2}^2) != числу {number1}");
}