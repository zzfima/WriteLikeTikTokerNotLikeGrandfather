internal class ClassDynamicType
{
	record FirstType(string Name);
	record SecondType(string Name);

	private static void MainDynamicType(string[] args)
	{
		Console.WriteLine();

		FirstType firstType = new FirstType("t1");
		SecondType secondType = new SecondType("t2");
		Console.WriteLine(GetName(firstType));

		Console.ReadLine();
	}

	private static string GetName(object obj)
	{
		var someType = obj as dynamic;
		return someType.Name;
	}

	//less lines but again we need create lines
	private static string GetName2(object obj)
	{
		return obj switch
		{
			FirstType x => x.Name,
			SecondType x => x.Name,
			_ => string.Empty
		};
	}

	//records are not shares some interface, so there is need for "is". Or there is some interface but it not accessible, like in bottom example
	private static string GetName1(object obj)
	{
		if (obj is FirstType f)
		{
			return f.Name;
		}
		else if (obj is SecondType s)
		{
			return s.Name;
		}
		return string.Empty;
	}
}

internal interface IAaa
{
	int Foo();
}
public class CAaa : IAaa
{
	public int Foo() => 1;
}