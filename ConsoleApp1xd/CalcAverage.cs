public static double CalculateAverage(int[] numbers)
{
    if (numbers == null || numbers.Length == 0)
    {
        throw new ArgumentException("Tablica nie może być pusta");
    }

    int sum = 0;
    foreach (var number in numbers)
    {
        sum += number;
    }

    return (double)sum / numbers.Length;
}
