
internal class ClassIncrementNullableUsingLiftedOperator
{
	private static void MainNullableUsingLiftedOperator(string[] args)
	{
		Console.WriteLine();

		int? i = 44;
		i = Increment(i);

		int? j = null;
		j = Increment(j);

		bool isInRange = IsInRange(11, i, j);
		isInRange = IsInRange(55, i, j);

		Console.ReadLine();
	}

	//Lifted operator: The lifted operator produces a null value if one or both operands are null
	private static bool IsInRange(int v, int? i, int? j)
	{
		return v >= i && v <= j;
	}

	//Lifted operator: The lifted operator produces a null value if one or both operands are null
	private static int? Increment(int? val) => val + 1;

	private static int? Increment3(int? val) => val + 1 ?? null;

	private static int? Increment2(int? val) => val == null ? null : val + 1;

	private static int? Increment1(int? val)
	{
		if (val == null)
			return null;

		return val + 1;
	}
}