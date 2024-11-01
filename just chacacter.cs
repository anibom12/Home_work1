using System;


        char key;
Console.WriteLine("Enter characters (press Enter to finish):");
do
{
    key = Console.ReadKey(true).KeyChar;
    if (!Char.IsDigit(key) && key != '\r')
    {
        Console.Write(key);
    }
} while (key != '\r');
