/*Задание 2.
a. Объявите строковые литералы. Сравните их.
b. Создайте три строки на основе String. Выполните: сцепление, копирование, выделение подстроки, разделение строки на слова, вставки подстроки в заданную позицию, удаление заданной подстроки. Продемонстрируйте интерполирование строк.
c. Создайте пустую и null строку. Продемонстрируйте использование метода string.IsNullOrEmpty. Продемонстрируйте что еще можно выполнить с такими строками
d. Создайте строку на основе StringBuilder. Удалите определенные позиции и добавьте новые символы в начало и конец строки. 
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*============== ЗАДАНИЕ 2А ==============*/
            //Объявите строковые литералы. Сравните их - используем String.Equals() и String.Compare().

            //Инициализация строк строковыми литералами
            string mystr1 = "darya, sign leo";
            Console.WriteLine(mystr1);
            string mystr2 = "let's play with me";
            Console.WriteLine(mystr2);

            //Используем метод String.Equals(). Определяет, совпадают ли две строки. Возвращает логическое значение.
            bool res1 = mystr1.Equals(mystr2);

            if (res1 == false) Console.WriteLine("Строки не совпадают. ");
            else Console.WriteLine("Строки совпадают. ");

            //Используем метод String.Compare(). 
            int res2 = String.Compare(mystr1, mystr2);
            if (res2<0) Console.WriteLine("Cтрока '{0}' стоит раньше в порядке сортировки. ", mystr1);
            else if (res2 == 0) Console.WriteLine("Строки идентичны. ");
            else Console.WriteLine("Cтрока {0} стоит раньше в порядке сортировки. ", mystr2);
            

            Console.WriteLine("=====================");

            /*============== ЗАДАНИЕ 2B ==============*/
            //Создайте три строки на основе String. Выполните: сцепление, копирование, выделение подстроки, разделение строки на слова, вставки подстроки в заданную позицию, удаление заданной подстроки. Продемонстрируйте интерполирование строк.

            //СЦЕПЛЕНИЕ - символ "+", метод String.Concat () и метод String.Join()
            string str1 = "I'll walk with you my dear";
            string str2 = "Hey, hey, hey";
            string str3 = "Now wait, wait, wait for me, please hang around";

            string str_res = str1 + str2 + str3;
            Console.WriteLine(str_res);
            string str_res2 = String.Concat(str_res, "! :з");
            Console.WriteLine(str_res2);

            string[] values = new string[] { str1, str2, str3 }; //массив строк
            string str_res3 = String.Join(". ", values);
            Console.WriteLine(str_res3);

            //КОПИРОВАНИЕ - метод String.CopyTo() -  Этот метод копирует из строки часть символов, начиная с заданной позиции, и вставляет их !в массив символов!, также с указанной позиции. 
            char[] myarray = str3.ToCharArray(); //cоздание символьного массива на основе строки str3
            str2.CopyTo(0, myarray, 0, 3); //вставляем str2, начиная с 0 позиции, в символьный массив, начиная с 0 позиции, вставляем 3 элемента
            Console.WriteLine(myarray);

            //ВЫДЕЛЕНИЕ ПОДСТРОКИ - метод String.Substring() - Извлекает подстроку из данного экземпляра. Подстрока начинается в указанном положении символов и продолжается до конца строки.
            string str4 = str1.Substring(5);
            Console.WriteLine(str4);

            str4 = str2.Substring(0, 3);
            Console.WriteLine(str4);

            //РАЗДЕЛЕНИЕ СТРОКИ НА СЛОВА - метод String.Split() - разделяет строку на массив подстрок
            string[] subs = str1.Split(' ');

            foreach (var sub in subs)
            {
                Console.WriteLine("Substring: {0}", sub);
            }

            //ВСТАВКА ПОДСТРОКИ В ЗАДАННУЮ ПОЗИЦИЮ - метод String.Insert() 
            string modified = str2.Insert(5, str1);
            Console.WriteLine(modified);

            //УДАЛЕНИЕ ЗАДАННОЙ ПОДСТРОКИ - метод String.Replace()
            string result = str1.Replace("walk", "go");
            Console.WriteLine(result);

            result = str2.Replace("hey", "");
            Console.WriteLine(result);

            //ИНТЕРПОЛЯЦИЯ СТРОК
            /* Знак доллара перед строкой указывает, что будет осуществляться интерполяция строк. 
            Внутри строки опять же используются плейсхолдеры {...}, только внутри фигурных скобок уже можно напрямую писать те выражения, которые мы хотим вывести. */

            int x = 15;
            int y = 25;
            string sum = $"{x} + {y} = {x + y}";
            Console.WriteLine(sum); // 15 + 25 = 40

            Console.WriteLine("=====================");

            /*============== ЗАДАНИЕ 2C ==============*/
            //Создайте пустую и null строку. Продемонстрируйте использование метода string.IsNullOrEmpty (true если строка пуста или равна null). 
            //Продемонстрируйте что еще можно выполнить с такими строками.
            //В отличие от пустых строк строка NULL не ссылается на экземпляр объекта System.String, поэтому любая попытка вызвать метод для строки NULL приводит к исключению NullReferenceException. 
            //Но вы можете использовать строки NULL в операциях объединения и сравнения с другими строками.

            string full_str = "good morning";
            //пустые строки:
            string empty_str1 = "";
            string empty_str2 = String.Empty;

            //null-строка:
            string null_str = null;

            bool IsEmptyStr1 = String.IsNullOrEmpty(empty_str1);
            Console.WriteLine(IsEmptyStr1);
            bool IsEmptyStr2 = String.IsNullOrEmpty(empty_str2);
            Console.WriteLine(IsEmptyStr2);
            bool IsEmptyNullStr = String.IsNullOrEmpty(null_str);
            Console.WriteLine(IsEmptyNullStr);

            //Выдаст ошибку - Console.WriteLine(null_str.length) - любая попытка вызвать метод для строки NULL приводит к исключению NullReferenceException

            //Можно выполнить конкатенацию обычной строки и пустой строки:
            string tempStr = full_str + empty_str1;
            Console.WriteLine(tempStr);

            //Можно выполнить конкатенацию обычной строки и null-строки:
            tempStr = full_str + null_str;
            Console.WriteLine(tempStr);

            //Можно проверить, являются ли равными пустая строка и null-строка:
            bool AreEquals = (empty_str1 == null_str);
            //Ожидаемый вывод: False
            Console.WriteLine(AreEquals);

            //Создаем новую пустую строку, соединяя пустую и null-строку
            string empty_str3 = empty_str1 + null_str;
            bool IsEmptyStr3 = String.IsNullOrEmpty(empty_str3);
            Console.WriteLine(IsEmptyStr3); //true

            //существует метод String.IsNullOrWhiteSpace(String) - Указывает, имеет ли указанная строка значение null, является ли она пустой строкой или строкой, состоящей только из символов-разделителей.

            bool NullOrSpace1 = String.IsNullOrWhiteSpace(null_str);
            Console.WriteLine(NullOrSpace1); //true - является пустой

            string str_space = "      ";
            bool NullOrSpace2 = String.IsNullOrWhiteSpace(str_space);
            Console.WriteLine(NullOrSpace2); //true - состоит только из символов разделителей

            bool NullOrSpace3 = String.IsNullOrWhiteSpace(full_str);
            Console.WriteLine(NullOrSpace3); //false - строка не является пустой, она не null-строка и не состоит только из символов-разделителей

            Console.WriteLine("=====================");

            /*============== ЗАДАНИЕ 2D ==============*/
            //Создайте строку на основе StringBuilder - класс динамических строк. Удалите определенные позиции и добавьте новые символы в начало и конец строки. 
            StringBuilder sb = new StringBuilder("future");
            Console.WriteLine("Длина строки: {0}, емкость строки (выделено памяти): {1}", sb.Length, sb.Capacity); //StringBuilder выделяет памяти больше, чем необходимо этой строке

            //1) Метод Append - этот метод добавляет к строке подстроку
            sb.Append(" new symbols after");
            Console.WriteLine(sb);

            //2) Метод Insert - вставляет подстроку в объект StringBuilder, начиная с определенного индекса
            sb.Insert(0, "new symbols before ");
            Console.WriteLine(sb);

            //3) Метод Remove - удаляет определенное количество символов, начиная с определенного индекса
            sb.Remove(0, 19);
            Console.WriteLine(sb);
            sb.Remove(6, 18);
            Console.WriteLine(sb);

            //4) Метод Replace - заменяет все вхождения определенного символа или подстроки на другой символ или подстроку
            sb.Replace("u", "a");
            Console.WriteLine(sb);
            sb.Replace("a", "u");
            Console.WriteLine(sb);

            //5) Получение строки из объекта StringBuilder
            string mystr = sb.ToString();
            Console.WriteLine("Полученная строка из объекта StringBuilder - {0}", mystr);
        }
    }
}
