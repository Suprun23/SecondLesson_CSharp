using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondLesson_HomeWork_Example2
{
    class Program
    {
        //Написать метод подсчета количества цифр числа.

        //Фамилия выполняющего - Супрун
        static void Main(string[] args)
        {
            
        }
        static int Num(int a)
        {
            int b = 1;
            for(int c = 1;c <= a;c *= 10)
            {
                if(a % c >= 1)
                {
                    b++;
                }
            }
            return b;
        }
    }
}
