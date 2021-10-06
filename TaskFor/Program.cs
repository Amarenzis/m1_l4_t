using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskFor
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задача на использование операторов цикла for.
            Console.WriteLine("Введите целое положительное число. ");
            int number = Convert.ToInt32(Console.ReadLine());
            int count = -1;
            int sum = 0;
            Console.WriteLine("");

            for (int i = 0; i <= (2 * number - 1); i += 2)
            {
                count += 2;
                sum += count;
                Console.WriteLine("{0}", sum);
            }
            Console.WriteLine("");
            Console.WriteLine("Квадрат number равен {0}", sum);
            Console.ReadKey();
        }
    }
}
