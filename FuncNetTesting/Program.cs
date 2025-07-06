using Domain;
using FuncNet;

Console.WriteLine("Hello, World!");

Class1.Value.Map0(number => $"hello{number}");

Class1.Value = true;

Class1.Value = Union<int, string, bool>.FromT0(43);

Class1.Value = Union<int, string>.FromT0(43);

Class1.Value = Union<int, bool, string>.FromT0(43);

Union<int, bool, string> test = Union<bool, int, string>.FromT2("hello");
Union<int, string, bool, DateTime> test2 = test;

Union<bool, decimal, float, int> newUnion = 132;
Union<decimal, float, bool, int> union2 = 432;
newUnion = union2;

Result<int, float, decimal, bool, DateTime, string, double> abc1 = true;
Result<int, float, decimal, bool, DateTime, double, string> abc2 = "abbbb";
abc1 = abc2;