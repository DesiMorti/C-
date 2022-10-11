/*
    Сортировка входного массива, в возрастающую последовательность.
*/

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

void PrintArray(int[] array) {
    int count = array.Length;
    for (int i = 0; i < count; i++) {
        Console.Write($"{array[i]}");
    }
    Console.WriteLine();
}

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

int rand = new Random().Next(2, 20);
int[] arr = new int[rand];

FillArray(arr);

PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);
