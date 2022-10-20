List<int> list = new List<int>();

for (int i = 0; i < 10; i++)
{
	list.Add(new Random().Next(10));
	Console.Write($"{list[i]} ");
}

list.Remove(5); //удаление значения
list.RemoveAt(1); //удаление позиции


list.Insert(3,99); //вставка значения 99 на позицию 3


Console.WriteLine();
for (int i = 0; i < list.Count; i++)
	Console.Write($"{list[i]} ");

    
int temp = 3;
if (list.Contains(temp)) // поиск значения
	Console.Write($"\n{temp} существует в массиве");