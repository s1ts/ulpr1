//4 задане

namespace z4
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Введите число для преобразования ");
            int num = Convert.ToInt32(Console.ReadLine());
            int result = 0;
            for (int i = 0; ; i++)
            {
                if (num == 0) break;

                if (i != 0) result *= 10;

                result += num % 10;
                num /= 10;
            }

            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}