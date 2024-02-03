// variable
string permission = "Admin|Manager";
int level = 55;

// The business rules is complex - use if-else statement

string outputMessage;
if (permission.Contains("Admin") && level > 55) 
{
    outputMessage = "Welcome, Super Admin user. ";
}
else if (permission.Contains("Admin") && level <= 55) 
{
    outputMessage = "Welcome, Admin user";
}
else if (permission.Contains("Manager") && level >= 20)
{
     outputMessage = "Contact an Admin for access.";
}
else if (permission.Contains("Manager") && level < 20) 
{
    outputMessage = "You do not have sufficient privileges.";
}
else {
    outputMessage = "You do not have sufficient privileges.";
}

Console.WriteLine(outputMessage);