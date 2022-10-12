/*
    Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
*/

Console.Clear();
Console.Write("Введите трехзначное число: ");
int a = int.Parse(Console.ReadLine()!);
string str = Convert.ToString(a);
for (int i = 0; i < str.Length; i++) {
            char c = str[i];
            if (i == 1) {
                Console.WriteLine($"Вторая цифра: {c}");
            }
}

/* Оптимальное решение:
int a;
Int.TryParse(Console.ReadLine()!, out a);

Console.Write($"{a / 10 % 10}") // При первом делении на 10 отпадает 3 знак, при втором получаем остаток(т.е 2 цифру)
*/