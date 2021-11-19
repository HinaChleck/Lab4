using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Ввод данных и создание переменных
            Console.WriteLine("Введите длины сторон прямоугольника A и B:");
            float a = Convert.ToSingle(Console.ReadLine());
            float a1 = a;
            float b =Convert.ToSingle(Console.ReadLine());
            float b1 = b;   
            Console.WriteLine("Введите длину стороны квадрата:");
            float c = Convert.ToSingle(Console.ReadLine());
            int i=0;
            #endregion

            if (a<=0||b<=0||c<=0)
            {
                Console.WriteLine("Длина стороны должна быть положительным числом");
            }
            else
            {
                while (c<=a)
                {
                    a = a - c;
                    b = b1; //присваиваиваем переменной первоначальное значение

                    while (c<=b)
                    {
                        i++;
                        b = b - c;
                    }
                    
                }
                Console.WriteLine("В прямоугольник {0} на {1} поместится {2} квадр. со стороной {3}", a1, b1, i, c);
            }
            

            Console.ReadLine();

        }
    }
}
