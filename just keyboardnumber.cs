using System.Numerics;

char key;
BigInteger number = 0;
Console.WriteLine("Enter numbers (press Enter to finish):");

do
{
    do
    {
        key = Console.ReadKey(true).KeyChar;
    } while (!Char.IsDigit(key) && key != '\r');
    if (key != '\r')
    {
        Console.Write(key);
        number = number * 10 + Convert.ToInt32(key.ToString());
    }
} while (key != '\r');
Console.WriteLine($"\n The number is {number}");