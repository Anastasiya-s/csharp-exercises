using System;

int[] ints = new int[10];

for (int i = 0; i < ints.Length - 1; i++)
{
    Console.WriteLine("Enter array entry");
    ints[i] = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine("Enter number");
int lastItem = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter position");
int lastIndex = Convert.ToInt32(Console.ReadLine());

for (int i = ints.Length - 1; i > lastIndex - 1; i--)
{
    ints[i] = ints[i - 1];
}

ints[lastIndex - 1] = lastItem;

Console.WriteLine(string.Join(", ", ints));
Console.ReadLine();