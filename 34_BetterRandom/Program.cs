namespace _34_BetterRandom;

internal class Program
{
    static void Main(string[] args)
    {
        Random rnd = new();

        Console.WriteLine(rnd.NextDouble(100.0));
        Console.WriteLine(rnd.NextString("happy", "sad", "angry", "mopey"));
        Console.WriteLine(rnd.NextBool());
        Console.WriteLine(rnd.NextBool(0.9));
    }
}

public static class Extensions
{
    public static double NextDouble(this Random rnd, double max)
    {
        return rnd.NextDouble() * max;
    }

    public static string NextString(this Random rnd, params string[] randText)
    {
        int randIndex = rnd.Next(randText.Length);

        return randText[randIndex];
    }

    public static bool NextBool(this Random rnd, double frequencyHeads = 0.5)
    {
        return rnd.NextDouble() < frequencyHeads;
    }
}