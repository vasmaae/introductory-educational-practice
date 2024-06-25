using System.Text;

namespace IntroductoryEducationalPractice;

public static class ArrayHandler
{
    public static string Task1(int[] array)
    {
        int positiveRangeStartIndex = -1, negativeRangeStartIndex = -1, currentRangeStartIndex = 0;
        int positiveLength = 0, negativeLength = 0, currentLength = 0;
        int currentRangeSign = (array[0] >= 0) ? 1 : -1;

        for (int i = 0; i < array.Length; i++)
        {
            int currentSign = (array[i] >= 0) ? 1 : -1;

            if (currentSign == currentRangeSign)
            {
                currentLength++;
            }

            if (currentSign != currentRangeSign || i == array.Length - 1)
            {
                switch (currentRangeSign)
                {
                    case 1:
                        if (currentLength > positiveLength)
                        {
                            positiveLength = currentLength;
                            positiveRangeStartIndex = currentRangeStartIndex;
                        }
                        currentLength = 0;
                        break;
                    case -1:
                        if (currentLength > negativeLength)
                        {
                            negativeLength = currentLength;
                            negativeRangeStartIndex = currentRangeStartIndex;
                        }
                        currentLength = 0;
                        break;
                }

                currentRangeSign = currentSign;
                currentRangeStartIndex = i;
                currentLength++;
            }
        }

        StringBuilder sb = new();
        if (positiveLength < 2) sb.Append($"Положительная серия: отсутствует ");
        else sb.Append($"Положительная серия: длина - {positiveLength}, начало - {positiveRangeStartIndex}");
        sb.Append(Environment.NewLine);
        if (negativeLength < 2) sb.Append($"Отрицательная серия: отсутствует ");
        else sb.Append($"Отрицательная серия: длина - {negativeLength}, начало - {negativeRangeStartIndex}");

        return sb.ToString();
    }

    public static string Task2(int[] array)
    {
        return "";
    }

    public static string Task3(int[] array)
    {
        return "";
    }

    public static string Task4(int[] array)
    {
        return "";
    }

    public static string Task5(int[] array)
    {
        return "";
    }

    public static string Task6(int[] array)
    {
        return "";
    }
}