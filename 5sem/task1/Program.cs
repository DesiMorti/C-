/*
    Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
    [345, 897, 568, 234] -> 2
*/

Console.Clear();
int N;
Console.Write("Укажите размер массива: ");
bool flag = int.TryParse(Console.ReadLine()!, out N);

if (N < 1 || !flag)
{
    Console.Write("Неверный ввод");
    return;
}

int[] FillArray(int array)
{
    int[] collection = new int[array];
    int index = 0;
    while (index < array)
    {
        collection[index] = new Random().Next(100, 1000);
        index++;
    }
    return collection;
}

int CountOfEven(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}

void PrintArray(int[] array)
{
    int count = array.Length;
    Console.Write("[");
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]}");
        if (i < count - 1)
        {
            Console.Write(", ");
        }
    }
    Console.Write("]");
}


int[] arr = FillArray(N);
PrintArray(arr);
Console.Write($" - количество четных чисел: {CountOfEven(arr)}");