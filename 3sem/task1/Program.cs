/*
    Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
*/

Console.Clear();
Console.Write("Введите пятизначное число: ");
int a = int.Parse(Console.ReadLine()!);

void CheckPalindrome(int num){
    string str = Convert.ToString(a);
    int length = str.Length;
    if(a < 0 || length != 5){
        Console.Write("Некорректное число");
        return;
    }
    for (int i = 0; i < length/2; i++){
        if(str[i] != str[length-1-i]){
            Console.Write("Не палиндром");
            return;
        }    
    }
    Console.Write("Палиндром");
}

CheckPalindrome(a);