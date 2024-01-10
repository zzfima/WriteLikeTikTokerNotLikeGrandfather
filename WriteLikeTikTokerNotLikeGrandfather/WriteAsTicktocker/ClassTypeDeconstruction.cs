internal class ClassTypeDeconstruction
{
	private static void MainTypeDeconstruction(string[] args)
	{
		Dictionary<string, (int x, int y)> dict = new Dictionary<string, (int x, int y)>();
		dict["a"] = (x: 66, y: 88);
		dict["b"] = (x: 166, y: 188);
		dict["n"] = (x: 266, y: 388);

		PrintXInDict(dict);
		Console.ReadLine();
	}

	//using deconstruction. deconstruction exists for tuples, records and user types with deconstruction method
	private static void PrintXInDict(Dictionary<string, (int x, int y)> dict)
	{
		foreach (var (_, (X, _)) in dict)
		{
			Console.WriteLine($"X: {X}");
		}
	}

	private static void PrintXInDict1(Dictionary<string, (int x, int y)> dict)
	{
		foreach (var d in dict)
		{
			Console.WriteLine($"X: {d.Value.x}");
		}
	}
}