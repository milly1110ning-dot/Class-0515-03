using System;

public interface IName
{
	string GetName();
}

public interface INumber
{
	string GetNumber();
}

public class Person : IName, INumber
{
	public string GetName()
	{
		return "Person";
	}

	public string GetNumber()
	{
		return "09**4112";
	}
}
