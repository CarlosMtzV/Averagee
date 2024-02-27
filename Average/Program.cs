
using Average;
int[] integerData = { 8, 8, 9, 9, 8, 6 };

double[] floatingData = { 8.8, 8.8, 9.9, 9.9, 8.8, 6.6 };

double integerAverage = Statistics.CalculateAverage(integerData);
double floatingAverage = Statistics.CalculateAverage(floatingData);
Console.WriteLine("Average of integer numbers: " + integerAverage);
Console.WriteLine("Average of floating-point numbers: " + floatingAverage);