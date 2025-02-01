// See https://aka.ms/new-console-template for more information

static void PalyaKirajzolasa()
{
    Console.BackgroundColor = ConsoleColor.Blue;
    Console.Clear();
    Console.SetCursorPosition(1, 1);
    Console.Write("╔");
    for (int i = 0; i < 26; i++) Console.Write("═");

    Console.Write("╗");

    for (int i = 2; i < 10; i++)
    {
        Console.SetCursorPosition(1, i);
        Console.Write("║");
        Console.SetCursorPosition(28, i);
        Console.Write("║");
    }
    Console.SetCursorPosition(1, 10);
    Console.Write("╚");
    for (int i = 0; i < 26; i++) Console.Write("═");
    Console.Write("╝");
    
    int m = 21;
    int z = 9;
    for (int j = 2; j < 10; j++)
    {
        for (int i = z; i <= m; i++)
        {
            Console.SetCursorPosition(i, j);
            Console.Write("#");
        }
        m--; z++;
    }
    
    
    Console.CursorVisible = false;
    KiHajo(13, 9);

}



static void KiHajo(int x, int y)
{
    Console.SetCursorPosition(x, y);
    Console.Write(" XWX ");
   
}



PalyaKirajzolasa();
int x = 13;
int y = 0;


ConsoleKeyInfo gomb;
do
{
    gomb =Console.ReadKey(true);
    if (gomb.Key == ConsoleKey.RightArrow) x++;
    if (gomb.Key == ConsoleKey.LeftArrow) x--;
    if (gomb.Key != ConsoleKey.LeftArrow || gomb.Key != ConsoleKey.RightArrow) x = x+0; 
    if (x < 2) x = 2;
    if (x > 23) x = 23;
    if (gomb.Key == ConsoleKey.Spacebar)
    {
        
        Console.Beep(300,200);
        y = 9;
        for (int i = 0; i < 7; i++)
        {
           
            y--;
            Console.SetCursorPosition(x+2, y);
            Console.WriteLine("*");
            System.Threading.Thread.Sleep(100);
            Console.SetCursorPosition(x + 2, y);
            Console.WriteLine(" ");
        }

    }

    
    KiHajo(x, 9);
    
} while (gomb.Key != ConsoleKey.Escape);





