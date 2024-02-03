/*
   The following code displays either heads or tails with a 50% chance for each outcome.
   It uses the Random class to generate a random value (0 or 1).
   The result is determined by checking if the generated value is 0 (heads) or 1 (tails).
   The code is designed to be concise, readable, and achieves the desired result in three lines.
*/

// Create an instance of the Random class to generate a value.
Random coin = new Random();

// Use the Next method to get a random integer (either 0 or 1).
int flip = coin.Next(0, 2);

// Display the result as either "heads" or "tails" based on the random value.
Console.WriteLine((flip == 0) ? "heads" : "tails");



