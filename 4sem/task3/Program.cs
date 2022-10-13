/*
    Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
    1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
    6, 1, 33 -> [6, 1, 33]
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

int[] FillArray(int Array)
{
    int[] collection = new int[Array];
    int index = 0;
    while (index < Array)
    {
        collection[index] = new Random().Next(1, 100);
        index++;
    }
    return collection;
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
    Console.WriteLine("]");
}

PrintArray(FillArray(N));