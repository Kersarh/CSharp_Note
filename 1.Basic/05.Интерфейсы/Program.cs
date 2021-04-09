﻿using System;

namespace MyProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Интерфейс может определять некоторый функционал как
            *  набор методов и свойств без их реализации
            *  которые может реализовать класс или структура.
            * Интерфейс определяет методы которые должны иметь реализацию.
            * С C# 8.0 интерфейс может определять реализацию по умолчанию.
            * 
            * Для определения интерфейса используется ключевое слово interface.
            * Названия интерфейсов в C# принято начинать с заглавной буквы I.
            * 
            * Что может определять интерфейс: 
            * Методы
            * Свойства
            * Индексаторы
            * События
            * Статические поля и константы (с C# 8.0)
            * 
            * Если в интерфейсе не указан модификатор доступа по умолчанию он будет public
            */

            // Инициализация через интерфейс!
            IData<string> idata = new MyClass(); 
            idata.Print("Hello");

            // Как обычный класс
            MyClass mc = new();
            mc.Print("World!");



        }

        // Создадим интерфейс определяющий метод Print
        // <T> не обязателен используется опционально
        interface IData<T>
        {
            void Print(T obj);
        }

        // Класс должен реализовывать интерфейс IData
        class MyClass : IData<string>
        {

            // В данном случае в классе должен быть метод Print
            public void Print(string s)
            {
                Console.WriteLine(s);
            }
        }


    }
}
