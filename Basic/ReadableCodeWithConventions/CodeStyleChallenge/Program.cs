// given code 
string originalMessage = "The quick brown fox jumps over the lazy dog."; // note variable name has to be changed
// convert the message into a char array
char[] message = str.ToCharArray();  // same here 
// Reverse the chars
Array.Reverse(charMessage);
int x = 0;
// count the o's
foreach (char i in charMessage) { if (i == 'o') { x++; } }
// convert it back to a string
string new_message = new String(charMessage);
// print it out
Console.WriteLine(new_message);
Console.WriteLine($"'o' appears {x} times.");
