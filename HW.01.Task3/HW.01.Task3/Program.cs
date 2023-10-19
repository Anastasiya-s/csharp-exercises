using System.Linq;
using System.Diagnostics;

Int64 determineArrayLength() 
{ 
    Random rndm = new Random();
    Int64 rndmLength = rndm.Next(1, 1000000000);
    return rndmLength;
};

Int64[] FillArray(Int64[] array)
{
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next();
    }
    return array;
}

Int64[]  ArrayReverse(Int64[] inputArray)
{
    bool isOdd = inputArray.Length % 2 == 0;
    Int64 midpoint = inputArray.Length / 2;

    for (int i = 0; i < midpoint; i++)
    {
        Int64 temp = inputArray[i];
        inputArray[i] = inputArray[inputArray.Length - 1 - i];
        inputArray[inputArray.Length - 1 - i] = temp;
    }

    return inputArray;
}

for (int i = 0; i < 10; i++)
{
    Int64 newLength = determineArrayLength();
    Int64[] newArray = new Int64[newLength];

    Stopwatch stopWatch = new Stopwatch();

    FillArray(newArray);
    Console.WriteLine(newLength);

    stopWatch.Start();
    ArrayReverse(newArray);
    stopWatch.Stop();
    TimeSpan timeSpan1 = stopWatch.Elapsed;
    string elapsedTime1 = String.Format($"{timeSpan1.Hours:00}:{timeSpan1.Minutes:00}:{timeSpan1.Seconds:00}.{timeSpan1.Milliseconds:00}");
    Console.WriteLine($"RunTime of my implementation is {elapsedTime1}");

    stopWatch.Start();
    Array.Reverse(newArray);
    stopWatch.Stop();
    TimeSpan timeSpan2 = stopWatch.Elapsed;
    string elapsedTime2 = String.Format($"{timeSpan1.Hours:00}:{timeSpan1.Minutes:00}:{timeSpan1.Seconds:00}.{timeSpan1.Milliseconds:00}");
    Console.WriteLine($"RunTime of Array.Reverse is {elapsedTime2}");
}

Console.ReadLine();