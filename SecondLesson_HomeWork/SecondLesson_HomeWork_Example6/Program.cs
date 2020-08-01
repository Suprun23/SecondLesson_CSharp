using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SecondLesson_HomeWork_Example6
{
    class Program
    {
        //*Написать программу подсчета количества «хороших» чисел в диапазоне от 1 до 1 000 000 000.
        //«Хорошим» называется число, которое делится на сумму своих цифр. 
        //Реализовать подсчёт времени выполнения программы, используя структуру DateTime.



        //Фамилия выполняющего - Супрун
        static void Main(string[] args)
        {
            int num = 0;
            DateTime Start = DateTime.Now;
            
            for(int a = 1; a <= 1000000000; a++)
            {
                int sum = 0;
                int n = a;
                while (n != 0)
                {
                    sum += n % 10;
                    n /= 10;
                }
                if(a % sum == 0)
                {
                    num++;
                }
            }
            DateTime End = DateTime.Now;
            Console.WriteLine($"Время работы программы : {End - Start} ");
            Console.WriteLine(num);
            Console.ReadLine();
        }
    }
}
