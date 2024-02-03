/*
   Business Rules:

   1. If the user is a Super Admin (Admin with level greater than 55), output: "Welcome, Super Admin user."
   2. If the user is an Admin with level 55 or less, output: "Welcome, Admin user."
   3. If the user is a Manager with level 20 or greater, output: "Contact an Admin for access."
   4. If the user is a Manager with level less than 20, output: "You do not have sufficient privileges."
   5. If the user is neither an Admin nor a Manager, output: "You do not have sufficient privileges."

   Variables:
   - permission: String with user roles (e.g., "Admin|Manager")
   - level: Integer denoting the user's career level

   Implementation:
   - Use if-else statements to evaluate the complex business rules.
   - Check for specific conditions using Contains() method on the permission string.
   - Assign the appropriate output message based on the conditions.

   Output:
   - Display the final output message using Console.WriteLine().
*/
// Variables
string permission = "Admin|Manager";
int level = 55;

// Business Rules Implementation
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
else 
{
    outputMessage = "You do not have sufficient privileges.";
}

// Display the Output
Console.WriteLine(outputMessage);
