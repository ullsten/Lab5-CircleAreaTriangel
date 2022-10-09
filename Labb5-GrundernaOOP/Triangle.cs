using System;
using System.Collections.Generic;
using System.Drawing;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Labb5_GrundernaOOP
{
    class Triangle
    {
        private string ColorName;
        private double _base;
        private double height;
        private double sideA = 5;
        private double sideB = 2;
        private double sideC = 20;
        
        public Triangle(string ColorName)
        {
            this.ColorName = ColorName;
        }

        public string GetColor()
        {
            return this.ColorName;
        }
        public double GetArea() //Area calculation
        {
            return _base * height / 2;
        }        
        public void SetBase(double b)
        {
            _base = b;
        }
        public double GetBase()
        {
            return _base;
        }
        public void SetHeight(double h)
        {
            height = h;
        }
        public double GetHeight()
        {
            return height;
        }        
        
        public double GetPerimeter() //Perimeter calculation
        {
            return sideA + sideB + sideC;
        }

        public static void TriangleMenu() //Menu for triangle in do-while loop
        {            
            var sideA = 5;
            var sideB = 2;
            var sideC = 20;

            Triangle mytriangle = new Triangle("Green");
            mytriangle.GetColor();
            mytriangle.SetHeight(5);
            mytriangle.SetBase(10);            

            bool TriangleChoice = true;
            do
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Clear();

                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("Tri ver.1.0");
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("|-------------------------------------|");
                Console.WriteLine("|          Triangle Calculation       |");
                Console.WriteLine("|-------------------------------------|");
                Console.WriteLine();
                Console.WriteLine("Select calculation from the list.");
                Console.WriteLine();
                Console.WriteLine("[1]Color of triangle");
                Console.WriteLine("[2]Size of sides");
                Console.WriteLine("[3]Area");
                Console.WriteLine("[4]Perimeter");
                Console.WriteLine("[5]Draw triangle");
                Console.WriteLine();
                Console.WriteLine("[6]Main menu");                
                Console.WriteLine("[7]Exit program");                

                bool CalcTriangle = true;
                int userAnswer;

                if (Int32.TryParse(Console.ReadLine(), out userAnswer))
                {
                    switch (userAnswer) // switch to make menu
                    {
                        case 1:
                            Console.WriteLine();
                            Console.BackgroundColor = ConsoleColor.Green;
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.WriteLine("Color of triangle: " + mytriangle.GetColor());
                            CalcTriangle = false;
                            break;
                        case 2:
                            Console.WriteLine();
                            Console.BackgroundColor = ConsoleColor.Gray;
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.WriteLine("Triangle size of sides: A=" + sideA + ", B=" + sideB + ", C=" + sideC);
                            CalcTriangle = false;
                            break;
                        case 3:
                            Console.WriteLine();
                            Console.BackgroundColor = ConsoleColor.Gray;
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.WriteLine("Area: " + mytriangle.GetArea());
                            CalcTriangle = false;
                            break;
                        case 4:
                            Console.WriteLine();
                            Console.BackgroundColor = ConsoleColor.Gray;
                            Console.ForegroundColor = ConsoleColor.Black;                            
                            Console.WriteLine("Perimeter: " + mytriangle.GetPerimeter());
                            CalcTriangle = false;
                            break;
                        case 5:
                            Console.WriteLine();
                            Labb5_GrundernaOOP.GraphicsExtensions.DrawTriangle();
                            CalcTriangle = false;
                            break;
                        case 6:
                            Console.WriteLine();
                            Console.BackgroundColor = ConsoleColor.White;                        
                            Labb5_GetArea.Program.MainMenu();
                            CalcTriangle=false; 
                            break;                        
                        case 7:
                            Console.WriteLine();
                            Environment.Exit(-1);
                            CalcTriangle = false;
                            break;                          
                    }
                }
                if (CalcTriangle) //if to catch if user type other then numbers, return message to user.
                {
                    Console.WriteLine();
                    Console.WriteLine("You need to choose a number 1-8.");
                    Console.WriteLine();
                }
                Console.WriteLine();
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("|| Any button to choose again from menu ||");

                Console.ReadKey();
            } while (TriangleChoice);           
        }
        

    }
}
