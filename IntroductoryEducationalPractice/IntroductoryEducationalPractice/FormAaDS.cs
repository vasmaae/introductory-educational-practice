using System.Text;

namespace IntroductoryEducationalPractice;

public partial class FormAaDS : Form
{
    private Random random = new();
    private Queue<int> queue = new();

    private ArraySorter sorter;
    private int step = 0;

    public FormAaDS()
    {
        InitializeComponent();
    }

    private void ButtonAdd_Click(object sender, EventArgs e)
    {
        queue.Enqueue(random.Next(-20, 20));
    }

    private void ButtonDelete_Click(object sender, EventArgs e)
    {
        queue.Dequeue();
    }

    private void ButtonShow_Click(object sender, EventArgs e)
    {
        textBoxADTValues.Text = string.Join(' ', queue.list);
    }

    private void ButtonGenerateArray_Click(object sender, EventArgs e)
    {
        if (textBoxSourceArray.Text.Length == 0)
        {
            StringBuilder sb = new();

            for (int i = 0; i < 10; i++)
            {
                sb.Append(random.Next(-20, 20));
                sb.Append(' ');
            }

            textBoxSourceArray.Text = sb.ToString();
        }
    }

    private void ButtonSortArray_Click(object sender, EventArgs e)
    {
        string[] strArray = textBoxSourceArray.Text.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        int[] array = new int[strArray.Length];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = int.Parse(strArray[i]);
        }

        sorter = new(array);
        textBoxSortedArray.Text = string.Join(' ', sorter.SortedArray);
    }

    private void ButtonNextState_Click(object sender, EventArgs e)
    {
        if (step == sorter.StateStorage.Count - 1) textBoxState.Text = string.Join(' ', sorter.StateStorage.States[step]);
        else textBoxState.Text = string.Join(' ', sorter.StateStorage.States[++step]);
    }

    private void ButtonPrevState_Click(object sender, EventArgs e)
    {
        textBoxState.Text = string.Join(' ', sorter.StateStorage.States[(step == 0) ? 0 : --step]);
    }

    private void buttonShowSubsequence_Click(object sender, EventArgs e)
    {
        string[] strArray = textBoxSource.Text.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        int[] array = new int[strArray.Length];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = int.Parse(strArray[i]);
        }
        textBoxLongestIncreasingSubsequence.Text = string.Join(' ', LongestIncreasingSubsequence.GetLongestIncreasingSubsequence(array));
    }
}
