﻿// 5 задание
class program
{
    static void Main(string[] args)
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine(".......");
        Parallel.For(0, 100, x => Console.Write((x = new Random().Next(a, b)) != 0 ?
       x.ToString() + "\n" : null));
        Console.ReadKey();
    }
}
