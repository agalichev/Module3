﻿using System;

namespace FirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            DaysOfWeek MyFavoriteDay;
            MyFavoriteDay = DaysOfWeek.Monday;
            const string MyName = "Alexander";
            const byte Age = 32;
            bool HaveIAPet = false;
            const byte ShoeSize = 41;
            Console.WriteLine("My name is " + MyName);
            Console.WriteLine("My age is {0}", Age);
            Console.WriteLine("Do I have a pet? {0}", HaveIAPet);
            Console.WriteLine("My shoe size is {0}", ShoeSize);
            Console.WriteLine("\u0023");
            Console.WriteLine("IntMin {0} ", int.MinValue);
            Console.WriteLine("IntMax {0} ", int.MaxValue);
            Console.WriteLine(MyFavoriteDay);
            Console.WriteLine("UShortMin = {0} UShortMax = {1}",ushort.MinValue, ushort.MaxValue);
            Console.ReadKey();
        }
    }

    enum Semaphore : ushort
    {
        Red = 100,
        Yellow = 200,
        Green = 300
    }
}
