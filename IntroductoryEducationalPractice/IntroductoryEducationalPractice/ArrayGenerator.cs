namespace IntroductoryEducationalPractice;

public class ArrayGenerator
{
    //public static int[] GenerateMassive(int length, int minValue, int maxValue)
    //{
    //    Random random = new();
    //    int[] massive = new int[length];

    //    for (int i = 0; i < length; i++)
    //    {
    //        massive[i] = random.Next(minValue, maxValue);
    //    }

    //    return massive;
    //}

    public static int[,] GenerateArray(int height, int length, int minValue, int maxValue)
    {
        Random random = new();
        int[,] array = new int[height, length];

        for (int i = 0; i < height; i++)
        {
            for (int j = 0; j < length; j++)
            {
                array[i, j] = random.Next(minValue, maxValue);
            }
        }

        return array;
    }
}