using System;

int[] array1 = new int[7];
int[] array2 = new int[7];
int[] array3 = new int[7];

Random random = new Random();

for (int i = 0; i < array1.Length; i++) 
{
    array1[i] = random.Next();
}

for (int i = 0; i < array2.Length; i++)
{
    Console.WriteLine("Write a number");
    int num = Convert.ToInt32(Console.ReadLine());
    array2[i] = num;
}

for (int i = 0; i < array3.Length; i++)
{
    array3[i] = array1[i] + array2[i];
}

Console.WriteLine(string.Join(", ",array1));
Console.WriteLine(string.Join(", ",array2));
Console.WriteLine(string.Join(", ",array3));
Console.ReadLine();