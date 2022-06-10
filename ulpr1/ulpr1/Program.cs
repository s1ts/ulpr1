 // 1 задача без вариантов
using System;
using System.Globalization;
namespace z1
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt;
            int day = int.Parse(Console.ReadLine());
            int mounth = int.Parse(Console.ReadLine());
            int year = int.Parse(Console.ReadLine());
            string date = $"{year}, {mounth}, {day}";
            int countDaysOfEndOfYear;
            GregorianCalendar calendar = new GregorianCalendar();
            if (DateTime.TryParse(date, out dt))
            {
                Console.WriteLine(calendar.GetDayOfYear(dt));
                if (calendar.IsLeapYear(year))
                {
                    countDaysOfEndOfYear = 366 - calendar.GetDayOfYear(dt);

                }
                else
                {
                    countDaysOfEndOfYear = 365 - calendar.GetDayOfYear(dt);
                }
                Console.WriteLine(countDaysOfEndOfYear);
            }
            else
            {
                Console.WriteLine("Некорректная дата ");
            }
        }
    }
}
