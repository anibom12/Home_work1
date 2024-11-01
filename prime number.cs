Console.WriteLine("Enter the first number: ");
string num1 = Console.ReadLine();
int num1new = Convert.ToInt32(num1);
Console.WriteLine("Enter the second number: ");
string num2 = Console.ReadLine();
int num2new = Convert.ToInt32(num2);
Console.WriteLine($"prime numbers between{num1new} and {num2new}:");

for (int i = num1new+1; i < num2new; i++)
{
    bool isPrime = true;
    if (i <=1)
    {
        isPrime = false;
    }
    else
    {
        for (int j = 2; j * j <= i; j++)
        {
            if (i % j == 0)
            {
                isPrime = false;
                break;
            }
        }
    }
    if (isPrime)
    {
        Console.WriteLine(i);
    }
}
