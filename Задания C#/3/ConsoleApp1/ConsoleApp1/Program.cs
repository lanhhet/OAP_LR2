/*Задание 3.
a. Создайте целый двумерный массив и выведите его на консоль в отформатированном виде (матрица).
b. Создайте одномерный массив строк. Выведите на консоль его содержимое, длину массива. Поменяйте произвольный элемент (пользователь определяет позицию и значение).
c. Создайте ступечатый (не выровненный) массив вещественных чисел с 3-мя строками, в каждой из которых 2, 3 и 4 столбцов соответственно. Значения массива введите с консоли.
d. Создайте неявно типизированные переменные для хранения массива и строки.
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
            /*========= ЗАДАНИЕ 3А =========*/
            //Создайте целый двумерный массив и выведите на консоль в отформатированном виде (матрица).

            int[,] matrix = new int[,] { { 0, 1, 2, 3 }, { 4, 5, 6, 7 } };

            //выведем все элементы двумерного массива в строку
            foreach (var num in matrix) Console.Write($"{num} ");

            Console.WriteLine("\n");
            //выведем отформатированно
            //получим количество строк и столбцов 
            int rows = matrix.GetUpperBound(0) + 1; //Мы используем GetUpperBound() , чтобы узнать верхнюю границу массива для данного измерения
            int columns = matrix.Length / rows;


            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{matrix[i, j]} \t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\n====================");

            /*========= ЗАДАНИЕ 3B =========*/
            //Создайте одномерный массив строк. Выведите на консоль его содержимое, длину массива. Поменяйте произвольный элемент(пользователь определяет позицию и значение).
            string[] strmas = new string[] { "привет", "скоро ноябрь", "купи теплый шарфик", "не забудь про карамельки", "пейте чай" };

            //выведем на консоль содержимое массива строк
            foreach (var str in strmas) Console.WriteLine($"{str}");
            //выведем на консоль длину массива строк (количество элементов в нем)
            Console.WriteLine("Длина массива строк: {0}", strmas.Length);

            Console.WriteLine("Введите позицию элемента, который нужно изменить в массиве строк (количество элементов в массиве - 5):");
            decimal pos = Convert.ToDecimal(Console.ReadLine());
            if (pos <= 0 || pos > 5) Console.WriteLine("Введенное значение некорректно.");
            else
            {
                Console.WriteLine("Введите новое значение: ");
                string newelement = Console.ReadLine();
                strmas[(int)pos - 1] = newelement;
            }

            //выведем на консоль содержимое массива строк
            Console.WriteLine("\nПреобразованный массив: ");
            foreach (var str in strmas) Console.WriteLine($"{str}");

            Console.WriteLine("\n====================");

            /*========= ЗАДАНИЕ 3C =========*/
            //Создайте ступечатый (не выровненный) массив вещественных чисел с 3-мя строками, в каждой из которых 2, 3 и 4 столбцов соответственно. Значения массива введите с консоли.
            //Ступенчатый массив представляет собой массив массивов, в котором длина каждого массива может быть разной. 

            int[][] nums = new int[3][];
            nums[0] = new int[2];   // выделяем память для первого подмассива
            nums[1] = new int[3];  // выделяем память для второго подмассива
            nums[2] = new int[4]; // выделяем память для третьего подмассива

            Console.WriteLine("Введите ступенчатый массив: ");
            // перебор с помощью цикла for
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < nums[i].Length; j++)
                {
                    nums[i][j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            // вывод
            Console.WriteLine("\nСтупенчатый массив: ");
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < nums[i].Length; j++)
                {
                    Console.Write($"{nums[i][j]} \t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n====================");

            /*========= ЗАДАНИЕ 3D =========*/
            // Создайте неявно типизированные переменные для хранения массива и строки.

            // для массива
            var arr_int = new[] { 2, 30, 400, 5000 }; // array of integers
            var att_str = new[] { "my name ", "Darya" }; // array of strings

            Console.WriteLine("\nМассив целых чисел: ");
            foreach (var dig in arr_int) Console.WriteLine($"{dig}");
            Console.WriteLine("\nМассив строк: ");
            foreach (var str in att_str) Console.WriteLine($"{str}");
            // для строки
            var str2 = "Dark Power";
            Console.WriteLine(str2);

            Console.ReadKey(); //используем, чтобы консольное окно, после запуска программы, сразу не исчезло

        }
    }
}
