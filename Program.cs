﻿/* Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3 */

Console.WriteLine("Введите первое число: ");
int Num1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число: ");
int Num2 = int.Parse(Console.ReadLine()!);

if(Num1 > Num2)
{
    Console.WriteLine($"{Num1} больше {Num2}");
}
else if(Num1 < Num2)
{
    Console.WriteLine($"{Num1} меньше {Num2}");
}
else if(Num1 == Num2)
{
    Console.WriteLine($"{Num1} равен {Num2}");
}