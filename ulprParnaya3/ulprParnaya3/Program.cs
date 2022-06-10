//3 задание
var array = new int[] { 2, 3, 4, 6, 9, 3 };

int first = array.First();
int last = array.Last();

int countDivFirst = array.Count(i => i % first == 0);
int countDivLast = array.Count(i => i % last == 0);
if (countDivFirst > countDivLast)
{
    Console.WriteLine(countDivFirst);
}
else
{
    Console.WriteLine(countDivLast);
}
