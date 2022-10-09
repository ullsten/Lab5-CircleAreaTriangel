using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Labb5_GrundernaOOP
{
    class GraphicsExtensions

    {
        public static void DrawCircle1() //Drawing circle pattern 1 with radius 5
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            
            int radius = 5;
            double console_ration = Convert.ToDouble(4.0 / 2.0);
            double a = console_ration * radius;
            double b = radius;
            string sign = "♥";
            
            
            Console.WriteLine(
                );
            for (int y = -radius; y <= radius; y++)
            {
                for (double x = -a; x <= a; x++)
                {
                    double d = (x / a) * (x / a) + (y / b) * (y / b);
                    if (d > 0.8 && d < 1.2)
                    {
                        Console.Write(sign);
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine("");
            }
            Console.ResetColor();
        }
        //---------------------------------------------------------
        public static void DrawCircle2() //Drawing circle pattern 2 with radius 6
        {
            Console.ForegroundColor = ConsoleColor.Blue;
           
            int radius = 6;
            double console_ration = Convert.ToDouble(4.0 / 2.0);
            double a = console_ration * radius;
            double b = radius;
            string sign = "♥";

            

            for (int y = -radius; y <= radius; y++)
            {
                for (double x = -a; x <= a; x++)
                {
                    double d = (x / a) * (x / a) + (y / b) * (y / b);
                    if (d > 0.8 && d < 1.2)
                    {
                        Console.Write(sign);
                    }
                    else
                    {
                        Console.Write(" ");
                    }

                }
                Console.WriteLine("");
            }
            Console.ResetColor();
        }
        //---------------------------------------------------------------------------
        public static void DrawTriangle() //Drawing triangle
        {
            //Nested Loop
            Console.ForegroundColor = ConsoleColor.Green;
            int val = 5;
            int i, j, k;
            for (i = 1; i <= val; i++)
            {
                for (j = 1; j <= val - i; j++)
                {
                     Console.Write(" ");  
                }
                for (k = 1; k <= i; k++)
                {
                    Console.Write("♥");
                }
                Console.WriteLine("");
            }
            
            Console.ResetColor();

        }
    }
}
