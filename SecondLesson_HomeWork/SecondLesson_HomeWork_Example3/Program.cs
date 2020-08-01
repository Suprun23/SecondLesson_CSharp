using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondLesson_HomeWork_Example3
{
    class Program
    {
        //С клавиатуры вводятся числа, пока не будет введен 0. 
        //Подсчитать сумму всех нечетных положительных чисел.


        //Фамилия выполняющего - Супрун
        static void Main(string[] args)
        {
            int num = 0;
            while(true)
            {
                int a = Convert.ToInt32(Console.ReadLine());
                if(a == 0)  break;
             
                else
                {
                    if(a > 0 && a % 2 != 0)
                    {
                        num += a;
                    }
                }
            }
            Console.WriteLine($"Сумма всех нечетных положительных чисел = {num}");
            Console.ReadKey();
        }
    }
}
