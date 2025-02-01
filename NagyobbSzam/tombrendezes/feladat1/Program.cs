using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace feladat1
{
    internal class Program
    {
        static void Main(string[] args)
        {
           

            int szam1 = 0;
            do

            {
                while (true)
                {
                    Console.Write("Hány számot szeretne beolvasni:  ");
                    try
                    {
                        szam1 = int.Parse(Console.ReadLine());

                        break;
                    }
                    catch { }

                }
                if (szam1 < 2)
                {
                    Console.WriteLine("Legalább két számot kérek");
                }
                else
                {
                    Console.WriteLine("Jöhet a beolvasás ");
                }


            } while (szam1 < 2);
            
            Console.Clear();

            int[] tomb = new int[szam1];
            int szamlalo = 0;
            int szam2;
            while (szamlalo < szam1)
            {

                while (true)
                {
                    Console.Write("Kérem a {0} szamot:  ", (szamlalo + 1));
                    try
                    {
                        szam2 = int.Parse(Console.ReadLine());

                        break;
                    }
                    catch { }

                }
                tomb[szamlalo] = szam2;
                szamlalo++;

            }
            Console.WriteLine();
            Console.WriteLine("Befejeztük");
            Console.WriteLine();
            for (int i = 0; i < tomb.Length; i++)
                Console.Write("{0}, ", tomb[i]);
            Console.WriteLine("egy bill lenyomása után rendezzük emelkedő sorrendbe a számokat");
            Console.ReadKey();

            var minimum = MinimumRendez(tomb);
            TombKiir(minimum);

        }
        public static int[] MinimumRendez(int[] bemenet)
        {
            int[] tomb = new int[bemenet.Length];
            Array.Copy(bemenet, tomb, bemenet.Length);
            for (int i = 0; i < tomb.Length; i++)
            {
                var minimum = i;
                for (int j = i; j < tomb.Length; j++)
                {
                    if (tomb[j] < tomb[minimum]) minimum = j;
                }
                if (tomb[i] != tomb[minimum])
                {
                    var tmp = tomb[i];
                    tomb[i] = tomb[minimum];
                    tomb[minimum] = tmp;
                }
            }
            return tomb;
        }

        static void TombKiir(int[] tomb)
        {
            foreach (var elem in tomb)
            {
                Console.Write("{0}, ", elem);
            }
            Console.WriteLine();
        }



    }
}
