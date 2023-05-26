using System;
using System.Collections.Generic;

class Menu
{
    //desenho no console 
    public static void DrawScreen()
    {
        Console.Clear();
        Console.Write("+");
        for (int i = 0; i < 31; i++) // digita linhas de (-) com (+) no começo e no fim  
        {
            Console.Write("-");
        }

        Console.Write("+");
        Console.Write("\n");

        for (int lines = 0; lines <= 8; lines++) // digita (|)  linhas  
        {
            Console.Write("|");
            for (int i = 0; i <= 30; i++)
                Console.Write(" ");

            Console.Write("|");
            Console.Write("\n");
        }

        Console.Write("+");
        for (int i = 0; i < 31; i++) // digita linhas de (-) com (+) no começo e no fim 
        {
            Console.Write("-");
        }

        Console.Write("+");
        Console.Write("\n");


        Console.SetCursorPosition(9, 1);
        Console.WriteLine("RedeCodeCeuma");
        Console.SetCursorPosition(1, 3);
        Console.WriteLine("===============================");
    }
    public static void Screen()
    {
        Console.Clear();
        Console.Write("+");
        for (int i = 0; i < 31; i++) // digita linhas de (-) com (+) no começo e no fim  
        {
            Console.Write("-");
        }

        Console.Write("+");
        Console.Write("\n");

        for (int lines = 0; lines <= 18; lines++) // digita (|)  linhas  
        {
            Console.Write("|");
            for (int i = 0; i <= 30; i++)
                Console.Write(" ");

            Console.Write("|");
            Console.Write("\n");
        }

        Console.Write("+");
        for (int i = 0; i < 31; i++) // digita linhas de (-) com (+) no começo e no fim 
        {
            Console.Write("-");
        }

        Console.Write("+");
        Console.Write("\n");


        Console.SetCursorPosition(9, 1);
        Console.WriteLine("RedeCodeCeuma");
        Console.SetCursorPosition(1, 3);
        Console.WriteLine("===============================");
    }
    public static void Draw()
    {
        Console.Clear();
        Console.Write("+");
        for (int i = 0; i < 31; i++) // digita linhas de (-) com (+) no começo e no fim  
        {
            Console.Write("-");
        }

        Console.Write("+");
        Console.Write("\n");

        for (int lines = 0; lines <= 8; lines++) // digita (|)  linhas  
        {
            Console.Write("|");
            for (int i = 0; i <= 30; i++)
                Console.Write(" ");

            Console.Write("|");
            Console.Write("\n");
        }

        Console.Write("+");
        for (int i = 0; i < 31; i++) // digita linhas de (-) com (+) no começo e no fim 
        {
            Console.Write("-");
        }

        Console.Write("+");
        Console.Write("\n");

        Console.SetCursorPosition(9, 1);
        Console.WriteLine("RedeCodeCeuma");
        Console.SetCursorPosition(1, 3);
        Console.WriteLine("===============================");
    }
}