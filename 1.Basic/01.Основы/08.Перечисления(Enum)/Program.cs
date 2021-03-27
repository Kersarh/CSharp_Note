﻿using System;

namespace MyProgram
{
    class Program
    {
        /*
        * Тип перечисления (или тип enum) — это тип значения,
        * определенный набором именованных констант применяемого целочисленного типа.
        * Чтобы определить тип перечисления, используйте ключевое слово enum
        * Объявление перечисления происходит с помощью оператора enum.
        * Далее идет наименование перечисления, указывается тип перечисления.
        * Тип перечисления обязательно должен быть целочисленный тип (byte, int, short, long)
        * По умолчанию используется тип int.
        * Затем идет список элементов перечисления через запятую.
        */
        enum Days
        {
            Monday, // 0
            Tuesday, // 1
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday // 6
        };

        //  Мы можем также явным образом указать значения элементов, либо указав значение первого элемента:
        enum Operation
        {
            Add = 1,   // каждый следующий элемент по умолчанию увеличивается на единицу
            Subtract, // этот элемент равен 2
            Multiply, // равен 3
            Divide    // равен 4
        };

        // Возможно явным образом указать значения элементов,
        // или указать значение первого элемента:
        enum Season
        {
            Spring = 1, // каждый следующий элемент увеличивается на единицу
            Summer, // 2
            Autumn,
            Winter
        }

        static void Main(string[] args)
        {

            Days d = Days.Sunday;
            Console.WriteLine(d); // Sunday
            Console.WriteLine((int)d); // 6

        }

    }
}

