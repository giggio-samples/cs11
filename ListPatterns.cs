namespace CSharp11;

public class ListPatterns
{
    public static void M()
    {
        int[] one = { 1 };
        int[] odd = { 1, 3, 5 };
        int[] even = { 2, 4, 6 };
        int[] fib = { 1, 1, 2, 3, 5 };

        Console.WriteLine(odd is [1, 3, 5]); // true
        Console.WriteLine(even is [1, 3, 5]); // false (values)
        Console.WriteLine(one is [1, 3, 5]); // false (length)

        Console.WriteLine(odd is [1, _, _]); // true
        Console.WriteLine(odd is [_, 3, _]); // true
        Console.WriteLine(even is [_, _, 5]); // false (last value)

        Console.WriteLine(odd is [1, .., 3, _]); // true
        Console.WriteLine(fib is [1, .., 3, _]); // true
        Console.WriteLine(odd is [1, _, 5, ..]); // true
        Console.WriteLine(fib is [1, _, 5, ..]); // false

        Console.WriteLine(odd is [_, > 1, ..]); // true
        Console.WriteLine(even is [_, > 1, ..]); // true
        Console.WriteLine(fib is [_, > 1, ..]); // false

        var balance = 0m;
        foreach (var transaction in ReadRecords())
        {
            balance += transaction switch
            {
                [_, "DEPOSIT", _, var amount] => decimal.Parse(amount),
                [_, "WITHDRAWAL", .., var amount] => -decimal.Parse(amount),
                [_, "INTEREST", var amount] => decimal.Parse(amount),
                [_, "FEE", var fee] => -decimal.Parse(fee),
                _ => throw new InvalidOperationException($"Record {transaction} is not in the expected format!"),
            };
            Console.WriteLine($"New balance: {balance:C} | Record: {string.Join(", ", transaction)}");
        }
    }

    static string[][] ReadRecords() =>
        new[] { new[] { "04-01-2020", "DEPOSIT", "Initial deposit", "2250.00"},
        new[] { "04-15-2020","DEPOSIT","Refund","125.65" },
        new[] { "04-18-2020","DEPOSIT","Paycheck","825.65" },
        new[] { "04-22-2020","WITHDRAWAL","Debit","Groceries","255.73" },
        new[] { "05-01-2020","WITHDRAWAL","#1102","Rent, apt","2100.00" },
        new[] { "05-02-2020","INTEREST","0.65" },
        new[] { "05-07-2020","WITHDRAWAL", "Debit","Movies","12.57" },
        new[] { "04-15-2020","FEE","5.55" } };
}
