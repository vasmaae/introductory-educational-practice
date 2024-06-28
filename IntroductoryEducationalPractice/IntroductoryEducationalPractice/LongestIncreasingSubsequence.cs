namespace IntroductoryEducationalPractice;

public class LongestIncreasingSubsequence
{
    //public static int[] GetLongestIncreasingSubsequence(int[] sequence)
    //{
    //    int[] tailIndices = new int[sequence.Length];
    //    int[] prevIndices = new int[sequence.Length];

    //    int length = 1;
    //    for (int i = 1; i < sequence.Length; i++)
    //    {
    //        if (sequence[i] < sequence[tailIndices[0]])
    //        {
    //            tailIndices[0] = i;
    //        }
    //        else if (sequence[i] >= sequence[tailIndices[length - 1]])
    //        {
    //            prevIndices[i] = tailIndices[length - 1];
    //            tailIndices[length++] = i;
    //        }
    //        else
    //        {
    //            int l = -1;
    //            int r = length - 1;
    //            while (r - l > 1)
    //            {
    //                int m = l + (r - l) / 2;
    //                if (sequence[tailIndices[m]] >= sequence[i])
    //                    r = m;
    //                else
    //                    l = m;
    //            }
    //            int pos = r;
    //            prevIndices[i] = tailIndices[pos - 1];
    //            tailIndices[pos] = i;
    //        }
    //    }

    //    int[] result = new int[length];
    //    for (int i = tailIndices[length - 1]; length-- > 0; i = prevIndices[i])
    //        result[length] = sequence[i];

    //    return result;
    //}

    public static List<int> GetLongestIncreasingSubsequence(int[] arr)
    {
        if (arr.Length == 0) return new List<int>();

        int[] dp = new int[arr.Length];
        int[] prev = new int[arr.Length];
        int maxLength = 0;
        int maxIndex = -1;

        for (int i = 0; i < arr.Length; i++)
        {
            dp[i] = 1;
            prev[i] = -1;
            for (int j = 0; j < i; j++)
            {
                if (arr[i] > arr[j] && dp[i] < dp[j] + 1)
                {
                    dp[i] = dp[j] + 1;
                    prev[i] = j;
                }
            }
            if (dp[i] > maxLength)
            {
                maxLength = dp[i];
                maxIndex = i;
            }
        }

        List<int> lis = new List<int>();
        for (int i = maxIndex; i >= 0; i = prev[i])
        {
            lis.Add(arr[i]);
            if (prev[i] == -1) break;
        }

        lis.Reverse();
        return lis;
    }
}
