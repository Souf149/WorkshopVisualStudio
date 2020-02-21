using System;
using System.Drawing;
using System.Threading;
using Colorful;
using Console = Colorful.Console;

namespace WorkshopExample
{
    class Program
    {
        static Random rng = new Random();

        static Color[] colors =
        {
            Color.Red,
            Color.Blue,
            Color.LightSeaGreen,
            Color.Aqua,
            Color.White
        };

        static void Main(string[] args)
        {

            Console.Write("Starting up");
            for (int i = 0; i < 12; i++)
            {
                Sleep(200);
                Console.Write(".");
            }

            for (int i = 0; i < 4; i++)
            {
                Sleep(10);
                Console.Write(".");
            }



            Console.WriteLine("\nDone!");
            Sleep(1000);

            Console.ResetColor();
            Console.BackgroundColor = Color.Black;
            Console.ReplaceColor(Color.Black, Color.FromArgb(0, 30, 0));


            while (true)
            {
                for (int i = 0; i < 3; i++)
                {
                    Sleep(300);
                    Console.Write(".");
                }
                Console.Clear();

                Console.WriteLine("Give me your message that you want to see in color");

                string inp = Console.ReadLine();

                if (inp == "stop")
                    break;

                Console.SetCursorPosition(0, Console.CursorTop - 1);
                RainbowText(inp);
                

                
                

                
            }

            Console.WriteLine("Until next time!", Color.Red);
            

            


        }

        static void RainbowText(string inp)
        {
            foreach (char c in inp) {
                Console.Write(c, colors[rng.Next(0, colors.Length - 1)]);
            }
            Console.Write("\n");
        }

        static void Sleep(int x)
        {
            Thread.Sleep(x);
        }
    }
}
