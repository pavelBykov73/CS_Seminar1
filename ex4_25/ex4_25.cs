/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/
Console.Clear();
Console.WriteLine("Введите число A:");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите положительное число B:");
int b = Convert.ToInt32(Console.ReadLine());

if(b < 0){
    Console.WriteLine("Допустимы только положительные числа B!");
    Console.WriteLine("Перезапустите программу...");
    return;
}
int res = myPow(a,(uint)b);
Console.WriteLine($"A^B = {res}");

int myPow(int num, uint pow)
{
    int result=1;
    for(int i=0; i<pow; i++){
        result*=num;
    }
    return result;
}
