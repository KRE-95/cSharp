/*Declare new array of string - hold three elements
string[] fraudulentOrderIDs = new string[3];

// Assign values to elements of an array
// To access an element of an array, you use a numeric zero-based index 
fraudulentOrderIDs[0] = "A123";
fraudulentOrderIDs[1] = "B456";
fraudulentOrderIDs[2] = "C789";
// this will break -fraudulentOrderIDs[3] = "D000";*/

// declare the array initialize values in a single statement:
string[] fraudulentOrderIDs = { "A123", "B456", "C789" };


// Retrieve values from elements of an array:
Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");

// Reassign the value of an array [0]:
fraudulentOrderIDs[0] = "F000";
// output
Console.WriteLine($"\nReassign First: {fraudulentOrderIDs[0]}");

/* Use the Length property of an array as .Length shows the size 
*/
Console.WriteLine($"There are {fraudulentOrderIDs.Length} fraudulent orders to process.");