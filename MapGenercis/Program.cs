using System;

public class Program
{
    public static void Main()
    {
        int[] array = { 1, 2, 3, 4, 5 };
        Func<int, double> function = x => Math.Sqrt(x);
        double[] arrayResult = Map(array, function);
        Console.WriteLine(string.Join(",", arrayResult));
    }

    public static U[] Map<T, U>(T[] array, Func<T, U> function)
    {
        U[] arrayResult = new U[array.Length];
        for (int i = 0; i < array.Length; i++)
        {
            arrayResult[i] = function(array[i]);
        }
        return arrayResult;
    }
}
