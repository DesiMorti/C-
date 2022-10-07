Console.Clear();
Console.Write("Введите целое число:");
int max = int.Parse(Console.ReadLine()!);

for (int i = 2; i <= max; i = i +2 ) {
    Console.Write($"{i} ");
}