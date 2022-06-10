//4 задане
int n = int.Parse(Console.ReadLine());
int digit = 0;
while (n >= 1)
{
    digit = n % 10;
    n /= 10;
    Console.WriteLine(digit);
}
