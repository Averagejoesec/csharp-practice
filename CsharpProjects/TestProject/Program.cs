// int firstvalue = 500;
// int secondvalue = 1000;
// int largerValue = Math.Max(firstvalue, secondvalue);
// Console.WriteLine("The larger value is: " + largerValue);

// Using StartsWith to filter and print orders that start with 'B'
string[] orders = [ "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179" ];
foreach ( string order in orders)
{
    if (order.StartsWith("B"))
    {
        Console.WriteLine(order);
    }
}