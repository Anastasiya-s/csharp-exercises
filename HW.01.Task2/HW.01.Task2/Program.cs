using System;

int[] ints = new int[10];

for (int i = 0; i < ints.Length - 1; i++)
{
    Console.WriteLine("Enter array entry");
    bool isValid = false;
    while (!isValid)
    {
        isValid = int.TryParse(Console.ReadLine(), out ints[i]);

    }
}

Console.WriteLine("Enter number");
int lastItem = 0;
bool isValidLastEntry = false;
while (!isValidLastEntry)
{
    isValidLastEntry = int.TryParse(Console.ReadLine(), out lastItem);

}

Console.WriteLine("Enter position");
int lastIndex = 0;
bool isValidLastIndex = false;
while (!isValidLastIndex)
{
    isValidLastIndex = int.TryParse(Console.ReadLine(), out lastIndex);

}

for (int i = ints.Length - 1; i > lastIndex - 1; i--)
{
    ints[i] = ints[i - 1];
}

ints[lastIndex - 1] = lastItem;

Console.WriteLine(string.Join(", ", ints));
Console.ReadLine();