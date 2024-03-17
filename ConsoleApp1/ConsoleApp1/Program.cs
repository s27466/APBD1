// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");
Console.WriteLine("Mod1");
Console.WriteLine("Mod2");
Console.WriteLine("Mod3");

int[] integers = new[] { 1, 2, 3, 4, 5 };
Console.WriteLine(getAverage(integers));
Console.WriteLine(getMax(integers));

double getAverage(int[] ints)
{
    return ints.Average();
}

double getMax(int[] ints)
{
    return ints.Max();
}