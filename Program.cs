using System;
using System.Linq;

public class Program
{
	public static void Main()
	{
		int[] nums = new int[5] { 10, 15, 16, 8, 6 };

		Console.WriteLine(nums.Max());
		Console.WriteLine(nums.Min());
		Console.WriteLine(nums.Sum());
		Console.WriteLine(nums.Average());
	}
}