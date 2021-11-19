using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoCountWhile0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите последовательность положительных и отрицательных целых чисел:");
            int y;
            int iplus = 0;
            int iminus = 0;
           
            do
            {
                y = Convert.ToInt32(Console.ReadLine());
                if (y > 0) iplus++;
                if (y < 0) iminus++;
                
            } while (y!=0);

            Console.WriteLine("Количество положительных чисел - {0}", iplus);
            Console.WriteLine("Количество отрицательных чисел - {0}", iminus);

            Console.ReadKey();
        }
    }
}
