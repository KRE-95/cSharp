// given code 
string originalMessage = "The quick brown fox jumps over the lazy dog."; // note variable name has to be changed
// convert the message into a char array
char[] message = str.ToCharArray();  // same here 
// Reverse the chars
Array.Reverse(charMessage);
int x = 0;
// count the o's
foreach (char i in message) { if (i == 'o') { x++; } }
// convert it back to a string
string new_Message = new String(message); // same here variable name
// print it out
Console.WriteLine(new_Message);
Console.WriteLine($"'o' appears {x} times.");
