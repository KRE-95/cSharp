Random random = new Random();
int daysUntilExpiration = random.Next(12); // Random number between 0 and 11
int discountPercentage = 0;

// Display one message - the message will depend on other five rules.

// Rule 5: If the user's subscription has expired
if (daysUntilExpiration == 0)
{
    Console.WriteLine("Your subscription has expired.");
}
// Rule 4: If the user's subscription will expire in one day
else if (daysUntilExpiration == 1) 
{
    Console.WriteLine("Your subscription expires within a day!");
    discountPercentage = 20;
}
// Rule 3: If the user's subscription will expire in five days or less
else if (daysUntilExpiration <= 5) 
{
    Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.");
    discountPercentage = 10;
}
// Rule 2: If the user's subscription will expire in 10 days or less
else if (daysUntilExpiration <= 10) 
{
    Console.WriteLine("Your subscription will expire soon. Renew now!");
}
// Display discount message if discountPercentage is greater than 0
if (discountPercentage > 0) 
{
    Console.WriteLine($"Renew now and save {discountPercentage}%.");
}

