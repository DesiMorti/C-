/* **Задача 37:** Найдите произведение пар чисел в одномерном
массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21 */

const int length = 5;
int[] array = new int[length];

int[] array2 = length % 2 == 0 ? new int[length / 2] : new int[length / 2 + 1]; // тернарный оператор, если условие верно, то исп. new int[length / 2], иначе new int[length / 2 + 1]
//int[] array2 = length % 2 == 0 ? length % 3 == 0 ? new int[length / 2] : new int[length / 2 + 1 : new int[length / 2 + 2]; пример вложенного тернарного оператора

for (int i = 0; i < length; i++)
{
    array[i] = new Random().Next(10);
    Console.Write($"{array[i]} ");
}

for (int i = 0; i < array2.Length; i++)
{
    if (i == length - i - 1)
        array2[i] = array[i];
    else
        array2[i] = array[i] * array[length - i - 1];
}

Console.Write($"-> ");

foreach (var item in array2)
{
    Console.Write($"{item} ");
}