//numbering is an order of invention

internal class ClassLightweightTypes
{
	class DataClass
	{
		public int Id { get; set; }
		public string Name { get; set; }
	}

	record DataRecordClass(int Id, string Name);
	record struct DataRecordStruct(int Id, string Name);

	private static void MainLightweightTypes(string[] args)
	{
		var dataClass = new DataClass() { Id = 1, Name = "alex" };

		// 1 - anonymous class. come with LINQ
		var dataAnonymous = new { Id = 1, Name = "alex" };

		// 2 - tuple as a class. Because of F#
		var dataTupleClass = Tuple.Create(1, "alex");

		// 3 - tuple as a struct
		var dataTupleStruct = (Id: 1, Name: "alex");

		// 4 - record as a class
		var dataRecordClass = new DataRecordClass(Id: 1, Name: "alex");

		// 5 - record as a struct
		var dataRecordStruct = new DataRecordStruct(Id: 1, Name: "alex");

		Console.ReadLine();
	}
}
