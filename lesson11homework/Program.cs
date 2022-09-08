delegate void Func(string s);

class MyClass
{
	public void Space(string s) => Console.WriteLine($"Space : {string.Join("_", s.ToCharArray())}");
	public void Reverse(string s) => Console.WriteLine($"Reverse : {new string(s.Reverse().ToArray())}");
}

class Run
{
	public void RunFunc(Func funcDell, string s) => funcDell(s);
}

class Program
{
	static void Main()
	{
		while (true)
		{
			Console.Write("Enter string : ");
			var s = Console.ReadLine();
			MyClass cls = new MyClass();
			Func funcDell = cls.Reverse;
			funcDell += cls.Space;
			Run run = new Run();
			run.RunFunc(funcDell, s);

			Console.Write("\nPress any key to continue...");
			Console.ReadKey();
			Console.Clear();
		}
	}
}