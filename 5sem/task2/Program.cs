/*
    Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
    [3, 7, 23, 12] -> 19
    [-4, -6, 89, 6] -> 0
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
        collection[index] = new Random().Next(-99, 100);
        index++;
    }
    return collection;
}

int OddSumm(int[] array)
{
    int summ = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 != 0)
        {
            summ += array[i];
        }
    }
    return summ;
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
Console.Write($" - сумма нечетных чисел: {OddSumm(arr)}");