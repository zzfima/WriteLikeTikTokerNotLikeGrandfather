
using System.Runtime.CompilerServices;

internal class ClassLogCallerMemberName
{
	private static void MainLogCallerMemberName(string[] args)
	{
		DoWork();
		Console.ReadLine();
	}

	private static void DoWork()
	{
		LogStartMessage();

		//work

		LogEndMessage();
	}

	private static void LogEndMessage([CallerMemberName] string? methodName = null)
	{
		Console.WriteLine($"{methodName} do work started");
	}

	private static void LogStartMessage([CallerMemberName] string? methodName = null)
	{
		Console.WriteLine($"{methodName} do work finished");
	}

	private static void DoWork2()
	{
		Log($"{nameof(DoWork)}do work started");

		//work

		Log($"{nameof(DoWork)}do work finished");
	}

	private static void DoWork1()
	{
		Log("do work started");

		//work

		Log("do work finished");
	}

	private static void Log(string log)
	{
		Console.WriteLine(log);
	}
}