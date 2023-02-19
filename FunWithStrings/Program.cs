// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
StringEqualitySpecifyingCompareRules();
static void StringEqualitySpecifyingCompareRules()
{
    Console.WriteLine("=> String equality (Case Insensitive)");
    string s1 = "Hello!";
    string s2 = "HELLO!";
    Console.WriteLine($"s1 = {s1}");
    Console.WriteLine($"s2 = {s2}");
    Console.WriteLine();



    Console.WriteLine($"Default rules: s1 = {s1}, s2 = {s2}, s1.Equals(s2): {s1.Equals(s2)}");
    Console.WriteLine($"Ignore case: s1.Equals(s2,StringComparison.OrdinalIgnoreCase): " +
        $"{s1.Equals(s2, StringComparison.OrdinalIgnoreCase)}");
    Console.WriteLine($"Ignore case, Invariant Culture: s1.Equals(s2,StringComparison.InvariantCultureIgnoreCase): " +
        $"{s1.Equals(s2, StringComparison.InvariantCultureIgnoreCase)}");
    Console.WriteLine();




    Console.WriteLine($"Default rules: s1={s1},s2={s2}, s1.IndexOf(\"E\"): {s1.IndexOf("E")} ");

    Console.WriteLine($"Ignore case: s1.IndexOf(\"E\",StringComparison.OrdinalIgnoreCase): " +
                        $"{s1.IndexOf("E", StringComparison.OrdinalIgnoreCase)}");

    Console.WriteLine($"Ignore case,Invariant Culture: s1.IndexOf(\"E\",StringComparison.InvariantCultureIgnoreCase): " +
                        $"{s1.IndexOf("E", StringComparison.InvariantCultureIgnoreCase)}");
    Console.WriteLine();
    //добавить в описание определение культуры
}