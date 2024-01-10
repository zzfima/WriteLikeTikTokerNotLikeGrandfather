internal class ClassReformatAsSpan
{
    private static void MainReformatAsSpan(string[] args)
    {
        Console.WriteLine();
        Console.WriteLine($"path Reformatted: {Reformat("{{aaa;bbb;ccc;ddd}}")}");
        Console.ReadLine();
    }

    //AsSpan disabled allocation of strings, using Interpolated StringBuilder
    private static string Reformat(string strPath)
    {
        return $"[{strPath.AsSpan().TrimStart('{').TrimEnd('}')}]";
    }

    //there is odd allocation of string: each time in Trim
    private static string Reformat1(string strPath)
    {
        return $"[{strPath.TrimStart('{').TrimEnd('}')}]";
    }
}