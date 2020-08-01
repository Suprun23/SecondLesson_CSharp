using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SecondLesson_HomeWork_Example5
{
    class Program
    {
        //а) Написать программу, которая запрашивает массу и рост человека, вычисляет его индекс массы и сообщает, нужно ли человеку похудеть, набрать вес или всё в норме.
        //б) *Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.



        //Фамилия выполняющего - Супрун

        static void Main(string[] args)
        {
            

            Console.Write("Введите свой рост : ");
            double height = Convert.ToDouble(Console.ReadLine()) / 100;

            Console.Write("Укажите свой вес : ");
            double weight = Convert.ToDouble(Console.ReadLine());
            
            double index_body = weight / Math.Pow(height, 2);
            double weight_loss_min = height * 25;
            double weight_loss_max = height * 43.5;

            if (index_body >= 18.5 && index_body <= 25)
            {
                Console.WriteLine($"\nВаш ИМТ составляет : {index_body:F2}");
                Console.WriteLine("Ваш вес в норме!");
            }
            else if (index_body < 18.5)
            {
                Console.WriteLine($"\nВаш ИМТ составляет : {index_body:F2}");
                Console.WriteLine($"У вас дефицит массы! Следует набрать {weight_loss_min - weight:F2} кг - {weight_loss_max - weight:F2} кг");
            }
            else if (index_body > 25)
            {
                Console.WriteLine($"\nВаш ИМТ составляет : {index_body:F2}");
                Console.WriteLine($"Вы рискуете своим здоровьем! Следует похудеть на {weight - weight_loss_max:F2} кг - {weight - weight_loss_min:F2} кг");
            }
            Console.ReadKey();
        }
        
    }
}
