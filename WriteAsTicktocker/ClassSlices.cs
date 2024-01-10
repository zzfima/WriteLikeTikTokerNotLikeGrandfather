
internal class ClassSlices
{
    private static void MainSlices(string[] args)
    {
        Console.WriteLine();
        Console.WriteLine($"{Except2Lasts("babanda")}");
        Console.WriteLine($"{Except1Start1Last("babanda")}");
        Console.WriteLine($"{Except3Lasts("babanda")}");
        Console.ReadLine();
    }

    private static string Except3Lasts(string str)
    {
        return str.AsSpan()[..^3].ToString();
    }

    private static string Except1Start1Last(string str)
    {
        return str[1..^1];
    }

    private static string Except2Lasts(string str)
    {
        Index index = ^2;
        return str[..index];
    }
}