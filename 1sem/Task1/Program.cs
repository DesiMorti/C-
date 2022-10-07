/*
    Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
*/

Console.Clear();
Console.Write("Введите первое число: ");
double a = double.Parse(Console.ReadLine()!);
Console.Write("Введите второе число: ");
double b = double.Parse(Console.ReadLine()!);

if(a < b)
{
    Console.WriteLine($"Большее число: {a}, Меньшее число: {b}");
}
else
{
    Console.WriteLine($"Большее число: {a}, Меньшее число: {b}");
}