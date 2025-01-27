Console.Write("Szám 1: ");
var szam1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Szám 2: ");
var szam2 = Convert.ToDouble(Console.ReadLine());

//if (szam1 > szam2)
//{
//    Console.WriteLine("A nagyobb szám " + szam1);
//}

//else
//    Console.WriteLine("A nagyobb szám " + szam2);

//double nagyobb;

//if (szam1 > szam2) nagyobb = szam1;
//else nagyobb = szam2;


//nagyobb = szam1>szam2?szam1:szam2;
Console.WriteLine("A nagyobb: "+ (szam1 > szam2 ? szam1 : szam2));
//Console.WriteLine("A nagyobb: " + nagyobb);