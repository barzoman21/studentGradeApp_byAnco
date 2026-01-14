Random random = new Random();
int daysLeft = random.Next(12);
int discountPercentage = 0;

Console.WriteLine(daysLeft);


if (daysLeft >=6 && daysLeft <=10)
{
    Console.WriteLine("Your subscription will expire soon. Wanna renew?");
}

else if (daysLeft >=2 && daysLeft<=5)
    {
        discountPercentage = 10;
        Console.WriteLine($"Your subscription expires in {daysLeft} days.");
        Console.WriteLine($"Renew now and save {discountPercentage}!");
    }

else if (daysLeft ==1)
{
    discountPercentage = 20;
    Console.WriteLine($"Your subscription expires within a day!");
    Console.WriteLine($"Renew now and save {discountPercentage}!");
}

else if (daysLeft == 0)
{
    Console.WriteLine("Your subscription has ended. Visit our Website to start a new subscription");
}

else
{
    Console.WriteLine("Did nothin");
}