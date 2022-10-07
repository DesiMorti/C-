Console.Clear();
Console.Write("Введите первое число: ");
double a = double.Parse(Console.ReadLine()!);
Console.Write("Введите второе число: ");
double b = double.Parse(Console.ReadLine()!);

if(a < b)
{
    Console.WriteLine($"Большее число: {a}, Меньшее число: {b}");
}
else
{
    Console.WriteLine($"Большее число: {a}, Меньшее число: {b}");
}