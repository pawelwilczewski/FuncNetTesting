using Domain;
using FuncNet;

Console.WriteLine("Hello, World!");

Class1.Value.Map0(number => $"hello{number}");

Class1.Value = true;

Class1.Value = Union<int, string, bool>.FromT0(43);

Class1.Value = Union<int, string>.FromT0(43);

Class1.Value = Union<int, bool, string>.FromT0(43);

Union<int, bool, string> test = Union<bool, int, string>.FromT2("hello");
