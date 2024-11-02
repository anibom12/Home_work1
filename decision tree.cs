Console.WriteLine("Is it raining today? (yes/no)");
string rain = Console.ReadLine();

if (rain.ToLower() == "yes")
{
    Console.WriteLine("Do you have an umbrella? (yes/no)");
    string umbrella = Console.ReadLine();

    if (umbrella.ToLower() == "yes")
    {
        Console.WriteLine("Are you going to take your umbrella with you? (yes/no)");
        string takeUmbrella = Console.ReadLine();

        if (takeUmbrella.ToLower() == "yes")
        {
            Console.WriteLine("Do you feel like going for a walk? (yes/no)");
            string walk = Console.ReadLine();

            if (walk.ToLower() == "yes")
            {
                Console.WriteLine("Go for a walk.");
            }
            else if (walk.ToLower() == "no")
            {
                Console.WriteLine("Stay home and read a book.");
            }
            else
            {
                Console.WriteLine("Wrong answer !");

            }
        }
        else if(takeUmbrella.ToLower() == "no") 
        {
            Console.WriteLine("Do you have a raincoat? (yes/no)");
            string raincoat = Console.ReadLine();
                

        
            if (raincoat.ToLower() == "yes")
            {
                Console.WriteLine("Wear your raincoat.");
            }
            else if(raincoat.ToLower() == "no")
            {
                Console.WriteLine("Stay home.");
            }
            else
            {
                Console.WriteLine("Wrong answer !");

            }

        }
        else
        {
            Console.WriteLine("Wrong answer !");

        }
    }
    else if(umbrella.ToLower() == "no") 
    {
        Console.WriteLine("Do you have specific plans to go out? (yes/no)");
        string plan = Console.ReadLine();
    

        if (plan.ToLower() == "yes")
        {
            Console.WriteLine("Do you have a car? (yes/no)");
            string car = Console.ReadLine();

            if (car.ToLower() == "yes")
            {
                Console.WriteLine("Drive your car.");
            }
            else if (car.ToLower() == "no")
            {
                Console.WriteLine("It's better to cancel your plans.");
            }
            else
            {
                Console.WriteLine("Wrong answer !");

            }
        }  
        else if(plan.ToLower() == "no")
        {
            Console.WriteLine("Stay home and drink tea.");
        }
        else
        {
            Console.WriteLine("Wrong answer !");

        }
    }
    else
    {
       Console.WriteLine("Wrong answer !");

    }
}

else if(rain.ToLower() == "no") 
{
    Console.WriteLine("Is it windy? (yes/no)");
    string wind = Console.ReadLine();

    if (wind.ToLower() == "yes")
    {
        Console.WriteLine("Do you have heavy objects outside? (yes/no)");
        string heavy = Console.ReadLine();

        if (heavy.ToLower() == "yes")
        {
            Console.WriteLine("Are you planning to secure them? (yes/no)");
            string secure = Console.ReadLine();

            if (secure.ToLower() == "yes")
            {
                Console.WriteLine("Go out and secure them.");
            }
            else if(secure.ToLower() == "no")
            {
                Console.WriteLine("It's better to do it soon.");
            }
            else
            {
                Console.WriteLine("Wrong answer !");

            }

        }
        else if(heavy.ToLower() == "no")
        {
            Console.WriteLine("Do you feel like going out? (yes/no)");
            string goOut = Console.ReadLine();

            if (goOut.ToLower() == "yes")
            {
                Console.WriteLine("Go for a walk.");
            }
            else if(goOut.ToLower() == "No")
            {
                Console.WriteLine("Stay home and relax.");
            }
            else
            {
                Console.WriteLine("Wrong answer !");

            }
        }
        else
        {
            Console.WriteLine("Wrong answer !");

        }
    }
    else if(wind.ToLower() == "no")
    {
        Console.WriteLine("Is it sunny? (yes/no)");
        string sun = Console.ReadLine();

        if (sun.ToLower() == "yes" )
        {
            Console.WriteLine("Do you want to go for a swim? (yes/no)");
            string swim = Console.ReadLine();

            if (swim.ToLower() == "yes")
            {
                Console.WriteLine("Go to the pool.");
            }
            else if(swim.ToLower() == "no")
            {
                Console.WriteLine("Do you have specific plans? (yes/no)");
                string specialPlan = Console.ReadLine();
            
                if (specialPlan.ToLower() == "yes")
                {
                    Console.WriteLine("Go ahead with your plans.");
                }
                else if(specialPlan.ToLower() == "no")
                {
                    Console.WriteLine("Watch a movie.");
                }
                else
                {
                    Console.WriteLine("Wrong answer !");

                }
            }
            else
            {
                Console.WriteLine("Wrong answer !");

            }
        }
        else if(sun.ToLower() == "no")
        {
            Console.WriteLine("Do you feel like exercising? (yes/no)");
            string workout = Console.ReadLine();

            if (workout.ToLower() == "yes" )
            {
                Console.WriteLine("Go exercise.");
            }
            else if (workout.ToLower() == "no")
            {
                Console.WriteLine("Stay home and cook a delicious meal.");
            }
            else
            {
                Console.WriteLine("Wrong answer !");

            }
        }
        else
        {
            Console.WriteLine("Wrong answer !");

        }
    }
    else
    {
        Console.WriteLine("Wrong answer !");

    }
}
else
{
        Console.WriteLine("Wrong answer !");
}