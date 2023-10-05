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

int[] temp = new int[ints.Length - lastIndex];
int[] firstPart = new int[ints.Length - temp.Length];

Array.Copy(ints, lastIndex - 1, temp, 0, ints.Length - lastIndex);
Array.Copy(ints, 0, firstPart, 0, ints.Length - temp.Length);

ints[lastIndex - 1] = lastItem;

foreach (int item in temp)
{
    ints[lastIndex + Array.IndexOf(temp, item)] = item;
}

Console.WriteLine(string.Join(", ", ints));
Console.ReadLine();