Console.WriteLine("Is it raining today? (yes/no)");
string rain = Console.ReadLine();

if (rain == "yes")
{
    Console.WriteLine("Do you have an umbrella? (yes/no)");
    string umbrella = Console.ReadLine();

    if (umbrella == "yes")
    {
        Console.WriteLine("Are you going to take your umbrella with you? (yes/no)");
        string takeUmbrella = Console.ReadLine();

        if (takeUmbrella == "yes")
        {
            Console.WriteLine("Do you feel like going for a walk? (yes/no)");
            string walk = Console.ReadLine();

            if (walk == "yes")
            {
                Console.WriteLine("Go for a walk.");
            }
            else
            {
                Console.WriteLine("Stay home and read a book.");
            }
        }
        else
        {
            Console.WriteLine("Do you have a raincoat? (yes/no)");
            string raincoat = Console.ReadLine();

            if (raincoat == "yes")
            {
                Console.WriteLine("Wear your raincoat.");
            }
            else
            {
                Console.WriteLine("Stay home.");
            }
        }
    }
    else
    {
        Console.WriteLine("Do you have specific plans to go out? (yes/no)");
        string plan = Console.ReadLine();

        if (plan == "yes")
        {
            Console.WriteLine("Do you have a car? (yes/no)");
            string car = Console.ReadLine();

            if (car == "yes")
            {
                Console.WriteLine("Drive your car.");
            }
            else
            {
                Console.WriteLine("It's better to cancel your plans.");
            }
        }
        else
        {
            Console.WriteLine("Stay home and drink tea.");
        }
    }
}
else
{
    Console.WriteLine("Is it windy? (yes/no)");
    string wind = Console.ReadLine();

    if (wind == "yes")
    {
        Console.WriteLine("Do you have heavy objects outside? (yes/no)");
        string heavy = Console.ReadLine();

        if (heavy == "yes")
        {
            Console.WriteLine("Are you planning to secure them? (yes/no)");
            string secure = Console.ReadLine();

            if (secure == "yes")
            {
                Console.WriteLine("Go out and secure them.");
            }
            else
            {
                Console.WriteLine("It's better to do it soon.");
            }
        }
        else
        {
            Console.WriteLine("Do you feel like going out? (yes/no)");
            string goOut = Console.ReadLine();

            if (goOut == "yes")
            {
                Console.WriteLine("Go for a walk.");
            }
            else
            {
                Console.WriteLine("Stay home and relax.");
            }
        }
    }
    else
    {
        Console.WriteLine("Is it sunny? (yes/no)");
        string sun = Console.ReadLine();

        if (sun == "yes")
        {
            Console.WriteLine("Do you want to go for a swim? (yes/no)");
            string swim = Console.ReadLine();

            if (swim == "yes")
            {
                Console.WriteLine("Go to the pool.");
            }
            else
            {
                Console.WriteLine("Do you have specific plans? (yes/no)");
                string specialPlan = Console.ReadLine();

                if (specialPlan == "yes")
                {
                    Console.WriteLine("Go ahead with your plans.");
                }
                else
                {
                    Console.WriteLine("Watch a movie.");
                }
            }
        }
        else
        {
            Console.WriteLine("Do you feel like exercising? (yes/no)");
            string workout = Console.ReadLine();

            if (workout == "yes")
            {
                Console.WriteLine("Go exercise.");
            }
            else
            {
                Console.WriteLine("Stay home and cook a delicious meal.");
            }
        }
    }
}