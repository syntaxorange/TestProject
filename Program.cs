/*
string firstName = "Bob";
int widgetsPurchased = 7;
Console.WriteLine($"{firstName} purchased {widgetsPurchased} widgets.");
*/
Random random = new Random();
string[] orderIDs = new String[5];
// Loop through each blank orderID
for (int i = 0; i < orderIDs.Length; i++)
{
  // Get a random value that equates to ASCIII letters A through E
  int prefixValue = random.Next(65, 70);
  // Convert the random value into a char, then a string
  string prefix = Convert.ToChar(prefixValue).ToString();
  // Create a random number, pad with zeroes
  string suffix = random.Next(1, 1000).ToString("000");
  // Combine the prefix and suffix together, then assign to current OrderID
  orderIDs[i] = prefix + suffix;
}
// Print out each orderIDs
foreach (var orderID in orderIDs)
{
  Console.WriteLine(orderID);
}