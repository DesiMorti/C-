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

