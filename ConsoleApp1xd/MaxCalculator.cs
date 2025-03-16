using System;

public class MaxCalculator
{
    public static int FindMax(int[] numbers)
    {
        if (numbers == null || numbers.Length == 0)
        {
            throw new ArgumentException("Tablica nie może być pusta");
        }

        int max = numbers[0];
        foreach (var num in numbers)
        {
            if (num > max)
                max = num;
        }

        return max;
    }
}
