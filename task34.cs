int[] GetRandomArray(int size, int MinValue, int MaxValue)
{
	int[] result = new int[size];
	for (int i = 0; i < size; i++)
	{
		result[i] = new Random().Next(MinValue, MaxValue + 1);
	}
	return result;
}

int QuantEvens(int[] array)
{		
	int rez = 0;
	foreach (int el in array)
		{
			if (el % 2 == 0) rez++;
		}
	return rez;
}
Console.WriteLine("Input quantity elements in array ");
int UserSize = int.Parse(Console.ReadLine());
int[] RandArray = GetRandomArray(UserSize, 100, 999);
Console.WriteLine(String.Join(",", RandArray));
int evens = QuantEvens(RandArray);
Console.WriteLine($"Quantity of evens is {evens}");