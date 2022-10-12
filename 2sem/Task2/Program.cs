/*
    Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
*/

Console.Clear();
Console.Write("Введите целое число: ");
int a = int.Parse(Console.ReadLine()!);
string str = Convert.ToString(a); // или string str = a.ToString();
for (int i = 0; i < str.Length; i++)
{
    char c = str[i];
    if (str.Length <= 2)
    {
        Console.WriteLine("Третьей цифры нет");
        break;
    }
    else if (i == 2)
    {
        Console.WriteLine($"Третья цифра: {c}");
    }
}

/* Оптимальное решение, если использовать строку:
Console.Clear();
Console.Write("Введите целое число: ");
int a;
Int.TryParse(Console.ReadLine()!, out a);

string str = a.ToString();

if (str.Length < 3) {
    Console.WriteLine("Третьей цифры нет");
}
else {
    Console.WriteLine($"Третья цифра: {str[2]}");
}
*/

/* Оптимальное решение:
Console.Clear();
Console.Write("Введите целое число: ");
int a;
int.TryParse(Console.ReadLine()!, out a);

int temp = a;

if (a < 100) {
    Console.WriteLine("Третьей цифры нет");
}
else {
    while (temp >= 1000) {
        temp /= 10;
    }
    Console.WriteLine($"Третья цифра: {temp % 10}");
}
*/
