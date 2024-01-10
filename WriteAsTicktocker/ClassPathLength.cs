internal class ClassPathLength
{
    private static void MainPathLength(string[] args)
    {
        Console.WriteLine();
        Console.WriteLine($"path length: {GetPathLength("aaa;bbb;ccc;ddd")}");
        Console.ReadLine();
    }

    static int GetPathLength(string path)
    {
        int firstSeparateIndex = 0;
        int count = 0;

        while ((firstSeparateIndex = path.IndexOf(Path.PathSeparator, firstSeparateIndex)) != -1)
        {
            count++;
            firstSeparateIndex++;
        }

        return count;
    }

    static int GetPathLength1(string path)
    {
        return path.Split(Path.PathSeparator).Length;
    }
}
