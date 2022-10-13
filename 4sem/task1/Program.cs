/*
    Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
    3, 5 -> 243 (3⁵)
    2, 4 -> 16
*/

Console.Clear();
int A;
int B;

Console.Write("Введите число А: ");
bool flag1 = int.TryParse(Console.ReadLine()!, out A);
Console.Write("Введите число B: ");
bool flag2 = int.TryParse(Console.ReadLine()!, out B);

void MathExp(int A, int B)
{
    if (B > 0 && flag1 && flag1)
    {
        int temp;
        for (int i = 0; i < B; i++)
        {
            temp = A*A;
        }
        Console.Write($"{Math.Pow(A, B)} ");
    }
    else
    {
        Console.Write("Неверный ввод");
    }
}

MathExp(A,B);
