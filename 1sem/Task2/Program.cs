Console.Clear();
Console.Write("Введите первое число:");
double a = double.Parse(Console.ReadLine()!);
Console.Write("Введите второе число:");
double b = double.Parse(Console.ReadLine()!);
Console.Write("Введите третье число:");
double c = double.Parse(Console.ReadLine()!);
double max = a;

if (max < b) {
    max = b;
}
if (max < c) {
    max = c;
}
Console.Write($"max = {max}");