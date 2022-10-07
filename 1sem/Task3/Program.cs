Console.Clear();
Console.Write("Введите целое число:");
int a = int.Parse(Console.ReadLine()!);

if (a % 2 == 0) {
    Console.Write("Четное");
}
else {
    Console.Write("Нечетное");
}