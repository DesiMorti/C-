/*
    Задача 23. Напишите программу, которая принимает на вход число (N) 
    и выдаёт таблицу кубов чисел от 1 до N.
*/

Console.Clear();
int N;
Console.Write($"Введите число N: ");
int.TryParse(Console.ReadLine()!, out N);

void Cube(int num) {
    Console.Write($"Таблица кубов: ");
    for(int i = 1; i <= num; i++) {
        int c = (int)Math.Pow(i,3);
        Console.Write($"{c} ");
    }
}

Cube(N);