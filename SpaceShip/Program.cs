

static void PalyaKirajzolasa()
{
    Console.SetCursorPosition(1, 1);
    Console.CursorVisible = false;

    Console.Write("╔");

    for (int i = 0; i < 26; i++)
    {
        Console.Write("═");
    }
    Console.Write("╗");

    for (int i = 2; i < 10; i++)
    {
        Console.SetCursorPosition(1, i); Console.Write("║");
        Console.SetCursorPosition(28, i); Console.Write("║");
    }

    Console.SetCursorPosition(1, 10);
    Console.Write("╚");
    for (int i = 0; i < 26; i++)
    {
        Console.Write("═");
    }
    Console.Write("╝");

    KiHajo(13, 9);
}


static void KiHajo(int x, int y) 
{
    Console.SetCursorPosition(x, y);
    Console.Write(" ░▒▓▒░ ");
}


PalyaKirajzolasa();

int x = 13; //oszlop

ConsoleKeyInfo gomb;

do
{
    gomb = Console.ReadKey(true);
    if (gomb.Key == ConsoleKey.RightArrow) x++;
    if (gomb.Key == ConsoleKey.LeftArrow) x--;
    if (x < 2) x = 2;
    if (x > 21) x = 21;
    KiHajo(x, 9); 

} while (gomb.Key != ConsoleKey.Escape);


//var cki = Console.ReadKey();
