double[] GetRandomArray(int size)
{
	double[] result = new double[size];
	for (int i = 0; i < size; i++)
	{
		result[i] = new Random().NextDouble() * 100;
	}
	return result;
}
		
double MaxEl(double[] array)
{
	double maxel = array[0];
	foreach (double el in array) {if (el > maxel) maxel = el;}
	return maxel;
}
double MinEl(double[] array)
{
	double minel = array[0];
	foreach (double el in array) {if (el < minel) minel = el;}
	return minel;
}
Console.WriteLine("Input quantity elements in array ");
int UserSize = int.Parse(Console.ReadLine());
double[] RandArray = GetRandomArray(UserSize);
Console.WriteLine(String.Join(",", RandArray));
double rez = MaxEl(RandArray) - MinEl(RandArray);
Console.WriteLine($"Max - min is {Math.Round(rez, 2)}");