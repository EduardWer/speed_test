using System;
namespace Speedtest_my_il;



internal class Text_in
{
    public void Text_Soll(string text)
    {

        Console.SetCursorPosition(0, 0);
        Console.CursorVisible = true;

        Console.Clear();
        Console.WriteLine(text);


        Console.ForegroundColor = ConsoleColor.Green;

        int line = 0;
        for (int i = 0; i < text.Length; i++)
        {
            ConsoleKeyInfo keyInfo = Console.ReadKey(true);

            if (keyInfo.Key == ConsoleKey.Enter)
            {
                line++;
                Console.SetCursorPosition(0, line);
            }
            else
            {
                Console.Write(keyInfo.KeyChar);
            }
        }

        Console.ResetColor();
    }

}

