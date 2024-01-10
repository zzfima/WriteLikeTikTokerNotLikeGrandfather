internal class ClassIsOperator
{
    private static void MainIsOperator(string[] args)
    {
        Console.WriteLine();
        Console.WriteLine($"{IsNull("dsds")}");
        Console.WriteLine($"{IsNull(null)}");
        Console.ReadLine();
    }

    static bool IsNull(object? obj)
    {
        return obj is not not null;
    }

    static bool IsNull2(object? obj)
    {
        return obj is null;
    }

    static bool IsNull1(object? obj)
    {
        return obj == null;
    }
}