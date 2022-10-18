/*        **Задача 31:** Задайте массив из 12 элементов, заполненный случайными числами из 
промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.

Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма 
отрицательных равна -20.          */

const int size = 12;
int[] array = new int[size];

for (int i = 0; i < size; i++)
{
    array[i] = new Random().Next(-9, 10);
    Console.WriteLine($"{array[i]} ");
    Console.WriteLine(String.Format("{0,d2}", array[i], array[2]));
}

int sumP = 0;
int sumN = 0;

for (int i = 0; i < size; i++)
    if (array[i] > 0)
        sumP += array[i];
    else
        sumN += array[i];

Console.Write($"\nСумма положительных = {sumP}, отрицательных = {sumN}");
