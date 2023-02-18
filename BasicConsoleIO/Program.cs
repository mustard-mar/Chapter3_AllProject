using System;
Console.WriteLine("***** Basic Console I/O ******");
//GetUserData();
FormatNumericalData();

static void GetUserData()
{
    Console.Write("Name: ");
    string userName = Console.ReadLine();
    Console.Write("Age: ");
    string userAge = Console.ReadLine();
    ConsoleColor prevColor = Console.ForegroundColor;
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine($"Hello {userName} Age: {userAge}");
    Console.ForegroundColor = prevColor;
}

static void FormatNumericalData()
{
    Console.WriteLine("The value 99999 in various formats: ");
    Console.WriteLine("c format {0:c}",99999);
    Console.WriteLine("d9 format {0:d9}", 99999);
    Console.WriteLine("f3 format {0:f3}", 99999);
    Console.WriteLine("E format {0:E}", 99999);
    Console.WriteLine("e format {0:e}", 99999);
    Console.WriteLine("X format {0:X}", 99999);
    Console.WriteLine("x format {0:x}", 99999);
}
