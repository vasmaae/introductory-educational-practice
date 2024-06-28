namespace IntroductoryEducationalPractice;

public class ArraySorter
{
    public ArraySorterStateStorage StateStorage { get; private set; }
    public int[] SourceArray;
    public int[] SortedArray;

    public ArraySorter(int[] arrayForSorting)
    {
        SourceArray = new int[arrayForSorting.Length];
        SortedArray = new int[arrayForSorting.Length];
        Array.Copy(arrayForSorting, SourceArray, arrayForSorting.Length);
        Array.Copy(arrayForSorting, SortedArray, arrayForSorting.Length);

        StateStorage = new();
        StateStorage.Add(SourceArray);
        SmoothSort(SortedArray);
    }

    private static int Leonardo(int k)
    {
        if (k < 2)
            return 1;
        return Leonardo(k - 1) + Leonardo(k - 2) + 1;
    }

    private void Heapify(int[] arr, int start, int end)
    {
        int i = start;
        int j = 0;
        int k = 0;

        while (k < end - start + 1)
        {
            if ((k & 0xAAAAAAAA) != 0)
            {
                j += i;
                i >>= 1;
            }
            else
            {
                i += j;
                j >>= 1;
            }
            k++;
        }

        while (i > 0)
        {
            j >>= 1;
            k = i + j;

            while (k < end)
            {
                if (arr[k] > arr[k - i])
                    break;

                Swap(ref arr[k], ref arr[k - i]);
                int[] tmpArr = new int[arr.Length];
                Array.Copy(arr, tmpArr, arr.Length);
                StateStorage.Add(tmpArr);
                k += i;
            }
            i = j;
        }
    }

    public void SmoothSort(int[] arr)
    {
        int n = arr.Length;
        int p = n - 1;
        int q = p;
        int r = 0;

        while (p > 0)
        {
            if ((r & 0x03) == 0)
                Heapify(arr, r, q);

            if (Leonardo(r) == p)
                r++;
            else
            {
                r--;
                q -= Leonardo(r);
                Heapify(arr, r, q);
                q = r - 1;
                r++;
            }

            Swap(ref arr[0], ref arr[p]);
            int[] tmpArr = new int[arr.Length];
            Array.Copy(arr, tmpArr, arr.Length);
            StateStorage.Add(tmpArr);
            p--;
        }

        for (int i = 0; i < n - 1; i++)
        {
            int j = i + 1;
            while (j > 0 && arr[j] < arr[j - 1])
            {
                Swap(ref arr[j], ref arr[j - 1]);
                int[] tmpArr = new int[arr.Length];
                Array.Copy(arr, tmpArr, arr.Length);
                StateStorage.Add(tmpArr);
                j--;
            }
        }
    }

    private static void Swap(ref int a, ref int b)
    {
        int temp = a;
        a = b;
        b = temp;
    }

    public class ArraySorterStateStorage
    {
        public List<int[]> States { get; private set; }
        public int Count = 0;

        public ArraySorterStateStorage()
        {
            States = new();
        }

        public void Add(int[] currentArray)
        {
            Count++;
            States.Add(currentArray);
        }
    }
}
