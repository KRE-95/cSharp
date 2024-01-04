/* This code reverse a message, counts the number of times
a particular character appears, then prints the results to the console  */
string originalMessage = "The quick brown fox jumps over the lazy dog."; 

char[] message = str.ToCharArray();   
Array.Reverse(charMessage);

int x = 0;

foreach (char i in message) 
{ 
    if(i == 'o') 
    {
         x++; 
    } 
 }

string new_Message = new String(message); 

Console.WriteLine(new_Message);
Console.WriteLine($"'o' appears {x} times.");
