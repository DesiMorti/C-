int a;
Console.Write($"Введите число: ");
int.TryParse(Console.ReadLine()!, out a);

Console.Write($"Сумма цифр от 1 до {a} = {Sum(a)}");

int Sum(int a)
{
int sum = 0;
for (int i = 1; i <= a; i++)
sum += i;
return sum;
}