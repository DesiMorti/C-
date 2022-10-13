/*
    Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
    3, 5 -> 243 (3⁵)
    2, 4 -> 16
*/

Console.Clear();
int A;
int B; 
int result;

Console.Write("Введите число А: ");
int.TryParse(Console.ReadLine()!, out A);
Console.Write("Введите число B: ");
bool flag = int.TryParse(Console.ReadLine()!, out B);

