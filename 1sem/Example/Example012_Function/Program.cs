/*
    Сортировка входного массива, в возрастающую последовательность.
*/
/* Void функция(ничего не возвращает). Заполняет полученный(при вызове) массив случайными цифрами.
Console.Clear();
void FillArray(int[] collection) 
{
    int length = collection.Length;
    int index = 0;
    while (index < length) 
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}
*/

// Функция. Генерирует случайный массив размером от 2 до указанного(при вызове) числа, возвращает полученный массив.
int[] FillArray(int random) 
{
    int rand = new Random().Next(2, random);
    int[] collection = new int[rand];
    int index = 0;
    while (index < rand) 
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
    return collection;
}

// Void функция(ничего не возвращает). Выводит полученный(при вызове) массив в консоль.
void PrintArray(int[] array) {
    int count = array.Length;
    for (int i = 0; i < count; i++) {
        Console.Write($"{array[i]}");
    }
    Console.WriteLine();
}

// Void функция(ничего не возвращает). Сортирует полученный(при вызове) массив в порядке возврастания.
void SelectionSort(int[] array) {
    for (int i = 0; i < array.Length - 1; i++) {
        int minPosition = i;
        for (int j = i+1; j < array.Length; j++) {
            if(array[j] < array[minPosition]) {
                minPosition = j;
            }
        }
        int temp = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temp;
    }
}

/* Строки использовались вместе с Void функцией.
int rand = new Random().Next(2, 20);

int[] arr = new int[rand];
*/

int[] arr = FillArray(5);

PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);
