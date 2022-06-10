int n = int.Parse(Console.ReadLine());
int a = int.Parse(Console.ReadLine());
int sum = 0;
while (n > 0 | a % 2 != 0)
{
    sum += a;
    n--;
    Console.WriteLine(sum);
}
