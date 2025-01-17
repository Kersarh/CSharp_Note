﻿using System;

namespace MyProgram
{
    class Program
    {
        static void Main(string[] args) // метод main
        {
            /*Метод - это именованный блок кода который
            * выполняет определенные действия.
            */

            // Вызов метода в текущем классе
            HelloWorld();

            // Возвращаем значение из метода
            var d = ReturnData(); // d = 10

            // Передача параметров в метод
            var s = Sum(10, 5);
            Console.WriteLine(s);

            /*
            * Возможно использовать необязательные параметры.
            * Для таких параметров необходимо указать значение по умолчанию.
            * После необязательного параметра все последующие также должны быть необязательными.
            * Например: int Sum2(int x, int y = 5, int z ) будет ошибкой
            * Так как после необязательного параметра y идея обязательный параметр z
            */

            // Один из параметров необязателен
            var s2 = Sum2(10);
            var s3 = Sum2(10, 20);
            Console.WriteLine($"{s2} - {s3}");

            // Использование именованных параметров
            // порядок передачи не важен
            var x = Sum2(y: 5, x: 1);
            Console.WriteLine(x);


            /* Передача параметров по ссылке
            * При передаче по значению метод получает не переменную,
            * а ее копию, поэтому метод не может изменить значение переменной.
            * При передаче параметра по ссылке метод получает адрес переменной в памяти,
            * что позволяет менять значение переменной в методе.
            * Для передачи значения по ссылке используется ключевое слово ref
            */

            int a = 5;
            Sum3(ref a, 2); // a+b
            Console.WriteLine(a); // 7


            /* Выходные параметры. Модификатор out
            * Позволяет вернуть значение не через оператор return
            * а в переменную переданную с параметром out
            */
            int z;
            Sum4(5, out z);
            Console.WriteLine(z); // 6

            // Значения переданные через модификатор in
            // нельзя изменить внутри метода
            int a2 = 3;
            Sum5(in a2, out int z2); // инициализация z2 внутри параметров метода
            Console.WriteLine(z2); // 8

            // Используя ключевое слово params
            // можно передавать неопределенное количество параметров
            Addition(1, 2, 3); // (x = 1, params = 2, 3)

            int[] arr = new int[] { 1, 2, 3, 4, 5 };
            Addition(arr); // 15

            // Перегрузка методов
            int over1 =  OverloadSum(1);
            int over2 = OverloadSum(1, 2);
            Console.WriteLine($"{over1} -- {over2}");

        }

        // Метод
        static void HelloWorld()
        {
            Console.WriteLine("Hello World!!!");
        }

        // Возвращаемое значение из метода командой return
        static int ReturnData()
        {
            return 10; // вернет 10
        }

        // Краткая запись метода
        static void PrintHello() => Console.WriteLine("Hello");

        // Краткая запись с возвратом значения
        static string GetHello() => "hello";

        // Передача параметров в метод
        // При вызове метода Sum значения передаются позиционно
        static int Sum(int x, int y)
        {
            return x + y;
        }

        // Необязательный параметр y
        static int Sum2(int x, int y = 5)
        {
            return x + y;
        }


        // Передача параметров по ссылке (ref)
        static void Sum3(ref int x, int y)
        {
            x += y;
        }

        // Результат возвращается не через оператор return,
        // а через выходной параметр (out).
        static void Sum4(int x, out int a)
        {
            a = x + 1;
        }

        static void Sum5(in int x, out int data)
        {
            // x = x + 5; // нельзя изменить x так как модификатор in
            int y = x;
            data = y + 5;

        }

        /* Используя ключевое слово params можно передавать
        * неизвестное заранее количество параметров.
        * Параметр с ключевым словом params должен представлять
        * одномерный массив того типа который мы используем. 
        * Возможно передавать отдельные значение или 
        * массив значений определенного типа или не передавать параметры вообще.
        */
        static void Addition(params int[] data)
        {
            int result = 0;
            for (int i = 0; i < data.Length; i++)
            {
                result += data[i];
            }
            Console.WriteLine(result);

        }

        // Перегрузка методов
        // Пример перегрузки методов под разные сигнатуры
        // Выполняться будет метод который подходит под переданные параметры
        static int OverloadSum(int x) => x + 1;
        static int OverloadSum(int x, int y) => x + y;

        // Краткая запись методов
        static void ShortMethod() => Console.WriteLine("Краткая запись метода");
        /* Что можно записать как
        * public void ShortMethod()
        * {
        *     Console.WriteLine("Краткая запись метода")
        * }
        */
        static int ShortMethod2(int x) => x+1;
        /* Что можно записать как
        * public int ShortMethod(int x)
        * {
        *     return x+1;
        * }
        */

    }
}
