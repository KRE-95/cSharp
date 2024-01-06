// array type int that stores num
int [] inventory = {200, 450, 700, 175,250 };
/* declare a new variable 
that represents the sum of all 
finished products */
int sum = 0;
/* variable to hold the current 
bin number and display the running total*/
int bin = 0;
/* Keyword foreach - iterate through
 each element of the inventory 
array. By temp assign to value items */
foreach(int items in inventory){
    sum += items; //add the current value stored in items to sum var. 
    bin++; // increments
    /* This code will use your counter
     variable bin, the temporary foreach variable items, and your sum variable to report the current state of your inventory in a nicely formatted message.
    */
    // In other words will show whats happing behind the scenes.
    Console.WriteLine($"Bin {bin} = {items} items(Running total: {sum})");
}
//Display :
Console.WriteLine($"We have {sum} items in inventory.");

