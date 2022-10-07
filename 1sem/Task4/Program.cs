/*
    Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
*/

Console.Clear();
Console.Write("Введите целое число:");
int N = int.Parse(Console.ReadLine()!);

for (int i = 2; i <= N; i = i +2 ) {
    Console.Write($"{i} ");
}