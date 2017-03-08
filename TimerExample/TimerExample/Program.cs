/*
 *  Author: Troy Davis
 *  Project: Module07 - Understanding Events and Event-Driven Programming - TimerExample - Console
 *  Class: IN 2017 (Advanced C#)
 *  Date: Mar 07, 2017 
 *  Revision: Original
 */

using System;
using System.Timers;

namespace TimerExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // greeting
            Console.WriteLine("Module 07 - TimerExample\n");

            // implement Timer example
            Timer myTimer = new Timer(2000);

            // register timer event handlers
            myTimer.Elapsed += MyTimer_Elapsed1;
            myTimer.Elapsed += MyTimer_Elapsed2;

            // start timer
            myTimer.Start();

            // un-register the red colored timer event handler (MyTimer_Elapsed2)
            Console.WriteLine("\nPress 'Enter' to remove the Red event timer handler,\n  Press 'Enter' a second time to exit: \n");
            Console.ReadLine();

            myTimer.Elapsed -= MyTimer_Elapsed2;

            // wait on user to close console
            Console.ReadLine();
        }

        private static void MyTimer_Elapsed1(object sender, ElapsedEventArgs e)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Ellapsed 1: {0:HH:mm:ss.fff}", e.SignalTime);
        }

        private static void MyTimer_Elapsed2(object sender, ElapsedEventArgs e)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Ellapsed 2: {0:HH:mm:ss.fff}", e.SignalTime);
        }


    }
}
