using System.Text;

namespace IntroductoryEducationalPractice;

public partial class FormArray : Form
{
    private readonly string[] _tasks =
    {
        "1.10. Дан целочисленный массив размера N. Назовем серией группу подряд идущих элементов с одинаковым знаком, а длиной серии – количество этих элементов (в серии должно быть не менее 2 элементов). Найти серии с максимальной длиной для положительных чисел и отрицательных чисел. Вывести с какой позиции начинается каждая серия и сколько в ней элементов.",
        "2.",
        "3",
        "4",
        "5",
        "6",
    };

    private short _taskNumber = -1;
    private int[] _array1D/*, _processedArray1D*/;
    private int[,] _array2D/*, _processedArray2D*/;

    public FormArray()
    {
        InitializeComponent();
    }

    private void ButtonTask_Click(object sender, EventArgs e)
    {
        _taskNumber = (short)(short.Parse(((Button)sender).Text) - 1);
        textBoxOptionalTask.Text = _tasks[_taskNumber];
        textBoxSolution.Text = null;
    }

    private void ButtonGenerate1DArray_Click(object sender, EventArgs e)
    {
        _array2D = new int[0, 0];
        _array1D = [];

        int[] array = ArrayGenerator.GenerateArray((int)numericUpDownLength.Value, (int)numericUpDownMinValue.Value, (int)numericUpDownMaxValue.Value);

        StringBuilder sb = new();
        sb.Append(string.Join(' ', array));
        textBoxMassive.Text = sb.ToString();
    }

    private void ButtonGenerate2DArray_Click(object sender, EventArgs e)
    {
        _array2D = new int[0, 0];
        _array1D = [];

        int[,] array = ArrayGenerator.GenerateArray((int)numericUpDownHeight.Value, (int)numericUpDownLength.Value, (int)numericUpDownMinValue.Value, (int)numericUpDownMaxValue.Value);

        StringBuilder sb = new();
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                sb.Append(array[i, j]);
                sb.Append(' ');
            }
            sb.Append(Environment.NewLine);
        }

        textBoxMassive.Text = sb.ToString();
    }

    private void GetArray1D()
    {
        string[] array = textBoxMassive.Text.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        _array2D = new int[0, 0];
        _array1D = new int[array.Length];

        for (int i = 0; i < array.Length; i++)
        {
            _array1D[i] = int.Parse(array[i]);
        }
    }

    private void GetArray2D()
    {
        string[] subarrays = textBoxMassive.Text.Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries);
        _array1D = [];
        _array2D = new int[subarrays.Length, subarrays[0].Split(' ', StringSplitOptions.RemoveEmptyEntries).Length];

        string[] subarraySplited;
        for (int i = 0; i < subarrays.Length; i++)
        {
            subarraySplited = subarrays[i].Split(' ', StringSplitOptions.RemoveEmptyEntries);
            
            for (int j = 0; j < subarraySplited.Length; j++)
            {
                _array2D[i, j] = int.Parse(subarraySplited[j]);
            }
        }
    }

    private void ButtonShowSolution_Click(object sender, EventArgs e)
    {
        try
        {
            switch (_taskNumber)
            {
                case 0:
                    GetArray1D();
                    textBoxSolution.Text = ArrayHandler.Task1(_array1D);
                    break;

                case 1:
                    GetArray1D();
                    textBoxSolution.Text = ArrayHandler.Task2(_array1D);
                    break;

                case 2:
                    GetArray1D();
                    textBoxSolution.Text = ArrayHandler.Task3(_array1D);
                    break;

                case 3:
                    GetArray1D();
                    textBoxSolution.Text = ArrayHandler.Task4(_array1D);
                    break;

                case 4:
                    GetArray2D();
                    textBoxSolution.Text = ArrayHandler.Task5(_array2D);
                    break;

                case 5:
                    GetArray2D();
                    textBoxSolution.Text = ArrayHandler.Task6(_array2D);
                    break;
            }
        }
        catch (FormatException _)
        {
            MessageBox.Show("Ошибка", "Неверный формат ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        catch (Exception _)
        {
            MessageBox.Show("Недостаточно данных или данные не верны", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
