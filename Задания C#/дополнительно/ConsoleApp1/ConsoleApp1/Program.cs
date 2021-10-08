//Ознакомьтесь с концепцией «небезопасного кода и указателей» в.NET. Познакомьтесь с ключевыми словами unsafe и fixed (закрепление указателей - защита участка кода от сборщика мусора)
//Ознакомьтесь с конструкцией using
//Прим. Код, применяющий указатели, еще называют небезопасным кодом.

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

            unsafe //блок кода, который использует указатели
            {

                int* x; // определение указателя - содержит значение адреса в памяти, по которому расположена переменная типа int
                int y = 10; // определяем переменную

                x = &y; // указатель x теперь указывает на адрес переменной y
                Console.WriteLine(*x); // 10 - разыменование

                y = y + 20;
                Console.WriteLine(*x); // 30

                *x = 50;
                Console.WriteLine(y); // переменная y=50

                //==================================
                int[] nums = { 0, 1, 2, 3, 7, 88 }; //будет размещен в куче
                fixed (int* b = nums)
                {
                    if (*(b+2) < 3)
                    {
                        Console.WriteLine(*(b+2)); //ожидаемый вывод: 2
                    }
                   
                }

            }

        }
    }
}
