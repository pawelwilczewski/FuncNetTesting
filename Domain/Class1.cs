using FuncNet;

namespace Domain;

public class Class1
{
	public static Union<int, string, bool> Value { get; set; } = 32;

	private Option<string> test = Option<string>.FromNullable("abcd");

	public void Method()
	{
		Value = Union<string, int>.FromT0("abc");
		Value = 43;
		Value = Union<bool, int, string>.FromT1(32);
		Value = false;
	}
}

// Union<int, bool, string>