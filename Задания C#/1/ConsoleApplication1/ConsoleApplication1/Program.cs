//1А. Определите переменные всех возможных примитивных типов С# и проинициализируйте их. Осуществите ввод и вывод их значений используя консоль.
/*
 1) bool: хранит значение true или false (System.Boolean)
 2) byte: хранит целое число от 0 до 255 и занимает 1 байт (System.Byte)
 3) sbyte: хранит целое число от -128 до 127 и занимает 1 байт (System.SByte)
 4) short: хранит целое число от -32768 до 32767 и занимает 2 байта (System.Int16)
 5) ushort: хранит целое число от 0 до 65535 и занимает 2 байта (System.UInt16)
 6) int: хранит целое число от -2147483648 до 2147483647 и занимает 4 байта (System.Int32)
 7) uint: хранит целое число от 0 до 4294967295 и занимает 4 байта (System.UInt32)
 8) long: хранит целое число от –9 223 372 036 854 775 808 до 9 223 372 036 854 775 807 и занимает 8 байт (System.Int64)
 9) ulong: хранит целое число от 0 до 18 446 744 073 709 551 615 и занимает 8 байт (System.UInt64)
 10) float: хранит число с плавающей точкой от -3.4*10^38 до 3.4*10^38 и занимает 4 байта (System.Single) 
 11) double: хранит число с плавающей точкой от ±5.0*10^-324 до ±1.7*10^308 и занимает 8 байт (System.Double) 
 12) decimal: хранит десятичное дробное число, занимает 16 байт (System.Decimal)
 13) char: хранит одиночный символ (символьный литерал) в кодировке Unicode и занимает 2 байта (System.Char)
 14) string: хранит набор символов Unicode (строковый литерал) (System.String)
 15) object: может хранить значение любого типа данных и занимает 4 байта на 32-разрядной платформе и 8 байт на 64-разрядной платформе (System.Object)
 
 1B. Выполните 5 операций явного и 5 неявного приведения типов. Изучите возможности класса Convert.
 1C. Выполните упаковку и распаковку значимых типов.
 1D. Продемонстрируйте работу с неявно типизированной переменной.
 1E. Продемонстрируйте пример работы с Nullable переменной.
 1F. Определите переменную типа var и присвойте ей любое значение. Затем следующей инструкцией присвойте ей значение другого типа. Объясните причину ошибки.
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
        static void Main()
        {
            /* ========================= ЗАДАНИЕ 1А ========================= */

            /* bool: хранит значение true или false (System.Boolean) */
            bool bool_var = true;
            Console.WriteLine("\nВведите значение булевой переменной : ");
            bool_var = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("Введенное значение : {0}", bool_var);

            /* byte: хранит целое число от 0 до 255 и занимает 1 байт (System.Byte) */
            byte byte_var = 255;
            Console.WriteLine("\nВведите значение переменной типа byte : ");
            byte_var = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Введенное значение : {0}", byte_var);

            /* sbyte: хранит целое число от -128 до 127 и занимает 1 байт (System.SByte) */
            sbyte sbyte_var = -128; // sbyte (signed byte)
            Console.WriteLine("\nВведите значение переменной типа sbyte : ");
            sbyte_var = Convert.ToSByte(Console.ReadLine());
            Console.WriteLine("Введенное значение : {0}", sbyte_var);


            /* short: хранит целое число от -32768 до 32767 и занимает 2 байта (System.Int16) */
            short short_var = -32768;
            Console.WriteLine("\nВвеждите значение переменной типа short : ");
            short_var = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Введенное значение : {0}", short_var);

            /* ushort: хранит целое число от 0 до 65535 и занимает 2 байта (System.UInt16) */
            ushort ushort_var = 65535; //ushort (unsigned short)
            Console.WriteLine("\nВведите значение переменной типа ushort : ");
            ushort_var = Convert.ToUInt16(Console.ReadLine());
            Console.WriteLine("Введенное значение : {0}", ushort_var);

            /* int: хранит целое число от -2147483648 до 2147483647 и занимает 4 байта (System.Int32) */
            int int_var = -100564;
            Console.WriteLine("\nВведите значение переменной типа int : ");
            int_var = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введенное значение: {0}", int_var);

            /* uint: хранит целое число от 0 до 4294967295 и занимает 4 байта (System.UInt32) */
            uint uint_var = 100564;
            Console.WriteLine("\nВведите значение переменной типа uint : ");
            uint_var = Convert.ToUInt32(Console.ReadLine());
            Console.WriteLine("Введенное значение: {0}", uint_var);

            /* long: хранит целое число от –9 223 372 036 854 775 808 до 9 223 372 036 854 775 807 и занимает 8 байт (System.Int64) */
            long long_var = -3546342011;
            Console.WriteLine("\nВведите значение переменной типа long : ");
            long_var = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Введенное значение: {0}", long_var);

            /* ulong: хранит целое число от 0 до 18 446 744 073 709 551 615 и занимает 8 байт (System.UInt64) */
            ulong ulong_var = 3546342011;
            Console.WriteLine("\nВведите значение переменной типа ulong : ");
            ulong_var = Convert.ToUInt64(Console.ReadLine());
            Console.WriteLine("Введенное значение: {0}", ulong_var);

            /* типы с плавающей точкой : float, double, decimal */

            /* float: хранит число с плавающей точкой от -3.4*10^38 до 3.4*10^38 и занимает 4 байта (System.Single) */
            float float_var1 = -5.4F;  // Литерал с суффиксом f или F имеет тип float
            Console.WriteLine("\nВведите значение переменной типа float : ");
            float_var1 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Введенное значение: {0}", float_var1);
            //еще один вариант инициализации: float_var2 = 134.45E-2f; // 1.3445

            /* double: хранит число с плавающей точкой от ±5.0*10^-324 до ±1.7*10^308 и занимает 8 байт (System.Double) */
            double double_var1 = 35.3;  // Литерал без суффикса или с суффиксом d или D имеет тип double
            Console.WriteLine("\nВведите значение переменной типа double : ");
            double_var1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введенное значение: {0}", double_var1);
            //еще один вариант инициализации:double_var2 = 0.42e2 ; // 42

            /* decimal: хранит десятичное дробное число, занимает 16 байт (System.Decimal) */
            decimal decimal_var = 1.56m; // Литерал с суффиксом m или M имеет тип decimal.
            Console.WriteLine("\nВведите значение переменной типа decimal : ");
            decimal_var = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Введенное значение: {0}", decimal_var);

            /* char: хранит одиночный символ (символьный литерал) в кодировке Unicode и занимает 2 байта (System.Char) */
            char char_var1 = 'S';

            /* еще варианты инициализации:
             char_var2 = ' ', // символ пробел
             char_var3 = '\x20', // символ пробел в виде кода в 16-й системе исчисления
             char_var4 = '\n'; // символ новой строки
            */
            Console.WriteLine("\nВведите значение переменной типа char : ");
            char_var1 = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Введенное значение: {0}", char_var1);

            /* string: хранит набор символов Unicode (строковый литерал) (System.String) */
            string string_var = "Hello? type sting!";
            Console.WriteLine("\nВведите значение переменной типа string : ");
            string_var = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Введенное значение: {0}", string_var);


            /* object: может хранить значение любого типа данных и занимает 4 байта на 32-разрядной платформе и 8 байт на 64-разрядной платформе (System.Object) 
              
               object (System.Object) — окончательный базовый класс для всех типов. Любой тип может быть автоматически (скрыто) приведен к базовому классу (upcast) object. 
             */
            object object_var = decimal_var;
            Console.WriteLine("\nВведите значение переменной типа object : ");
            object_var = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введенное значение: {0}", object_var);
            Console.WriteLine("=================================");

            /* ========================= ЗАДАНИЕ 1B ========================= */
            //неявное приведение типов: byte -> short -> int -> long -> decimal

            byte x1 = 255;
            short x2 = x1;
            Console.WriteLine("x2 = {0}", x2);

            int x3 = x2;
            Console.WriteLine("x3 = {0}", x3);

            long x4 = x3;
            Console.WriteLine("x4 = {0}", x4);

            decimal x5 = x4;
            Console.WriteLine("x5 = {0}", x5);

            object x6 = x5;
            Console.WriteLine("x6 = {0}", x6);

            //явное приведение типов

            float y1 = -5.4F;
            short y2 = (short)y1;
            Console.WriteLine("y2 = {0}", y2);

            short y3 = 32767;
            decimal y4 = (decimal)y3;
            Console.WriteLine("y4 = {0}", y4);

            int y5 = 10;
            double y6 = (double)y5;
            Console.WriteLine("y6 = {0}", y6);

            double y7 = 55;
            float y8 = (float)y7;
            Console.WriteLine("y8 = {0}", y8);

            sbyte y9 = -10;
            byte y10 = (byte)y9;
            Console.WriteLine("y10 = {0}", y10);

            //изучить возможности класса Convert

            float z1 = -49.34F;
            int z2 = Convert.ToInt32(z1);
            Console.WriteLine("z2 = {0}", z2); //округление до int

            int z3 = 45;
            long z4 = Convert.ToInt64(z3);
            Console.WriteLine("z4 = {0}", z4); //округление до long


            bool z5 = true;
            double z6 = Convert.ToDouble(z5);
            Console.WriteLine("z6 = {0}", z6);

            Console.WriteLine("=================================");

            /* ========================= ЗАДАНИЕ 1C ========================= */
            //Упаковка и распаковка значимых типов: упаковка - это из типа значения в тип object, а операция распаковки извлекает тип значения из объекта

            int i = 666;
            object myobj = i; //упаковка
            int k = (int)myobj; //распаковка
            Console.WriteLine("k = {0}", k);

            Console.WriteLine("=================================");

            /* ========================= ЗАДАНИЕ 1D ========================= */
            //Демонстрация работы с неявно типизированной переменной: Локальные переменные можно объявлять без указания конкретного типа. 
            //Ключевое слово var указывает, что компилятор должен вывести тип переменной из выражения справа от оператора инициализации. 

            var str = "daria my sign leo";
            Console.WriteLine("Тип неявно типизированной переменной str - {0}", str.GetType());

            Console.WriteLine("Введите значение неявно типизированной переменной: ");
            var j = Console.ReadLine();
            Console.WriteLine("Тип неявно типизированной переменной, введенной с клавиатуры, - {0}", j.GetType());

            Console.WriteLine("=================================");

            /* ========================= ЗАДАНИЕ 1E ========================= */
            //Демонстрация работы с Nullable переменной - это значит, значение переменной будет не определено.

            int? nul_var = null;
            Console.WriteLine("Значение Nullable-переменной #1: {0}", nul_var);
            Console.WriteLine("Хранит ли переменная некоторое значение? Ответ: {0}", nul_var.HasValue);

            //Но фактически запись ? является упрощенной формой использования структуры System.Nullable<T>. 
            //Параметр T в угловых скобках представляет универсальный параметр, вместо которого в конкретной задача уже подставляется конкретный тип данных.

            Nullable<float> nul_var2 = -56.88F;
            Console.WriteLine("Значение Nullable-переменной #2: {0}", nul_var);
            Console.WriteLine("Реальное значение, которое хранится в Nullable переменной: {0}", nul_var2.Value);
            Console.WriteLine("Хранит ли переменная некоторое значение? Ответ: {0}", nul_var2.HasValue);

            Console.WriteLine("=================================");

            /* ========================= ЗАДАНИЕ 1F ========================= */
            //Определите переменную типа var и присвойте ей любое значение. Затем следующей инструкцией присвойте ей значение другого типа. Объясните причину ошибки.

            /*
             ошибочный вариант:
            var task_f = 89;
            task_f = -34.55F;
            Причина ошибки: при инициализации переменной она получила тип int (от целого числа), затем следующее выражение содержит присваивание int-переменной значение float - ошибка, отсутствует приведение типов
             */
            var task_f = 89;
            task_f = (int)-34.55F;
            Console.WriteLine("Значение переменной task_f = {0}", task_f);


            Console.ReadKey(); //используем, чтобы консольное окно, после запуска программы, сразу не исчезло
        }
    }
}
