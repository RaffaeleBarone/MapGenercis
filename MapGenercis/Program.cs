using System;

public class Program
{
    public static void Main()
    {
        int[] array = { 1, 2, 3, 4, 5 };
        string[] stringArray = { "Ciao", "Hey" };

        double[] arrayResult = Map(array, x => Math.Sqrt(x));
        Console.WriteLine(string.Join(",", arrayResult));

        string[] stringResult = Map(stringArray, x => Contiene(x));
        Console.WriteLine(string.Join(",", stringResult));
    }

    public static string Contiene(string x)
    {
        if (x.Contains("C"))
        {
            x = x + " " + "Pippo";
        }
        else
        {
            x = x + " " + "John";
        }
        return x;
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


