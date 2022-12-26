/*
Задача 19

Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/
bool isNumberPalindrom(int number)
{
    char[] digits = new char[11];
    uint i=0;
    uint j=0;
    number = Math.Abs(number);
    while(number > 0){
        digits[i] = (char) (number%10);
        number/=10;
        i++;
    }
    j=i-1;
    i=0;
    while(i < j){
        if(digits[i] != digits[j]) return false;
        i++;
        j--;
    }
    return true;
}

Console.Clear();
Console.WriteLine("Введите пятизначное положительное число:");
int number = Convert.ToInt32(Console.ReadLine());
if(number > 99999 || number < 10000){
    Console.WriteLine("Допустимы числа от 10000 до 99999!");
    Console.WriteLine("Перезапустите программу...");
    return;
}
if(isNumberPalindrom(number)){
    Console.WriteLine($"Число {number} -> палиндром");
}else{
    Console.WriteLine($"Число {number} -> НЕ палиндром");
}
