/*
 *  Author: Troy Davis
 *  Project: Module07 - Lesson 02 - Delegates - Console
 *  Class: IN 2017 (Advanced C#)
 *  Date: Mar 07, 2017 
 *  Revision: Original
 */

using System;

namespace Lesson02_Delegates
{
    // create delegate handler
    delegate void DelegateAlias(String s);

    class Program
    {
        static void Main(string[] args)
        {
            // greeting
            Console.WriteLine("Module 07 - Lesson 02 - Delegates\n");

            // instantiate delegates (a delegate acts like an alias to the assigned method, in other words another name for the method)
            //   NOTE: do not confuse my anaolgy of an 'alias' with the C# keyword alias
            DelegateAlias alias1, alias2, alias3;

            alias1 = new DelegateAlias(Method1);    // assign method reference to delegate
            alias2 = new DelegateAlias(Method2);    // assign method reference to delegate

            alias3 = Method1;   // shorthand syntax to assign event handler to alias3 (aka assign method to alias3 invocation list)
            alias3 += Method2;  // shorthand syntax to assign additional event handler to alias3 (aka add method to alias3 invocation list)
            alias3 += Method3;  // shorthand syntax to assign additional event handler to alias3 (aka add method to alias3 invocation list)

            // demonstrate delegate use
            alias1("using the 1st delegate, alias1");
            alias2("using the 2nd delegate, alias2");
            alias3("using the 3rd delegate, alias3");

            // wait on user to close console
            Console.Write("\nPress 'Enter' to exit: "); Console.ReadLine();
        }

        public static void Method1(String s)
        {
            Console.WriteLine("\tIn Method1: {0}", s);
        }

        public static void Method2(String s)
        {
            Console.WriteLine("\tIn Method2: {0}", s);
        }
        public static void Method3(String s)
        {
            Console.WriteLine("\tIn Method3: {0}", s);
        }
    }
}
