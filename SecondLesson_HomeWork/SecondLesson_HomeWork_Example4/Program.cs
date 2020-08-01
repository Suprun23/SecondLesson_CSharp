using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondLesson_HomeWork_Example4
{
    class Program
    {
        //Реализовать метод проверки логина и пароля.На вход метода подается логин и пароль. 
        //На выходе истина, если прошел авторизацию, и ложь, если не прошел (Логин: root, Password: GeekBrains). 
        //Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль, программа пропускает его дальше или не пропускает.
        //С помощью цикла do while ограничить ввод пароля тремя попытками.


        //Фамилия выполняющего - Супрун
        static void Main(string[] args)
        {
            int entry = 0;
            do
            {
                Console.Write("Введите логин : ");
                string login = Console.ReadLine();

                Console.Write("Введите пароль : ");
                string password = Console.ReadLine();


                if (security(login, password) == true)
                {
                    Console.WriteLine("Добро пожаловать! ");
                    Console.ReadLine();
                    break;
                }
                else if (security(login, password) == false)
                {
                    entry++;
                    if (entry != 3)
                    {
                        Console.WriteLine("Попробуйте еще раз!");
                    }
                    else if (entry >= 3)
                    {
                        Console.WriteLine("Попытки входа исчерпаны!");
                        Console.ReadKey();
                    }
                    
                }
                
            }
            while (entry < 3); 
        }
        static bool security(string login,string password)
        {
            if (login == "root")
            {
                if (password == "GeekBrains")
                {
                    return true;
                }
                else return false;
            }
            else return false;
        }
    }
}
