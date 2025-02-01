using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gondolatolvaso
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.SetWindowSize(100, 20);
            Random vel = new Random();
            ConsoleKeyInfo cki;
            int j = 15;

            for (int i = 1; i < 10; i++)
            {

                Console.Clear();
                Console.SetCursorPosition(j, i);
                System.Threading.Thread.Sleep(1);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("Számkitalálós játák! Találd ki a számot (1-100)");
                System.Threading.Thread.Sleep(1);
                j++;
            }
            System.Threading.Thread.Sleep(3000);

            do
            {
                Console.Clear();
                int kitalalando = vel.Next(1, 101);
                string uzenet = "";
                int tipp = 0;
                int tippSzam = 0;

                Console.ForegroundColor = ConsoleColor.Red;
                Console.SetCursorPosition(40, 8);
                Console.Write(6 - tippSzam + " db lehetőséged van/"+kitalalando);
               
                Console.ForegroundColor = ConsoleColor.White;


                do
                {
                    Console.SetCursorPosition(19, 5);
                    Console.Write("                ");
                    Console.SetCursorPosition(19, 5);

                    while (true)
                    {
                        //Console.Clear();
                        Console.SetCursorPosition(1, 5);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("Add meg a tipped: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.SetCursorPosition(40, 8);
                        Console.Write(6 - tippSzam + " db lehetőséged van");
                        Console.ForegroundColor = ConsoleColor.Green;
                        try
                        {
                            
                            Console.SetCursorPosition(19, 5);
                            tipp = int.Parse(Console.ReadLine());
                            if(tipp >= 1 && tipp<=100)
                            { break; }
                        }
                        catch { }
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Ne feledd 1-100");
                        System.Threading.Thread.Sleep(2000);
                        Console.Clear();
                    }
                    tippSzam++;

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.SetCursorPosition(40, 8);
                    Console.Write(6 - tippSzam + " tipped maradt");
                    Console.ForegroundColor = ConsoleColor.White;


                    if (tipp > kitalalando) uzenet = "A tipped túl nagy! ";
                    else if (tipp < kitalalando) uzenet = "A tipped túl kicsi! ";


                    Console.SetCursorPosition(1, 3);
                    Console.WriteLine(uzenet);

                } while (tipp != kitalalando && tippSzam < 6);

                if (tipp == kitalalando)
                {
                    Console.Clear();
                    int q = 33;
                    for (int i = 10; i < 19; i++)
                    {

                        Console.SetCursorPosition(q, i);
                        System.Threading.Thread.Sleep(1);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("*");
                        q++;
                    }

                    for (int i = 19; i > 9; i--)
                    {

                        Console.SetCursorPosition(q, i);
                        System.Threading.Thread.Sleep(1);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("*");
                        q++;
                    }
                    q = 43;
                    for (int i = 10; i < 19; i++)
                    {

                        Console.SetCursorPosition(q, i);
                        System.Threading.Thread.Sleep(1);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("*");
                        q++;
                    }

                    for (int i = 19; i > 9; i--)
                    {

                        Console.SetCursorPosition(q, i);
                        System.Threading.Thread.Sleep(1);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("*");
                        q++;
                    }
                    for (int i = 10; i < 20; i++)
                    {

                        Console.SetCursorPosition(66, i);
                        System.Threading.Thread.Sleep(1);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("*");

                    }

                    for (int i = 10; i < 20; i++)
                    {

                        Console.SetCursorPosition(71, i);
                        System.Threading.Thread.Sleep(1);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("*");

                    }
                    q = 72;
                    for (int i = 10; i < 20; i++)
                    {

                        Console.SetCursorPosition(q, i);
                        System.Threading.Thread.Sleep(1);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("*");
                        q++;
                    }
                    for (int i = 10; i < 20; i++)
                    {

                        Console.SetCursorPosition(82, i);
                        System.Threading.Thread.Sleep(1);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("*");

                    }

                    System.Threading.Thread.Sleep(1000);
                
                 }
                else uzenet = "De kis béna vagy! Próbáld újra!";
                Console.Clear();
                Console.SetCursorPosition(40, 8);
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(uzenet);
                System.Threading.Thread.Sleep(1000);

                
                Console.Clear();
                Console.SetCursorPosition(1, 7);
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Szeretnél mégegyet játszani (i/n)?");
            cki = Console.ReadKey(true);

        } while (cki.Key == ConsoleKey.I);







        }
    }
}
