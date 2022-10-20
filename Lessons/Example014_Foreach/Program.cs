/* **Задача 33:** Задайте массив. Напишите программу, которая определяет,
присутствует ли заданное число в массиве.

4; массив [6, 7, 19, 345, 3] -> нет

3; массив [6, 7, 19, 345, 3] -> да */

const int length = 10;
int[] array = new int[length];

for (int i = 0; i < length; i++)
{
    array[i] = new Random().Next(10);
    Console.Write($"{array[i]} ");
}

int a;
Console.Write($"\nВведите число для поиска: ");
int.TryParse(Console.ReadLine()!, out a);

bool num_found = false;

foreach (var item in array)
{
    if (item == a)
    {
        num_found = true;
        break;
    }
}

if (num_found)
    Console.Write($"Такое число существует");
else
    Console.Write($"Такого числа нет");


/* Второй вариант решения:
const int length = 10;
int[] array = new int[length];

for (int i = 0; i < length; i++)
{
array[i] = new Random().Next(10);
Console.Write($"{array[i]} ");
}

int a;
Console.Write($"\nВведите число для поиска: ");
int.TryParse(Console.ReadLine()!, out a);

bool Contain(int[] _array, int _a)
{
foreach (var item in array)
if (item == a)
return true;
return false;

}
if (Contain(array, a))
Console.Write($"Такое число существует");
else
Console.Write($"Такого числа нет");
*/