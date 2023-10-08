using System;
Console.WriteLine("Enter line length");
string? lineLengthFromConsole = Console.ReadLine();
bool result = int.TryParse(lineLengthFromConsole, out var lineLength);

for (int i = lineLength; i > 0; i--)
{
    if (i != lineLength)
    {
        string[] spaces = new string[ lineLength - i];
        Array.Fill(spaces, " ");
        int[] numbers = new int[i];
        Array.Fill(numbers, i);
        Console.WriteLine($"{string.Join("", spaces)}{string.Join(" ", numbers)}");
    } else
    {
        string[] numbers = new string[i];
        Array.Fill(numbers, lineLengthFromConsole);
        Console.WriteLine(string.Join(" ", numbers));

    }
}

Console.ReadLine();