using Labb5_GrundernaOOP;
using System;

namespace Labb5_GetArea
{       //Oskar Ullsten 820304
        //SUT 22-24

    class Program
    {
        static void Main(string[] args)
        {
            //Changed default background and forground color.
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            MainMenu(); //Method to call for menu where user can choose calculations
        }
        
         public static void MainMenu() //Did main menu in method so i could use it in other classes
         {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;

            bool program = true;
            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("ver.1.0");
                Console.WriteLine("|-------------------------------------|");
                Console.WriteLine("|  Welcome to my calculation program  |");
                Console.WriteLine("|-------------------------------------|");
                Console.WriteLine();
                Console.WriteLine("Select in the menu which calculation you want to see.");
                Console.WriteLine();
                Console.WriteLine(
                "[1] Circles\n" +
                "[2] Triangle\n" +
                "[3] Exit.");

                bool userChoice = true;
                int userAnswer;
                if (Int32.TryParse(Console.ReadLine(), out userAnswer))

                    switch (userAnswer)
                    {
                        case 1:
                            Console.WriteLine();
                            Circle.CircleMenu();
                            userChoice = false;
                            break;
                        case 2:                         
                            Triangle.TriangleMenu();
                            userChoice = false;
                            break;
                        case 3:
                            Console.WriteLine();
                            Environment.Exit(-1);
                            userChoice = false;
                            break;                        
                    }

                if (userChoice)
                {                    
                    Console.WriteLine();
                    Console.WriteLine("Make a choice within 1-3.");
                    Console.WriteLine();
                }                
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("|| Press any button to see menu again ||");
              
                Console.ReadKey();
            } while (program);
         }        

    }
}

