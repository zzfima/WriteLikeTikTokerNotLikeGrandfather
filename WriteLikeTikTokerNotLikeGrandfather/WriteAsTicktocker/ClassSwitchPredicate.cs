internal class ClassSwitchPredicate
{
	record Order(int Id, string Name, double Amount);
	private static void MainSwitchPredicate(string[] args)
	{
		Console.WriteLine();
		var v1 = ValidateOrder(new Order(11, "alex", -3.4));
		var v2 = ValidateOrder(new Order(11, "alex", 3.4));
		Console.ReadLine();
	}

	static bool ValidateOrder(Order order)
	{
		return order switch
		{
			{ Id: < 0 } => false,
			{ Name.Length: <= 0 } => false,
			{ Amount: <= 0.0 } => false,
			_ => true
		};
	}

	static bool ValidateOrder1(Order order)
	{
		return order.Id > 0 && order.Name.Length > 0 && order.Amount > 0.0;
	}
}