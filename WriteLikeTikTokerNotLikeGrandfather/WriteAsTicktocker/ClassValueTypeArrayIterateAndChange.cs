
internal class ClassValueTypeArrayIterateAndChange
{
	private static void MainValueTypeArrayIterateAndChange(string[] args)
	{
		Console.WriteLine();

		int[] ints = { 1, 2, 3 };
		IncrementAll(ints);

		Console.ReadLine();
	}

	private static void IncrementAll(int[] ints)
	{
		foreach (ref int i in ints.AsSpan())
		{
			i++;
		}
	}

	//not compiled, because ints is value type array, iterator returns value copy, so ++ meaningless
	private static void IncrementAll1(int[] ints)
	{
		/*
		foreach (int i in ints)
		{
			i++;
		}
		*/
	}
}