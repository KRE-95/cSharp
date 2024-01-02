// Array string type stores Id
string [] orderIDs = {"B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179"};

// iterate
foreach (string orderID in orderIDs)
{    
    /*detecting the orders that
      start   with the letter "B" 
*/
    if(orderID.StartsWith("B"))
    {
        Console.WriteLine($"Potential fraud: Order ID {orderID} starts with 'B'");

    } 
}
