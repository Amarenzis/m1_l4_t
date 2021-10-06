using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskDoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задача на использование операторов цикла с постусловием. 

            Console.WriteLine("Введите последовательность целых числе (положительных и отрицательных). Последним элементом последовательности будет 0");

            int number;
            int pozitive = 0;
            int negative = 0;

            do
            {
                number = Convert.ToInt32(Console.ReadLine());
                if (number > 0)
                {
                    pozitive++;
                }
                else if (number < 0)
                {
                    negative++;
                }
                //Console.WriteLine("Текущее число {0}, количество отрицательных {1}, а положительных {2}", number,negative,pozitive);
            } while (number != 0);

            Console.WriteLine("{0} чисел", (negative > pozitive) ? "Больше отрицательных" : (negative < pozitive) ? "Больше положительных" : "Введено поровну положительных и отрицательных");

            Console.ReadKey();
        }
    }
}
