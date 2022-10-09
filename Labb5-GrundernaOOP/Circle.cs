using Labb5_GrundernaOOP;
using System;
using System.Collections.Generic;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace Labb5_GetArea
{
    class Circle
    {
        private double pi = 3.141f;
        private double radius;
        private int diameter;
        private string ColorName;

        //Constructor with parameter
        public Circle(string ColorName)
        {
            this.ColorName = ColorName;
        }
        public string GetColor()
        {
            return this.ColorName;
        }
        public double GetArea() //Calculate area
        {
            return pi * Math.Pow(radius, 2);
        }
        public void SetRadius(int r)
        {
            radius = r;
        }
        
        public double GetRadius()
        { 
            return radius;
        }                
        public double GetPerimeter() //Calculate Perimeter
        {
            return 2 * pi * radius;
        }

        public float GetVolumeSphere() //Calculate volume of sphere
        {            
            float volume = 0.0F;
            volume = (float)(4.0 / 3 * pi * radius * radius * radius);
            return volume;            
        }        
       
        public double GetDiameter() // diameter calculation
        {
            return radius + radius;
        }
        public void SetDiameter(int d)
        {
            diameter = d;
        }

                
        public static void CircleMenu() //Menu for circles in do-while loop
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Circle myCircle1 = new Circle("Yellow");
            myCircle1.SetRadius(5);
            myCircle1.GetColor();
            Circle myCircle2 = new Circle("Blue");
            myCircle2.SetRadius(6);
            myCircle2.GetColor();

            bool CircleChoice = true;
            do
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Clear();

                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("Circ ver.1.0");
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("|-------------------------------------|");
                Console.WriteLine("|          Circle Calculation         |");
                Console.WriteLine("|-------------------------------------|");
                Console.WriteLine();
                Console.WriteLine("Select calculation from the list.");
                Console.WriteLine();
                Console.BackgroundColor = ConsoleColor.Gray;
                Console.WriteLine("|Circle One|");
                Console.ResetColor();
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine();
                Console.WriteLine("[0]Print all info");
                Console.WriteLine("[1]Color of circle");
                Console.WriteLine("[2]Radius");
                Console.WriteLine("[3]Diameter");
                Console.WriteLine("[4]Area");
                Console.WriteLine("[5]Perimeter");
                Console.WriteLine("[6]Volume sphere");
                Console.WriteLine("[7]Draw circle one");
                Console.WriteLine();
                Console.BackgroundColor = ConsoleColor.Gray;
                Console.WriteLine("|Circle Two|");
                Console.ResetColor();
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine();
                Console.WriteLine("[8]Print all info");
                Console.WriteLine("[9]Color of circle");
                Console.WriteLine("[10]Radius");
                Console.WriteLine("[11]Diameter");
                Console.WriteLine("[12]Area");
                Console.WriteLine("[13]Perimeter");
                Console.WriteLine("[14]Volume sphere");
                Console.WriteLine("[15]Draw circle two");
                Console.WriteLine();
                Console.WriteLine("[16]Main menu");
                Console.WriteLine("[17]Exit program");

                bool CalcCircle = true;
                int userAnswer;

                if (Int32.TryParse(Console.ReadLine(), out userAnswer))
                {
                    switch (userAnswer) //switch to make menu
                    {
                        case 0:
                            Console.BackgroundColor= ConsoleColor.Gray;
                            Console.WriteLine();
                            Console.WriteLine("Color of circle one: " + myCircle1.GetColor());
                            Console.WriteLine("Radius: " + myCircle1.GetRadius());
                            Console.WriteLine("Diameter: " + myCircle1.GetDiameter());
                            Console.WriteLine("Area: " + myCircle1.GetArea());
                            Console.WriteLine("Perimeter: " + myCircle1.GetPerimeter());
                            Console.WriteLine("Volume of sphere: " + myCircle1.GetVolumeSphere());
                            CalcCircle = false;
                            break;
                        case 1:
                            Console.WriteLine();
                            Console.BackgroundColor = ConsoleColor.DarkYellow;
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.WriteLine("Color of circle one: " + myCircle1.GetColor());
                            CalcCircle = false;
                            break;
                        case 2:
                            Console.WriteLine();
                            Console.BackgroundColor = ConsoleColor.Gray;                            
                            Console.WriteLine("Radius: " + myCircle1.GetRadius());
                            CalcCircle = false;
                            break;
                        case 3:
                            Console.WriteLine();
                            Console.BackgroundColor = ConsoleColor.Gray;                            
                            Console.WriteLine("Diameter: " + myCircle1.GetDiameter());
                            CalcCircle = false;
                            break;
                        case 4:
                            Console.WriteLine();
                            Console.BackgroundColor = ConsoleColor.Gray;                            
                            Console.WriteLine("Area: " + myCircle1.GetArea());
                            CalcCircle = false;
                            break;
                        case 5:
                            Console.WriteLine();
                            Console.BackgroundColor = ConsoleColor.Gray;                            
                            Console.WriteLine("Perimeter: " + myCircle1.GetPerimeter());
                            CalcCircle = false;
                            break;
                        case 6:
                            Console.WriteLine();
                            Console.BackgroundColor = ConsoleColor.Gray;                            
                            Console.WriteLine("Volume of sphere: "+ myCircle1.GetVolumeSphere());
                            CalcCircle = false;
                            break;
                        case 7:
                            Console.WriteLine();                          
                            Console.WriteLine();
                            Labb5_GrundernaOOP.GraphicsExtensions.DrawCircle1();
                            CalcCircle = false;
                            break;
                        case 8:
                            Console.BackgroundColor = ConsoleColor.Gray;
                            Console.WriteLine();
                            Console.WriteLine("Color of circle two: " + myCircle2.GetColor());
                            Console.WriteLine("Radius: " + myCircle2.GetRadius());
                            Console.WriteLine("Diameter: " + myCircle2.GetDiameter());
                            Console.WriteLine("Area: " + myCircle2.GetArea());
                            Console.WriteLine("Perimeter: " + myCircle2.GetPerimeter());
                            Console.WriteLine("Volume of sphere: " + myCircle2.GetVolumeSphere());
                            CalcCircle = false;
                            break;
                        case 9:
                            Console.WriteLine();
                            Console.BackgroundColor = ConsoleColor.Blue;
                            Console.WriteLine("Color of circle two: " + myCircle2.GetColor());
                            CalcCircle = false;
                            break;
                        case 10:
                            Console.WriteLine();
                            Console.BackgroundColor = ConsoleColor.Gray;
                            Console.WriteLine("Radius: " + myCircle2.GetRadius());
                            CalcCircle = false;
                            break;
                        case 11:
                            Console.WriteLine();
                            Console.BackgroundColor = ConsoleColor.Gray;
                            Console.WriteLine("Diameter: " + myCircle2.GetDiameter());
                            CalcCircle = false;
                            break;
                        case 12:
                            Console.WriteLine();
                            Console.BackgroundColor = ConsoleColor.Gray;
                            Console.WriteLine("Area: " + myCircle2.GetArea());
                            CalcCircle = false;
                            break;
                        case 13:
                            Console.WriteLine();
                            Console.BackgroundColor = ConsoleColor.Gray;
                            Console.WriteLine("Perimeter: " + myCircle2.GetPerimeter());
                            CalcCircle = false;
                            break;
                        case 14:
                            Console.WriteLine();
                            Console.BackgroundColor = ConsoleColor.Gray;
                            Console.WriteLine("|Volume of sphere: " + myCircle2.GetVolumeSphere()+"|");
                            CalcCircle = false;
                            break;
                        case 15:
                            Console.WriteLine();
                            Console.BackgroundColor = ConsoleColor.White;
                            Labb5_GrundernaOOP.GraphicsExtensions.DrawCircle2();
                            CalcCircle = false;
                            break;
                        case 16:
                            Console.WriteLine();
                            Console.BackgroundColor = ConsoleColor.White;
                            Labb5_GetArea.Program.MainMenu();
                            CalcCircle = false;
                            break;
                        case 17:
                            Console.WriteLine();
                            Environment.Exit(-1);
                            CalcCircle = false;
                            break;
                    }
                }
                if (CalcCircle) //if to catch if user type other then numbers, return message to user.
                {                    
                    Console.WriteLine();
                    Console.WriteLine("You need to choose a number 0-17.");
                    Console.WriteLine();
                }
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine();
                Console.WriteLine();                
                Console.WriteLine("|| Any button to choose again from menu ||");
                Console.ReadKey();
            } while (CircleChoice);
        }        
    }
}
