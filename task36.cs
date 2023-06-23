int[] GetRandomArray(int size, int MinValue, int MaxValue)
{
	int[] result = new int[size];
	for (int i = 0; i < size; i++)
	{
		result[i] = new Random().Next(MinValue, MaxValue + 1);
	}
	return result;
}
int SumNotEvens(int[] array)
{		
	int rez = 0;
	for (int el = 0; el < array.Length; el = el + 2)
		{
			rez = rez + array[el];
		}
	return rez;
}
Console.WriteLine("Input quantity elements in array ");
int UserSize = int.Parse(Console.ReadLine());
int[] RandArray = GetRandomArray(UserSize, -999, 999);
Console.WriteLine(String.Join(",", RandArray));
int sum = SumNotEvens(RandArray);
Console.WriteLine($"Sum of not even elements is {sum}");