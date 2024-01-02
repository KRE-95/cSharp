// Dice example - overloading
Random dice = new Random(); // instance 
int roll1 = dice.Next()  // no parameter 
int roll2 = dice.Next(101); // one parameter
int roll3 = dice.Next(50, 101); // two parameter 50 - 101

// sense we are not going to add numbers will use interpol litral:
Console.WriteLine($"First roll: {roll1}");
Console.WriteLine($"Second roll: {roll2}");
Console.WriteLine($"Third roll: {roll3}");

