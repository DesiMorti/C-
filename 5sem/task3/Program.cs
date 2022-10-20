/*
    Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
    [3 7 22 2 78] -> 76
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

double[] FillArray(int size)
{
    double[] collection = new double[size];
    int index = 0;
    int min = -5;
    int max = 5;
    while (index < size)
    {
        collection[index] = min + new Random().NextDouble() * (max - min);
        index++;
    }
    return collection;
}

double MaxMinDiff(double[] array)
{
    double min = array[0];
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min) min = array[i];
        else if (array[i] > max) max = array[i];
    }

    return max - min;
}

void PrintArray(double[] array)
{
    int count = array.Length;
    Console.Write("[");
    for (int i = 0; i < count; i++)
    {
        Console.Write("{0,6:F2}", array[i]);
        if (i < count - 1)
        {
            Console.Write(", ");
        }
    }
    Console.Write("]");
}


double[] arr = FillArray(N);
PrintArray(arr);

Console.Write(" - разница между максимальным и минимальным элементами: {0:F2}", MaxMinDiff(arr));