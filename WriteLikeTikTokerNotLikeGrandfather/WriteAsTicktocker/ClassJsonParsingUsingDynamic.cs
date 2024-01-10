using Newtonsoft.Json;
using System.Dynamic;

namespace WriteAsTicktocker
{
	internal class ClassJsonParsingUsingDynamic
	{
		private static void MainJsonParsingUsingDynamic(string[] args)
		{
			Console.WriteLine();

			var ratio = GetSexualDiversityRatio();

			foreach (var item in ratio)
				Console.WriteLine(item);

			Console.ReadLine();
		}

		private static List<(dynamic, int)> GetSexualDiversityRatio()
		{
			string jsonPersons = "[" +
				"{ 'Name': 'Alex', 'Age': 40 }, " +
				"{ 'Name': 'John', 'Age': 41 }, " +
				"{ 'Name': 'Fedora', 'Age': 40 }, " +
				"{ 'Name': 'Aurora', 'Age': 41 }, " +
				"{ 'Name': 'Jenny', 'Age': 45 }, " +
				"{ 'Name': 'Michele', 'Age': 42 }]";
			dynamic[] persons = JsonConvert.DeserializeObject<ExpandoObject[]>(jsonPersons);

			var items = (from person in persons
						 group person by person.Age into ageGroup
						 select (age: ageGroup.Key, count: ageGroup.Count())).ToList();

			return items;
		}
	}
}
