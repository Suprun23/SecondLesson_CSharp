using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondLesson_HomeWork
{
    class Program
    {
        //Написать метод, возвращающий минимальное из трёх чисел.

        //Фамилия выполняющего - Супрун

        static void Main(string[] args)
        {
        }
        static int Min(int a,int b,int c)
        {
            if (a < b && a < c) return a;
            else if (b < a && b < c) return b;
            else if (c < a && c < b) return c;
            else return 0;
        }
    }
}
