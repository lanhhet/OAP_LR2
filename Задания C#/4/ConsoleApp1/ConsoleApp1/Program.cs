/* Задание 4.
a. Задайте кортеж из 5 элементов с типами int, string, char, string, ulong.
b. Выведите кортеж на консоль целиком и выборочно ( например 1, 3, 4 элементы)
c. Выполните распаковку кортежа в переменные.
   Продемонстрируйте различные способы распаковки кортежа.
   Продемонстрируйте использование переменной ( _ ). (доступно начиная с C#7.3)
d. Сравните два кортежа.
*/

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
        /*========= ЗАДАНИЕ 4А =========*/
        //Задайте кортеж из 5 элементов с типами int, string, char, string, ulong.

        var mytuple = (23, "The Sky", 'f', "Dog", 3456743333443) ;

        (int, string, char, string, ulong) mytuple2 = (10, "dune", 'g', "my future", 36446);

        /*========= ЗАДАНИЕ 4B =========*/
        //Выведите кортеж на консоль целиком и выборочно ( например 1, 3, 4 элементы)

         //выборочно
            Console.WriteLine("1 элемент кортежа: {0}", mytuple.Item1);
            Console.WriteLine("3 элемент кортежа: {0}", mytuple.Item3);
            Console.WriteLine("4 элемент кортежа: {0}", mytuple.Item4);

         //целиком
            (int a, string b, char c, string d, ulong e) = (10, "dune", 'g', "my future", 36446);
            Console.WriteLine($"Вывод кортежа №3 целиком: {a}, {b}, {c}, {d}, {e}");

            /*========= ЗАДАНИЕ 4C =========*/
            //Выполните распаковку кортежа в переменные. Продемонстрируйте различные способы распаковки кортежа. Продемонстрируйте использование переменной(_). (доступно начиная с C#7.3)

            (int elemtuple1, string elemtuple2, char elemtuple3, string elemtuple4, ulong elemtuple5) = (66, "home", 'a', "future", 111111);
            (var first, var middle, var last) = (-56.55F, 34, 'h'); // var внутри
            var (elem1, elem2, elem3, elem4, elem5) = mytuple2; // var снаружи

            Console.WriteLine(elem1);

            int x1;
            string x2;
            char x3;
            string x4;
            long x5;
            (x1, x2, x3, x4, x5) = mytuple; //переменные уже объявлены
            Console.WriteLine($"Вывод кортежа №1 в уже объявленные переменные: {x1}, {x2}, {x3}, {x4}, {x5}");

            int number = 10;
            Console.WriteLine(number);
            _ = Console.ReadLine(); //мы игнорируем значение, возвращаемое ReadLine(), оно нам неинтересно и память под переменную не выделяется


            /*========= ЗАДАНИЕ 4D =========*/
            //Сравнить два кортежа

            (int a, byte b) lefttuple = (5, 10);
            (long a, int b) righttuple = (5, 10);
            (float a, int b) middletuple = (-5.77F, 10);
            Console.WriteLine(lefttuple == righttuple);  // output: True
            Console.WriteLine(righttuple !=middletuple);  // output: True

            
         var (_, age) = GenerateDefaultPerson();
         Console.WriteLine($"Default person age is {age}");

            Console.ReadKey(); //используем, чтобы консольное окно, после запуска программы, сразу не исчезло
        }

        static (string name, int age) GenerateDefaultPerson()
        {
            return ("Daria", 18);
        }

    }
}
