/*
    Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
    452 -> 11
    82 -> 10
    9012 -> 12
*/

/*
4+5+2=11

4= 4 % 10
5 = 45 % 10
2 = 451 % 10

4 = 451/10/10
45 = 451/10
451 = 451

(451 % 10)+(451/10 % 10)+(451/10/10 % 10)=11

B[0]+B[1]+B[2]=11
*/

Console.Clear();
int A;
Console.Write("Введите число А: ");
bool flag = int.TryParse(Console.ReadLine()!, out A);

if (A < 0 || !flag)
{
    Console.Write("Неверный ввод");
    return;
}

int Length(int A)
{
    int temp = A;
    int i = 1;
    while (temp >= 10)
    {
        temp /= 10;
        i += 1;
    }
    return i;
}

void Summsign(int A)
{
    int length = Length(A);
    int[] B = new int[length];
    int temp = A;
    int result = 0;
    for (int i = 0; i < length; i++)
    {
        B[i] = temp % 10;
        result += B[i];
        temp /= 10;
    }
    Console.WriteLine($"Сумма знаков у числа: {result}");
}
Console.WriteLine($"Длина числа: {Length(A)}");
Summsign(A);