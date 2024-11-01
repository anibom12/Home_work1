Console.WriteLine("Enter the first number:");
string b1=Console.ReadLine();
int a1=Convert.ToInt32(b1);
Console.WriteLine("Enter the first number:");
string b2 = Console.ReadLine();
int a2 = Convert.ToInt32(b2);
Console.WriteLine("Enter the number you want to check in fibonacci:");
string n1 = Console.ReadLine();
int n = Convert.ToInt32(n1);
int a3 = a1 + a2;
if (n == a1 || n == a2 )
{
    Console.WriteLine("The number is in fibonacci sequence");
    return;
}

while (n >= a3)
{


    if (n == a3)
    {
        Console.WriteLine("The number is in fibonacci sequence");
        return;
 
    }
    a1 = a2;
    a2 = a3;
    a3 = a1 + a2;

}
Console.WriteLine("The number is not in fibonacci sequence");
   