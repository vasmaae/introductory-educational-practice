using System.Text;

namespace IntroductoryEducationalPractice;

public partial class FormArray : Form
{
    private readonly string[] _tasks =
    {
        "1",
        "2",
        "3",
        "4",
        "5",
        "6",
    };
    private readonly Func<int[,], int[,]>[] _funcs =
    {
        
    };

    private short _taskNumber = -1;
    private int[,] _array/*, _processedArray*/;

    public FormArray()
    {
        InitializeComponent();
    }

    private void ButtonTask_Click(object sender, EventArgs e)
    {
        _taskNumber = (short)(short.Parse(((Button)sender).Text) - 1);
        textBoxOptionalTask.Text = _tasks[_taskNumber];
        textBoxProcessedArray.Text = null;
    }

    private void ButtonGenerate1DArray_Click(object sender, EventArgs e)
    {
        _array = ArrayGenerator.GenerateArray(1, (int)numericUpDownLength.Value, (int)numericUpDownMinValue.Value, (int)numericUpDownMaxValue.Value);

        StringBuilder sb = new();
        for (int i = 0; i < _array.GetLength(1); i++)
        {
            sb.Append(_array[0, i]);
            sb.Append(' ');
        }

        textBoxMassive.Text = sb.ToString();
    }

    private void ButtonGenerate2DArray_Click(object sender, EventArgs e)
    {
        _array = ArrayGenerator.GenerateArray((int)numericUpDownHeight.Value, (int)numericUpDownLength.Value, (int)numericUpDownMinValue.Value, (int)numericUpDownMaxValue.Value);

        StringBuilder sb = new();
        for (int i = 0; i < _array.GetLength(0); i++)
        {
            for (int j = 0; j < _array.GetLength(1); j++)
            {
                sb.Append(_array[i, j]);
                sb.Append(' ');
            }
            sb.Append(Environment.NewLine);
        }

        textBoxMassive.Text = sb.ToString();
    }

    private void ButtonShowProcessedArray_Click(object sender, EventArgs e)
    {
        _funcs[_taskNumber](_array);
    }
}
