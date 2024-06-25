namespace IntroductoryEducationalPractice;

public class ArrayGenerator
{
    private static Random _random = new();

    public static int[] GenerateArray(int length, int minValue, int maxValue)
    {
        int[] massive = new int[length];

        for (int i = 0; i < length; i++)
        {
            massive[i] = _random.Next(minValue, maxValue);
        }

        return massive;
    }

    public static int[,] GenerateArray(int height, int length, int minValue, int maxValue)
    {
        int[,] array = new int[height, length];

        for (int i = 0; i < height; i++)
        {
            for (int j = 0; j < length; j++)
            {
                array[i, j] = _random.Next(minValue, maxValue);
            }
        }

        return array;
    }
}