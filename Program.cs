/*
 * Project: SimpleThread
 * Filename: Program.cs
 * Author: R. Snell
 * Date: Jan 02, 2020
 * Purpose: To demonstrate the use and functioning of a thread.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ConsoleApp1
{
    class Program
    {
        public const int repetition = 1000;
        static void Main(string[] args)
        {
            ThreadStart threadStart = DoWork;
            Thread thread = new Thread(threadStart);
            thread.Start();
            for (int count = 0; count < repetition; count++)
                Console.Write('-');
            thread.Join();
            Console.WriteLine();
        }   // end Main()

        public static void DoWork()
        {
            for (int count = 0; count < repetition; count++)
                Console.Write('+');
        }   // end DoWork()
    }   // end class
}   // end namespace
