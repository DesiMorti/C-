/*
    Задача 18. Напишите программу, которая по заданному номеру четверти, 
    показывает диапазон возможных координат точек в этой четверти (х и у).
*/

Console.Clear();
int x;
Console.Write($"Введите номер четверти: ");
bool flag = int.TryParse(Console.ReadLine()!, out x);

if (!flag)
{
    Console.Write("Неверный ввод");
}
else
{
    switch (x)
    {
        case 1:     //if
            Console.Write($"X > 0 Y > 0");
            break;
        case 2:     //if
            Console.Write($"X < 0 Y > 0");
            break;
        case 3:     //if
            Console.Write($"X > 0 Y < 0");
            break;
        case 4:     //if
            Console.Write($"X < 0 Y < 0");
            break;
        default:    //else
            Console.Write($"Неверный ввод");
            break;
    }
}



