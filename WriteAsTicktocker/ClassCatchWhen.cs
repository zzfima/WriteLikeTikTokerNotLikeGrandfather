internal class ClassCatchWhen
{
    private static async Task MainCatchWhen(string[] args)
    {
        CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();

        Task a = Task.Run(() => MainLoop(cancellationTokenSource.Token));
        Task b = Task.Run(async () =>
        {
            await Task.Delay(500);
            cancellationTokenSource.Cancel();
        });

        Task.WaitAll([a, b]);

        Console.Write("/");

        Console.Read();
    }

    static async Task MainLoop(CancellationToken cancellationToken)
    {
        Console.WriteLine($"Task: {Task.CurrentId}");

        try
        {
            while (true)
            {
                await Task.Delay(100, cancellationToken);
                Console.Write("*");
            }
        }
        catch when (cancellationToken.IsCancellationRequested)
        {
            Console.Write("finitto");
        }
        catch { throw; }
    }

    static async Task MainLoop1(CancellationToken cancellationToken)
    {
        Console.WriteLine($"Task: {Task.CurrentId}");

        try
        {
            while (true)
            {
                await Task.Delay(100, cancellationToken);
                Console.Write("*");
            }
        }
        catch (TaskCanceledException)
        {
            Console.Write("finitto");
        }
        catch { throw; }
    }
}