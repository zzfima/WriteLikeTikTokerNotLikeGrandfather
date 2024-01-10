using System.Runtime.InteropServices;

internal class ClassDictionaryCollectionsMarshal
{
	private static void MainDictionaryCollectionsMarshal(string[] args)
	{
		Console.WriteLine();
		Dictionary<string, int> map = new Dictionary<string, int>();
		map["a"] = 1;
		map["b"] = 1;
		map["c"] = 1;
		SimpleIncrement(map, "b");
		Console.WriteLine($"{map["b"]}");
		Console.ReadLine();
	}

	//more efficient. travels only once to dictionary. Less clear.
	private static void SimpleIncrement(Dictionary<string, int> map, string key)
	{
		ref var val = ref CollectionsMarshal.GetValueRefOrAddDefault(map, key, out _);
		val++;
	}

	//two travels do dictionary: one for read, one for write.
	//If dictionary is big and key is large it can take a time
	private static void SimpleIncrement1(Dictionary<string, int> map, string key)
	{
		map[key]++;
	}
}
