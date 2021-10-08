//Задание 6.
//Работа с checked/unchecked.
//a.Определите две локальные функции.
//b.Разместите в одной из них блок checked, в котором определите переменную типа int с максимальным возможным значением этого типа.Во второй функции определите блок unchecked с таким же содержимым.
//c.Вызовите две функции.Проанализируйте результат.


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
            
            int FirstNum()
            {
                checked
                { 
                    int a = 2147483647;
                    int b = a * 20202029;
                    return b;
                }
            }
            
           
            int SecondNum()
            {
                  unchecked
                  {
                      int x = 2147483647;
                      int y = x * 20202029;
                    return y;
                  }
            }

            try
            {
                Console.WriteLine("Выполнение первой функции... ");
                Console.WriteLine(FirstNum()); //вернет исключение
            }
            catch (OverflowException e)
            {
                Console.WriteLine("Переполнение. Ошибка {0}", e.Message);
            }

            Console.ReadKey();

            Console.WriteLine("Выполнение второй функции... ");
            Console.WriteLine(SecondNum()); //вернет ложное значение

        }

        

    }
}
