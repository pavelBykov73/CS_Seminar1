/*
Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/
Console.Clear();
double[] numbers = new double[3];
Console.WriteLine("Введите первое число:");
numbers[0] = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите второе число:");
numbers[1] = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите третье число:");
numbers[2] = Convert.ToDouble(Console.ReadLine());

double max=numbers[0];
for(int i=1; i<numbers.Length; i++){
    if(numbers[i]>max){
        max=numbers[i];
    }
}
Console.WriteLine($"Максимальное число: {max}");
