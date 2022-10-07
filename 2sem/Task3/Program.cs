/*
    Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
*/

Console.Clear();
Console.Write("Введите день недели(число): ");
int week = int.Parse(Console.ReadLine()!);

if(week < 1 || week > 7) {
    Console.WriteLine("Недопустимое число");
    return;
}
if(week >= 6) {
    Console.WriteLine("Выходной день");
}
else {
    Console.WriteLine("Рабочий день");
}
