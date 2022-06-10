//4 задание
Random ran = new Random();
int y = 1;
Console.WriteLine("Введите число, до которого загадывать:");
int r = int.Parse(Console.ReadLine());
int x = ran.Next(y, r);
int z = ran.Next(1, 10);
Console.WriteLine($"Количество попыток:{z}");
for (int i = 1; i <= z; i++)
{
    Console.WriteLine($"Введите число от 1 до {r}:");
    int n = int.Parse(Console.ReadLine());
    if (i == z)
    {
        Console.WriteLine("Вы не угадали. Попыток больше нет.");
    }
    else
    {
        if (n < x)
        {
            Console.WriteLine($"Вы не угадали. Загаданное число больше. Осталось  { z - i} попыток");
        }
        if (n > x)
        {
            Console.WriteLine($"Не угадали. Загаданное число меньше. Осталось {z - i} попыток");
        }
        if (n == x)
        {
            Console.WriteLine("Вы угадали!");
            return;
        }
    }
}
