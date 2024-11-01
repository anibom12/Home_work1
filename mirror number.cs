using System.ComponentModel.Design;

Console.WriteLine("Enter the first number: ");
string num1 = Console.ReadLine();
int num1new = Convert.ToInt32(num1);
Console.WriteLine("Enter the second number: ");
string num2 = Console.ReadLine();
int num2new = Convert.ToInt32(num2);
if (num1new > num2new)
{
    Console.WriteLine("Second number should be greater than the first number");
    
}

Console.WriteLine($"mirror numbers between {num1new} and {num2new}:");
for (int i = num1new+1; i < num2new; i++)
{
    if (i <10)
    {
        continue;
    }
    int number = i;
    int reverse = 0;
    int original = number;
    while (number > 0)
    {
        reverse = reverse * 10 + number % 10;
        number /= 10;

        if (original == reverse)
        {
            Console.WriteLine(original);


        }
        
    }  
}