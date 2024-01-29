using System;
					
public class Program
{
	string name = "Ty";
	int myNum = 50;
	
	public void Main()
	{
		int NumSum = myNum + 25;
		Console.WriteLine("Hello World! My name is " + name + " and the myNum value is " + myNum + ".");
		Console.WriteLine("The NumSum Value is " + NumSum);
		NumSum += 25;
		Console.WriteLine("Now I add 25 and change it to " + NumSum + ".");
	}
}
