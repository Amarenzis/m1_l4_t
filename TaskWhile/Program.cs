using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задача на использование операторов цикла с предусловием. 

            Console.WriteLine("Введите положительно число А");
            double numberA = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите положительно число B");
            double numberB = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите положительно число C");
            double numberC = Convert.ToDouble(Console.ReadLine());

            double squareConA = 0;
            double squareConB = 0;
            int iA = 0;
            int iB = 0;
            int squareQuantity = 0;


            while ((squareConA < numberA)|| (squareConB < numberB))
            {
                squareConA += numberC;
                if (squareConA <= numberA)
                {
                    iA++;
                }
                squareConB += numberC;
                if (squareConB <= numberB)
                {
                    iB++;
                }

            }
            //Console.WriteLine("По стороне А помещается {0}", iA);
            //Console.WriteLine("По стороне B помещается {0}", iB);
            while (iA > 0)
            {
                squareQuantity += iB;
                iA--;
            }
            Console.WriteLine("");
            Console.WriteLine("Итого {0} квадратов", squareQuantity);
            Console.WriteLine("Нажмите любую кнопку, чтобы выйти");
            Console.ReadKey();

        }
    }
}
