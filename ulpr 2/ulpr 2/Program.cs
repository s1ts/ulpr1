using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine()); //day
            int b = int.Parse(Console.ReadLine()); //month 
            int c = int.Parse(Console.ReadLine()); //year
            var dateJ = new DateTime(c, b, a);
            Console.WriteLine(dateJ.ToString());
            //
            int C = c / 100;
            int C1 = C / 4;
            double n = C - C1 - 2;
            a += (int)n;
            var dateG = new DateTime(c, b, a);
            Console.WriteLine(dateG.ToString(System.Globalization.CultureInfo.InvariantCulture));
            Console.ReadLine();
        }
    }
}
