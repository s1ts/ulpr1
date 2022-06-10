//6 zadanie
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int i;
int sum = 0;
if ((a < 0 || b < 0) | a > b)
{
    Console.WriteLine("неверный промежуток");
}
else
{
    for (i = a; i <= b; i++)
    {
        if (i % 4 == 0)
        {
            sum += i;
        }
    }
}
Console.WriteLine(sum);
