/*
 *  Author: Troy Davis
 *  Project: Module07 - Lesson 02 - Inheritance - Console
 *  Class: IN 2017 (Advanced C#)
 *  Date: Mar 07, 2017 
 *  Revision: Original
 */

using System;


namespace Lesson02_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // greeting
            Console.WriteLine("Module 07 - Lesson 02 - Inheritance\n");

            // example of inheritance
            Movie movie1 = new Movie();
            movie1.Name = "Movie 1";
            Comedy movie2 = new Comedy();
            movie2.Name = "Movie 2";
            movie2.FunnyScenes = 6;
            Horror movie3 = new Horror();
            movie3.Name = "Movie 3";
            movie3.ScaryScenes = 12;

            movie1.Genre();
            movie2.Genre();
            movie3.Genre();

            // wait on user to close console
            Console.Write("\nPress 'Enter' to exit: "); Console.ReadLine();
        }
    }

    class Movie
    {
        public String Name { get; set; }

        public virtual void Genre()
        {
            Console.WriteLine("\t{0} is of the Generic genre.", this.Name);
        }

    }

    class Comedy : Movie
    {
        public int FunnyScenes { get; set; }

        public override void Genre()
        {
            Console.WriteLine("\t{0} is of the Comedy genre. It has {1} funny scenes.", this.Name, this.FunnyScenes);
        }
    }
    class Horror : Movie
    {
        public int ScaryScenes { get; set; }

        public override void Genre()
        {
            Console.WriteLine("\t{0} is of the Horror genre. It has {1} scary scenes.", this.Name, this.ScaryScenes);
        }
    }
}
