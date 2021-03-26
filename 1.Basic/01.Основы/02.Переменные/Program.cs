﻿using System;

namespace MyProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            * Для хранения данных в C# применяются переменные.
            * Переменные это по сути именованный участок памяти, в котором хранится значение.
            * Переменные имеют тип, имя и значение.
            * Тип определяет, какая информацию может храниться в переменной. 
            * Имя это собственно наименование переменной в программе.
            * Значение это те данные которые хранит переменная.
            * 
            * Перед использованием переменная должна быть определена.
            * Синтаксис определения переменной:
            * тип имя; 
            */

            // Определим числовую (int) перемершую a
            int a;
            // /Присвоим ей значение
            a = 10;
            Console.WriteLine($"a = {a}");

            // Или можно записать в одну строку
            int b = 20;
            Console.WriteLine($"b = {b}");

            // Данные записи эквивалентны
            int c = 10;
            System.Int32 d = 10;

            /*
            * Типы данных.
            * char: одиночный символ в кодировке Unicode занимает 2 байта.
            * string: набор символов Unicode.
            * bool: true или false.
            * byte: целое число от 0 до 255, занимает 1 байт
            * sbyte: целое число от -128 до 127, занимает 1 байт
            * int: целое число от -2147483648 до 2147483647 и занимает 4 байта.
            * uint: целое число от 0 до 4294967295 и занимает 4 байта.
            * short: целое число от -32768 до 32767 и занимает 2 байта.
            * ushort: целое число от 0 до 65535 и занимает 2 байта.
            * float: число с плавающей точкой от -3.4*1038 до 3.4*1038 и занимает 4 байта.
            * double: число с плавающей точкой от ±5.0*10-324 до ±1.7*10308 и занимает 8 байта.
            * long: целое число от –9 223 372 036 854 775 808 до 9 223 372 036 854 775 807 и занимает 8 байт.
            * ulong: целое число от 0 до 18 446 744 073 709 551 615 и занимает 8 байт.
            * decimal: десятичное дробное число.
            * object: значение любого типа данных и занимает 4 байта на 32-разрядной платформе и 8 байт на 64-разрядной платформе.
            */

            string name = "User";
            int age = 40;
            bool work = false;
            double weight = 80.5;
            // Вывод переменных в консоль
            Console.WriteLine($"Имя: {name} Возраст: {age} Работа: {work} Вес: {weight}");
            Console.WriteLine("Имя: {0}  Возраст: {1}  Работа: {2}  Вес: {3}", name, age, work, weight);

            /*
            * Получение данных из консоли в переменную
            * Console.ReadLine получает информацию в виде строки, но часто нужно получить ввод в виде числа.
            * Convert.ToInt32 преобразует ввод из строки в число
            */
            string mynum = "10";
            int num = Convert.ToInt32(mynum);
            Console.WriteLine($"Конвертация: {num}");

            /*
            * Использование суффиксов
            * При присвоении значений все вещественные литералы рассматриваются как значения типа double.
            * Чтобы указать, что дробное число представляет тип float или тип decimal, необходимо к литералу добавлять суффикс:
            * F/f - для float и M/m - для decimal.
            */
            float fl1 = 3.14F;
            float fl2 = 30.6f;
            Console.WriteLine($"{fl1} тип: {fl1.GetType()}");

            /*
            * Подобным образом целочисленные литералы рассматриваются как значения типа int.
            * Чтобы указать, что целочисленный литерал представляет значение типа uint,
            * //надо использовать суффикс U/u, для типа long - суффикс L/l, а для типа ulong - суффикс UL/ul:
            */
            uint ui1 = 10U;
            long lg2 = 20L;
            ulong ulg3 = 30UL;

            // Null
            // Некоторые переменные могут иметь еще и значение null
            // Задается знаком ? после указания типа
            int myint1 = 10; // не может быть null
            int? myint2 = 10; // может быть null

            // Свойство HasValue позволяет проверить содержит ли переменная значение:
            if (myint2.HasValue) // либо (myint2 != null)
            {
                Console.WriteLine($"Содержит: {myint2.Value}");
            }
            else
            {
                Console.WriteLine("Нет значения(null)");
            }

            // Можно использовать оператор is с шаблоном типа как для проверки экземпляра типа,
            // допускающего значение null, так и для извлечения значения базового типа.
            if (a is int mydata)
            {
                Console.WriteLine($"Содержит: {mydata}");
            }
            else
            {
                Console.WriteLine("Нет значения(null)");
            }

            Console.ReadKey();  // Ожидает нажатия любой клавиши
        }
    }
}
