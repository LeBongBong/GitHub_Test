using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using System.Threading;

namespace Github_Test
{
    internal class Program
    {
        static void Main(string[] args)
        {       
            ForegroundColor = ConsoleColor.Black;
            bool loop = true;
            while (loop == true)
            {
                BackgroundColor = ConsoleColor.Black;
                BackgroundColor = ConsoleColor.Red;
                WriteLine("     S     ");
                Thread.Sleep(100);
                BackgroundColor = ConsoleColor.Blue;
                WriteLine("     N     ");
                Thread.Sleep(100);
                BackgroundColor = ConsoleColor.Yellow;
                WriteLine("     A     ");
                Thread.Sleep(100);
                BackgroundColor = ConsoleColor.Green;
                WriteLine("     K     ");
                Thread.Sleep(100);
                BackgroundColor = ConsoleColor.Magenta;
                WriteLine("     E     ");
                Thread.Sleep(100);
                BackgroundColor = ConsoleColor.Cyan;
                WriteLine("     .     ");
                Thread.Sleep(100);
                BackgroundColor = ConsoleColor.DarkGreen;
                WriteLine("     .     ");
                Thread.Sleep(100);
            }
            
            
        }
    }
}
