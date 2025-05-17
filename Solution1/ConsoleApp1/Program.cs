int[] numbers = { -42, -58, -50, -50 };

CalculateAverage(numbers);


 static double CalculateAverage(int[] numbers)
{
    int sum = 0;

    foreach (int number in numbers)
    {
        sum += number;
    }

    return (double)sum / numbers.Length;
