// given code
Random dice = new Random(); // new instance saved in dice
// call the method random.next on dice three times:
int roll1 = dice.Next(1,7); // with restriction parameter and save them in there respective var
int roll2 = dice.Next(1,7);
int roll3 = dice.Next(1,7);
// sum the three dice rolls and save the value into an integer variable named total.
int total = roll1 + roll2 + roll3;
// WriteLine() method to display the three values using string interpolation.
Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3}  = {total}");
// doubles" game feature + triplets by using else. and fixing the bug

if ((roll1 == roll2)|| (roll2 == roll3) ||(roll1 == roll3))
{
    if ((roll1 == roll2) && (roll2 == roll3)){
        Console.WriteLine("You rolled triples!  +6 bonus to total!");
        total += 6;
    }
    else
   {
    Console.WriteLine("You rolled doubles!  +2 bonus to total!");
        total += 2;
   }
}// nested
// If the player scores greater or equal to 16, they'll win a new car.
if (total >= 16)
{
    Console.WriteLine("You win a new car!");
}
else if (total >= 10) // If the player scores greater or equal to 10, they'll win a new laptop.
{
    Console.WriteLine(" You win a laptop!");
}
else if (total == 7) // If the player scores exactly 7, they'll win a trip.
{
    Console.WriteLine( " You won a trip! ");
   
}
else // Otherwise, the player wins a kitten.
{
    Console.WriteLine (" You won a kitten.");
}

