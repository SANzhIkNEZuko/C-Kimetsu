using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Сколько вам лет?");
            //int age = Convert.ToInt32(Console.ReadLine());

            ////string s_age = Convert.ToString(age);

            //Console.WriteLine("Ваш возраст: " + age);
            //if(age > 18)
            //{
            //    Console.WriteLine("Вы большой");
            //}

            //int a = 0;
            //while(a < 10){
            //    Console.WriteLine(a);
            //    a++;
            //}

            for (int i = 0; i < 10; i++)
            {
                Console.ReadKey(i);
            }
        }
    }
}
