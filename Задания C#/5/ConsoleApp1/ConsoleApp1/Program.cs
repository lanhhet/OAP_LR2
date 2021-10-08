/* Задание 5.
Создайте локальную функцию в main и вызовите ее. 
Формальные параметры функции – массив целых чисел и строка. 
Функция должна вернуть кортеж, содержащий: максимальный и минимальный элементы массива, сумму элементов массива и первую букву строки .
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


            int SumAdd(int a, int b)
            {
                // тело метода
                return a + b;
            }

            Console.WriteLine("Введите первое число: ");
            int z = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число: ");
            int w = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Сумма чисел = {0}", SumAdd(z, w));

            (int, int, int, char) MakeTuple (int[] arr, string str)
            {
                Array.Sort(arr);
                int MaxElem = arr[arr.Length - 1];
                int MinElem = arr[0];

                int ArrSum = 0;
                for (var i = 0; i < arr.Length; i++) ArrSum = ArrSum + arr[i];
                char [] newstr = str.ToCharArray();
                (int, int, int, char) MyTuple = (MaxElem, MinElem, ArrSum, newstr[0]);

                return MyTuple;
            }

            Console.WriteLine("Введите количество элементов массива: ");
            int ArrLen = Convert.ToInt32(Console.ReadLine());
            int[] MyArray = new int[ArrLen];
            Console.WriteLine("Введите элементы массива: ");
            for (var i=0; i<ArrLen; i++)
            {
                MyArray[i] = Convert.ToInt32(Console.ReadLine());
            }

            string ystr = "";
            Console.WriteLine("Введите строку: ");
            ystr = Console.ReadLine();

            var ResTuple = MakeTuple(MyArray, ystr);
            Console.WriteLine(ResTuple);
        }
    }
}
