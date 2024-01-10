

using System.Runtime.CompilerServices;

internal class ClassAttributesExpression
{
	private static void MainAttributesExpression(string[] args)
	{
		CheckRange(5.6, 11.2);
		Console.ReadLine();
	}

	private static void CheckRange(double v1, double v2)
	{
		if (LogExpression(v1 < v2))
		{
			//do work
		}
	}

	private static bool LogExpression(
		bool expression,
		[CallerFilePath] string? callerFilePathAttribute = null,
		[CallerLineNumber] int lineNumber = 0,
		[CallerArgumentExpression(nameof(expression))] string? expressionText = null
		)
	{
		Console.WriteLine($"{callerFilePathAttribute} : {lineNumber} : {expressionText}={expression}");
		return expression;
	}
}
