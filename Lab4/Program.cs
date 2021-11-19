using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число >0");
            int n = Convert.ToInt32(Console.ReadLine());
            int n2 = 0;
            if (n > 0)
            {
                for (int i = 1; i <= (2 * n - 1); i += 2)
                {
                    n2 = n2 + i;
                    Console.WriteLine(n2);
                }
            }
            else
                Console.WriteLine("Введеное число не соответствует заданным параметрам");

            Console.ReadKey();
        }
    }
}
