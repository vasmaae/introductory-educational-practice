namespace IntroductoryEducationalPractice;

public class ArraySorter
{
    public ArraySorterStateStorage StateStorage { get; private set; }
    public int[] SourceArray;
    public int[] SortedArray;

    const int INSERTION_SORT_THRESHOLD = 16;

    public ArraySorter(int[] arrayForSorting)
    {
        SourceArray = new int[arrayForSorting.Length];
        SortedArray = new int[arrayForSorting.Length];
        Array.Copy(arrayForSorting, SourceArray, arrayForSorting.Length);
        Array.Copy(arrayForSorting, SortedArray, arrayForSorting.Length);

        StateStorage = new();
        StateStorage.Add(SourceArray);
        Introsort(SortedArray);
    }

    public void Introsort(int[] array)
    {
        int depthLimit = 2 * FloorLog2(array.Length);
        IntroSort(array, 0, array.Length - 1, depthLimit);
    }

    private void IntroSort(int[] array, int lo, int hi, int depthLimit)
    {
        while (hi > lo)
        {
            int size = hi - lo + 1;

            if (size <= INSERTION_SORT_THRESHOLD)
            {
                InsertionSort(array, lo, hi);
                return;
            }

            if (depthLimit == 0)
            {
                Heapsort(array, lo, hi);
                return;
            }

            depthLimit--;
            int p = Partition(array, lo, hi);
            IntroSort(array, p + 1, hi, depthLimit);
            hi = p - 1;
        }
    }

    private int Partition(int[] array, int lo, int hi)
    {
        int pivot = array[hi];
        int i = lo;

        for (int j = lo; j < hi; j++)
        {
            if (array[j] < pivot)
            {
                Swap(array, i, j);
                i++;
            }
        }

        Swap(array, i, hi);
        return i;
    }

    private void Heapsort(int[] array, int lo, int hi)
    {
        int n = hi - lo + 1;
        for (int i = n / 2 - 1; i >= 0; i--)
        {
            Heapify(array, n, i, lo);
        }

        for (int i = n - 1; i > 0; i--)
        {
            Swap(array, lo, lo + i);
            Heapify(array, i, 0, lo);
        }
    }

    private void Heapify(int[] array, int n, int i, int lo)
    {
        int largest = i;
        int left = 2 * i + 1;
        int right = 2 * i + 2;

        if (left < n && array[lo + left] > array[lo + largest])
        {
            largest = left;
        }

        if (right < n && array[lo + right] > array[lo + largest])
        {
            largest = right;
        }

        if (largest != i)
        {
            Swap(array, lo + i, lo + largest);
            Heapify(array, n, largest, lo);
        }
    }

    private void InsertionSort(int[] array, int lo, int hi)
    {
        for (int i = lo + 1; i <= hi; i++)
        {
            int key = array[i];
            int j = i - 1;

            while (j >= lo && array[j] > key)
            {
                array[j + 1] = array[j];
                j--;
            }

            array[j + 1] = key;
        }
    }

    private void Swap(int[] array, int i, int j)
    {
        int temp = array[i];
        array[i] = array[j];
        array[j] = temp;

        StateStorage.Add((int[])array.Clone());
    }

    private int FloorLog2(int n)
    {
        int result = 0;
        while (n >= 1)
        {
            result++;
            n /= 2;
        }
        return result;
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
