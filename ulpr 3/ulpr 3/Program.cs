// 3 задание
namespace z3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Год, который вы хотите ввести: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i < 12 + 1; i++)
            {
                DateTime date = new DateTime(n, i, DateTime.DaysInMonth(n, i));
                Console.WriteLine($"В {date.Month} месяце: {date.Day - (7 + (int)date.DayOfWeek - 4) % 7} четверг");
            }
        }
    }
}