
using System.Collections.Generic;

List<string> phoneNumbers = new List<string>();

Console.WriteLine("What's your name?");
string a = Console.ReadLine();

Console.WriteLine("Enter your home phone number(with city code):");
string n1 = Console.ReadLine();
phoneNumbers.Add(n1);

Console.WriteLine("Enter your mobile phone number:");
string n2 = Console.ReadLine();
phoneNumbers.Add(n2);

Console.WriteLine("Enter your father's mobile phone number:");
string n3 = Console.ReadLine();
phoneNumbers.Add(n3);

Console.WriteLine("Enter your mother's mobile phone number:");
string n4 = Console.ReadLine();
phoneNumbers.Add(n4);

Console.WriteLine("Enter your emergency mobile phone number:");
string n5 = Console.ReadLine();
phoneNumbers.Add(n5);

Console.WriteLine($"Hello {a}.  your information that you entered is :\n Home phone number: {n1}\n Your mobile phone number: {n2}\n Father's mobile phone number: {n3}\n Mother's mobile phone number: {n4}\n Emergency mobile phone number: {n5}");

Console.WriteLine(" A valid number is one that has ten digits,start with zero ,and contain at least two different digits.\n Valid numbers:");
foreach (string s in phoneNumbers)
{
    if (s.Length == 10 && s[0] == '0')
    {
        bool differentDigit = false;
        for (int i = 1; i < s.Length; i++)
        {
            if (s[i] != s[0])
            {
                differentDigit = true;
                break;
            }
        }

        if (differentDigit)
        {
            Console.WriteLine(s);
        }
    }
}