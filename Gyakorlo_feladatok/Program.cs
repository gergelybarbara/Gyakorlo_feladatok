
Console.Write("Kérem az első számot: ");
var szoveg = Console.ReadLine();
var szam1 = Convert.ToDouble(szoveg);

Console.Write("Kérem a második számot:");
var szam2 = Convert.ToDouble(Console.ReadLine() );

var osszeg = szam1 + szam2;
Console.WriteLine("A két szám összege: " + osszeg);
Console.WriteLine("A két szám különbsége: " + (szam1 - szam2));
Console.WriteLine("A két szám szorzata: " + (szam1 * szam2));
Console.WriteLine("A két szám hányadosa: " + (szam1 / szam2));


//byte a = byte.MaxValue;
//byte b = byte.MaxValue;
//byte c = (byte)(a + b);
//Console.WriteLine("a:" + a + ",b:" + b + "="+c);
