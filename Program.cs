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
		//string[] animals = { "Cat", "Alligator", "Fox", "Donkey", "Cat" };

		//string[] dist = animals.Distinct().ToArray();
		//int[] nums = { 1, 2, 3, 4, 3, 55, 23, 2 };
		//	int[] dist = nums.Distinct().ToArray();
		//int[] nums = { 1, 2, 3, 4, 5 };

		UpdateArray(nums);

		foreach (var item in nums)
			Console.WriteLine(item);
	}

	public static void UpdateArray(int[] arr)
	{
		for (int i = 0; i < arr.Length; i++)
			arr[i] = arr[i] + 10;
	}
}

