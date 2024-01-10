internal class ClassCopyImmutableChangeByWith
{
	record DataRecordClass(string Name, string Value);

	private static void Main(string[] args)
	{
		var d = UpdateMember();
		d.Deconstruct(out _, out string v);
		Console.WriteLine(v);
		Console.WriteLine(d.Value);

		Console.ReadLine();
	}

	// copy immutable entity with little change, using "with" keyword. works for  tuples, records.
	private static DataRecordClass UpdateMember()
	{
		DataRecordClass data = new DataRecordClass("name", "value");
		var updated = data with { Value = "v2" };
		return updated;
	}
}
