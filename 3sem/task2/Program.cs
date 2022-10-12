/*
    Задача 21. Напишите программу, которая принимает на вход координаты 
    двух точек и находит расстояние между ними в 3D пространстве.
*/

Console.Clear();
int[] A = new int[3];
int[] B = new int[3]; 
double result;

Console.Write("Введите координаты X первой точки: ");
int.TryParse(Console.ReadLine()!, out A[0]);
Console.Write("Введите координаты Y первой точки: ");
int.TryParse(Console.ReadLine()!, out A[1]);
Console.Write("Введите координаты Z первой точки: ");
int.TryParse(Console.ReadLine()!, out A[2]);

Console.WriteLine();

Console.Write("Введите координаты X второй точки: ");
int.TryParse(Console.ReadLine()!, out B[0]);
Console.Write("Введите координаты Y второй точки: ");
int.TryParse(Console.ReadLine()!, out B[1]);
Console.Write("Введите координаты Z второй точки: ");
int.TryParse(Console.ReadLine()!, out B[2]);

Console.WriteLine();

result = Math.Round(Math.Sqrt(Math.Pow(B[0]-A[0], 2) + Math.Pow(B[1]-A[1], 2) + Math.Pow(B[2]-A[2], 2)), 3);
Console.Write($"Расстояние между точками: {result}");