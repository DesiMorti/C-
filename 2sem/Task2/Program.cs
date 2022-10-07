/*
    Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
*/

Console.Clear();
Console.Write("Введите целое число: ");
int a = int.Parse(Console.ReadLine()!);
string str = Convert.ToString(a);
for (int i = 0; i < str.Length; i++) {
            char c = str[i];
            if (i == 2) {
                Console.WriteLine($"Третья цифра: {c}");
            }
            if (str.Length <= 2) {
                Console.WriteLine("Третьей цифры нет");
                break;
            }
}

