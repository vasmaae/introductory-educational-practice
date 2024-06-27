﻿using System.Text;

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
                        break;
                    case -1:
                        if (currentLength > negativeLength)
                        {
                            negativeLength = currentLength;
                            negativeRangeStartIndex = currentRangeStartIndex;
                        }
                        break;
                }

                currentRangeSign = currentSign;
                currentRangeStartIndex = i;
                currentLength = 1;
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
        int evenRangeStartIndex = -1, currentRangeStartIndex = 0;
        int evenLength = 0, currentLength = 0;
        int currentRangeOfEven = (array[0] % 2 == 0) ? 1 : -1;
        int firstZeroIndex = -1;

        for (int i = 0; i < array.Length; i++)
        {
            if (firstZeroIndex == -1 && array[i] == 0) firstZeroIndex = i;

            int currentEven = (array[i] % 2 == 0) ? 1 : -1;

            if (currentEven == currentRangeOfEven)
            {
                currentLength++;
            }

            if (currentEven != currentRangeOfEven || i == array.Length - 1)
            {
                if ((currentLength > evenLength) && currentRangeOfEven == 1)
                {
                    evenLength = currentLength;
                    evenRangeStartIndex = currentRangeStartIndex;
                }

                currentRangeOfEven = currentEven;
                currentRangeStartIndex = i;
                currentLength = 1;
            }
        }

        if (evenLength >= 2 && firstZeroIndex != -1)
        {
            int temp;
            if (evenRangeStartIndex > firstZeroIndex)
            {
                for (int i = 0; i < evenRangeStartIndex - firstZeroIndex - 1; i++)
                {
                    temp = array[firstZeroIndex + 1];
                    for (int j = firstZeroIndex + 1; j < evenRangeStartIndex + evenLength - 1; j++)
                    {
                        array[j] = array[j + 1];
                    }
                    array[evenRangeStartIndex + evenLength - 1] = temp;
                }
            }
            else
            {
                for (int l = 0; l < firstZeroIndex - evenRangeStartIndex - evenLength + 1; l++)
                {
                    temp = array[firstZeroIndex];
                    for (int i = firstZeroIndex; i > evenRangeStartIndex; i--)
                    {
                        array[i] = array[i - 1];
                    }
                    array[evenRangeStartIndex] = temp;
                }
            }
        }

        StringBuilder sb = new();
        if (evenLength < 2) sb.Append($"Четная серия: отсутствует ");
        else sb.Append($"Четная серия: длина - {evenLength}, начало - {evenRangeStartIndex}");
        sb.Append(Environment.NewLine);
        if (firstZeroIndex == -1) sb.Append($"Нулей нет ");
        else if (evenLength > 1)
        {
            for (int i = 0; i < array.Length; i++)
            {
                sb.Append(array[i]);
                sb.Append(' ');
            }
        }

        return sb.ToString();
    }

    public static string Task3(int[] array, int startLength)
    {
        int currentRangeStartIndex = 0;
        int currentLength = 0;
        int currentRangeEven = (array[0] % 2 == 0) ? 1 : -1;

        for (int i = 0; i < startLength; i++)
        {
            int currentEven = (array[i] % 2 == 0) ? 1 : -1;

            if (currentEven == currentRangeEven)
            {
                currentLength++;
            }

            if ((currentEven != currentRangeEven || i == startLength - 1) && currentLength >= 2)
            {
                for (int j = array.Length - 1; j > currentRangeStartIndex + currentLength - 1; j--)
                {
                    array[j] = array[j - 1];
                }

                array[i++] = array[currentRangeStartIndex];

                currentRangeEven = currentEven;
                currentRangeStartIndex = i;
                currentLength = 1;
            }
        }

        StringBuilder sb = new();
        for (int i = 0; i < array.Length; i++)
        {
            sb.Append(array[i]);
            sb.Append(' ');
        }

        return sb.ToString();
    }

    public static string Task4(int[] array)
    {
        int lastRangeStartIndex = -1, currentRangeStartIndex = 0;
        int lastLength = 0, currentLength = 0;
        int currentRangeSign = (array[0] >= 0) ? 1 : -1;

        for (int i = 0; i < array.Length; i++)
        {
            int currentSign = (array[i] >= 0) ? 1 : -1;

            if (currentSign == currentRangeSign)
            {
                currentLength++;
            }

            if ((currentSign != currentRangeSign || i == array.Length - 1) && currentLength >= 2)
            {
                currentRangeSign = currentSign;
                lastRangeStartIndex = currentRangeStartIndex;
                currentRangeStartIndex = i;
                lastLength = currentLength;
                currentLength = 1;
            }
        }

        if (lastRangeStartIndex != -1)
        {
            for (int i = lastRangeStartIndex; i < array.Length - lastLength; i++)
            {
                array[i] = array[i + lastLength];
            }
        }

        StringBuilder sb = new();
        for (int i = 0; i < array.Length - lastLength; i++)
        {
            sb.Append(array[i]);
            sb.Append(' ');
        }

        return "";
    }

    public static string Task5(int[,] array, int startColumns)
    {
        
    }

    public static string Task6(int[,] array)
    {
        return "";
    }
}