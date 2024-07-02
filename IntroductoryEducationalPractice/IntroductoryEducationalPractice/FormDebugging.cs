using Microsoft.Extensions.Logging;

namespace IntroductoryEducationalPractice;

public partial class FormDebugging : Form
{
    private readonly ILogger _logger;

    public FormDebugging(ILogger<FormDebugging> logger)
    {
        InitializeComponent();
        _logger = logger;
    }

    private void ButtonCalculate_Click(object sender, EventArgs e)
    {
        try
        {
            double x = double.Parse(textBoxXValue.Text);
            _logger.LogInformation($"Значение x считано, x = {x}");
            dataGridView.Rows.Add(x, "", "", "", "");

            _logger.LogInformation("Начато вычисление функции y");
            double y = (x * x / 4 + x / 2 + 1) * Math.Exp(x / 2);
            _logger.LogInformation($"Значение функции у = {y}");
            dataGridView.Rows.Add("", y, "", "");
            textBoxFuncY.Text = y.ToString();

            _logger.LogInformation("Начато вычисление суммы s");
            double s = 1;
            for (int i = 1; i <= 30; i++)
            {
                int k = 1;
                for (int j = 2; j <= i; j++)
                    k *= j;
                double slag = Math.Pow(x / 2, i) * (i * i) / k;
                s += slag;

                _logger.LogInformation($"Промежуточное слагаемое slag = {slag}");
                dataGridView.Rows.Add("", "", slag, "", "");

                _logger.LogInformation($"Верхнее число = {i * i}");
                dataGridView.Rows.Add("", "", "", i * i, "");

                _logger.LogInformation($"Промежуточное значение суммы s = {s}");
                dataGridView.Rows.Add("", "", "", "", s);
            }
            _logger.LogInformation($"Значение суммы s = {s}");
            dataGridView.Rows.Add("", "", "", "", s);
            textBoxSumS.Text = s.ToString();
        }
        catch (Exception ex)
        {
            _logger.LogError(ex.Message);
            MessageBox.Show(ex.Message);
        }
    }
}
