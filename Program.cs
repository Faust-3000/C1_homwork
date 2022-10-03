/* Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3 */

/* Console.WriteLine("Введите первое число: ");
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
} */

/* Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22 */

Console.WriteLine("Введите первое число: ");
int Num1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число: ");
int Num2 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите третье число: ");
int Num3 = int.Parse(Console.ReadLine()!);
int max = Num1;

if (Num2 > Num1)
{
    max = Num2;
}
if(Num3 > Num2)
{
    max = Num3;
}
Console.WriteLine($"максимальное из этих чисел = {max}");